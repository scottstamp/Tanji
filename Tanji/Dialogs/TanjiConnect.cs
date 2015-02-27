using System;
using System.IO;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using System.Threading.Tasks;

using Tanji.Properties;

using Sulakore;
using Sulakore.Editor;
using Sulakore.Editor.Tags;
using Sulakore.Communication;
using Sulakore.Habbo;

namespace Tanji.Dialogs
{
    public partial class TanjiConnect : Form
    {
        public enum Mode
        {
            Automatic = 0,
            Manual = 1
        }

        #region Private Fields
        private Main _main;
        private ShockwaveFlash _flash;

        private int _aTick, _maskPort;
        private string _aStatus, _maskHost;
        private bool _setupFinished, _wasSetInManual, _replaceKeys;

        private readonly EventHandler _onConnected;
        private readonly Action<string> _processSwf;

        private static readonly Encoding _encoding;
        private static readonly Color _tanjiGlowColor;

        private const int DefaultPort = 38101;
        private const int EavesdropperPort = 8080;

        private const string ASprite = "...";
        private const string HabboName = "var habboName = \"";
        private const string VarClientUrl = "var clientUrl = \"";
        private const string DefaultHost = "game-us.habbo.com";
        private const string InfoHost = "\"connection.info.host\" : ";
        private const string InfoPort = "\"connection.info.port\" : ";
        private const string FlashClientUrl = "\"flash.client.url\" : ";
        private const string PatchedClientsDirectory = "Patched Clients";
        private const string HotelViewBannerUrl = "\"hotelview.banner.url\" : ";
        private const string ResourceNotFound = "Unable to locate resource '{0}.swf' in the Patched Clients folder.";
        private const string ManualMissing = "You must fill in both fields(Host/Port) to continue with the connection process.";
        private const string HostExtractFail = "Unable to retrieve the target's 'connection.info.host' value, a mask is needed to bypass this problem.";
        private const string PortExtractFail = "Unable to retrieve the target's 'connection.info.port' value, a mask is needed to bypass this problem.";
        #endregion

        #region Public Properties
        public Mode TanjiMode { get; private set; }
        public string PlayerName { get; private set; }
        public HGameData GameData { get; private set; }

        public bool UseCustomClient { get; private set; }
        public string FlashClientRevision { get; private set; }

        public int CustomExponent { get; private set; }
        public string CustomModulus { get; private set; }
        #endregion

        #region Constructor(s)
        static TanjiConnect()
        {
            _encoding = new UTF8Encoding();
            _tanjiGlowColor = Color.FromArgb(243, 63, 63);
        }
        public TanjiConnect(Main main)
        {
            _main = main;

            InitializeComponent();

            if (!Directory.Exists(PatchedClientsDirectory))
                Directory.CreateDirectory(PatchedClientsDirectory);

            Eavesdropper.DisableCache = true;
            Eavesdropper.OnEavesResponse += Eavesdropper_OnEavesResponse;

            _onConnected = Game_Connected;
            _processSwf = ProcessSwf;
        }
        #endregion

        #region User Interface Event Listeners
        private void TanjiConnect_Load(object sender, EventArgs e)
        {
            LoadSettings();
        }

        private void Connect_Click(object sender, EventArgs e)
        {
            ushort port;
            string host = GameHostTxt.Text.Trim();
            bool portConversionSuccess = ushort.TryParse(GamePortTxt.Text.Trim(), out port);

            switch (TanjiMode)
            {
                case Mode.Automatic:
                {
                    StartAnimation("Extracting Host/Port");

                    if (!string.IsNullOrWhiteSpace(host)) _maskHost = host.ToLower();
                    if (portConversionSuccess) _maskPort = port;

                    SKore.ClearCache();
                    Eavesdropper.Initiate(EavesdropperPort);
                    break;
                }
                case Mode.Manual:
                {
                    if (string.IsNullOrWhiteSpace(host) || !portConversionSuccess)
                    {
                        const string message = "You've specified invalid details into the connection input boxes, please correct these issues before you can continue.";
                        MessageBox.Show(message, Main.TanjiError, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (UseCustomClient)
                    {
                        SKore.ClearCache();
                        Eavesdropper.Initiate(EavesdropperPort);
                    }
                    StartAnimation("Connecting% | Port: " + port);

                    Main.Game = new HConnection(host, port);
                    Main.Game.Connected += Game_Connected;
                    Main.Game.Connect(true);
                    break;
                }
            }

            ProcessBtn.Text = "Cancel";
            ProcessBtn.Click -= Connect_Click;
            ProcessBtn.Click += Cancel_Click;
        }
        private void Cancel_Click(object sender, EventArgs e)
        {
            ResetSetup();
            if (Main.Game != null)
            {
                Main.Game.Dispose();
                Main.Game = null;
            }
        }

        private void Manual_Click(object sender, EventArgs e)
        {
            if (!SetTanjiMode(Mode.Manual)) return;

            if (CustomChckbx.Checked && !_wasSetInManual)
                CustomChckbx.Checked = PromptUseCustomClient();
        }
        private void Automatic_Click(object sender, EventArgs e)
        {
            SetTanjiMode(Mode.Automatic);
        }

        private void ATimer_Tick(object sender, EventArgs e)
        {
            StatusTxt.Text = _aStatus.Replace("%", ASprite.Substring(0, _aTick + 1));
            _aTick += _aTick == 2 ? -2 : 1;
        }
        private void BrowseBtn_Click(object sender, EventArgs e)
        {
            ChooseClientDlg.FileName = ChooseClientDlg.SafeFileName;
            if (ChooseClientDlg.ShowDialog() != DialogResult.OK) return;

            ProcessSwf(ChooseClientDlg.FileName);
        }
        private void CustomChckbx_CheckedChanged(object sender, EventArgs e)
        {
            _wasSetInManual = (TanjiMode == Mode.Manual);

            bool enable = (CustomChckbx.Checked && _wasSetInManual ? PromptUseCustomClient() : CustomChckbx.Checked);
            CustomChckbx.Checked = CustomClientTxt.Enabled = BrowseBtn.Enabled = enable;

            UseCustomClient = (_flash != null && !_flash.IsCompressed && enable);
        }
        private void GameHostTxt_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TanjiMode == Mode.Manual)
                GamePortTxt.SelectedIndex = Convert.ToInt32(GameHostTxt.SelectedIndex != 0);
        }

        private void TanjiConnect_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Effect != DragDropEffects.Copy) return;

            CustomChckbx.Checked = true;
            ProcessSwf(((string[])(e.Data.GetData(DataFormats.FileDrop)))[0]);
        }
        private void TanjiConnect_DragEnter(object sender, DragEventArgs e)
        {
            if (((string[])(e.Data.GetData(DataFormats.FileDrop)))[0].EndsWith(".swf"))
                e.Effect = DragDropEffects.Copy;
        }

        private void TanjiConnect_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveSettings();
            if (!_setupFinished)
            {
                Eavesdropper.Terminate();

                if (Main.Game != null)
                    Main.Game.Dispose();

                Environment.Exit(0);
            }
            ResetSetup();
        }
        #endregion

        #region Game Connection Event Listeners
        private void Game_Connected(object sender, EventArgs e)
        {
            if (InvokeRequired) { Invoke(_onConnected, sender, e); return; }

            if (!string.IsNullOrWhiteSpace(ExponentTxt.Text))
            {
                int customExp = 0;
                if (int.TryParse(ExponentTxt.Text, out customExp))
                    CustomExponent = customExp;
            }
            if (!string.IsNullOrWhiteSpace(ModulusTxt.Text))
                CustomModulus = ModulusTxt.Text;

            _main.HookGameEvents();

            _setupFinished = true;
            Close();
        }
        #endregion

        #region Eavesdropper Event Listerners
        private void Eavesdropper_OnEavesResponse(object sender, EavesResponseEventArgs e)
        {
            if (UseCustomClient && e.IsSwf && e.ResponeData.Length > 3000000)
            {
                if (!_replaceKeys) e.ResponeData = _flash.ToBytes();
                else
                {
                    SetAnimation("Modifying client");
                    _flash = new ShockwaveFlash(e.ResponeData);

                    ReplaceKeys(_flash);
                    e.ResponeData = _flash.ToBytes();

                    string clientPath = PatchedClientsDirectory + "\\" + FlashClientRevision + ".swf";
                    Task.Factory.StartNew(() => _flash.Save(clientPath, true));
                }
                Eavesdropper.Terminate();
                SetAnimation("Connecting% | Port: " + _maskPort);
                return;
            }
            else if (TanjiMode == Mode.Manual) return;

            string response = _encoding.GetString(e.ResponeData);
            if (response.Contains(InfoHost) && response.Contains(InfoPort))
            {
                string flashVars = response.GetChild("var flashvars", '}');
                while (!flashVars.Contains(InfoHost) || !flashVars.Contains(InfoPort))
                    flashVars = flashVars.GetChild("var flashvars = {", '}');

                string extractedHost = flashVars.GetChild(InfoHost, ',').Trim();
                string extractedPort = flashVars.GetChild(InfoPort, ',').Trim();

                if (string.IsNullOrEmpty(_maskHost))
                {
                    if (!extractedHost.StartsWith("\""))
                    {
                        PromptEavesdropperReset(HostExtractFail, Main.TanjiError, MessageBoxIcon.Error);
                        return;
                    }
                    else _maskHost = extractedHost.Split('"')[1];
                }

                if (_maskPort == 0)
                {
                    if (!extractedPort.StartsWith("\""))
                    {
                        PromptEavesdropperReset(PortExtractFail, Main.TanjiError, MessageBoxIcon.Error);
                        return;
                    }
                    else _maskPort = ushort.Parse(extractedPort.Split(',')[0].Split('"')[1]);
                }

                PlayerName = response.Contains(HabboName)
                    ? response.GetChild(HabboName, '"') : string.Empty;

                if (!string.IsNullOrEmpty(PlayerName))
                    GameData = HGameData.Parse(response);

                if (!UseCustomClient)
                {
                    FlashClientRevision = ("http://" + response.GetChild(FlashClientUrl, ',').Split('"')[1].Substring(3)).Split('/')[4];
                    string patchedClientPath = PatchedClientsDirectory + "\\" + FlashClientRevision + ".swf";

                    if (!File.Exists(patchedClientPath)) UseCustomClient = _replaceKeys = true;
                    else Invoke(new MethodInvoker(() => ProcessSwf(patchedClientPath)));
                }

                if (!UseCustomClient)
                {
                    Eavesdropper.Terminate();
                    SetAnimation("Connecting% | Port: " + _maskPort);
                }
                else SetAnimation("Waiting for client");

                Main.Game = new HConnection(_maskHost, _maskPort);
                Main.Game.Connected += Game_Connected;
                Main.Game.Connect(true);
            }
        }
        #endregion

        #region Overrided Methods
        protected override void OnResizeEnd(EventArgs e)
        {
            base.OnResizeEnd(e);
            var screen = Screen.FromPoint(Location);
            if (Main.DoSnap(Left, screen.WorkingArea.Left)) Left = screen.WorkingArea.Left;
            if (Main.DoSnap(Top, screen.WorkingArea.Top)) Top = screen.WorkingArea.Top;
            if (Main.DoSnap(screen.WorkingArea.Right, Right)) Left = screen.WorkingArea.Right - Width;
            if (Main.DoSnap(screen.WorkingArea.Bottom, Bottom)) Top = screen.WorkingArea.Bottom - Height;
        }
        #endregion

        #region Private Methods
        private void ResetSetup()
        {
            Eavesdropper.Terminate();

            _maskPort = 0;
            _replaceKeys = false;
            _setupFinished = false;
            _maskHost = string.Empty;

            if (!CustomChckbx.Checked)
                CustomClientTxt.Text = string.Empty;

            StopAnimation("Standing By...");
            if (ProcessBtn.Text == "Cancel")
            {
                ProcessBtn.Text = "Connect";
                ProcessBtn.Click -= Cancel_Click;
                ProcessBtn.Click += Connect_Click;
            }
        }
        private void ProcessSwf(string path)
        {
            if (InvokeRequired) { Invoke(_processSwf, path); return; }

            CustomClientTxt.Text = path;
            Cursor = Cursors.WaitCursor;
            try
            {
                _flash = new ShockwaveFlash(path);
            }
            catch
            {
                _flash = null;
                CustomChckbx.Checked = false;
                CustomClientTxt.Text = string.Empty;
            }
            UseCustomClient = (_flash != null && !_flash.IsCompressed);
            Cursor = Cursors.Default;
        }
        private bool PromptUseCustomClient()
        {
            const string message = "The connection mode is currently set to manual which will not run Eavesdropper(proxy), although specifying a custom client will override that rule and enable Eavesdropper to inject our own client; Do you still wish to use a custom client?";
            DialogResult result = MessageBox.Show(message, Main.TanjiWarning, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            return result == DialogResult.Yes;
        }
        private void PromptEavesdropperReset(string message, string title, MessageBoxIcon icon)
        {
            ResetSetup();
            MessageBox.Show(message, title, MessageBoxButtons.OK, icon);
        }

        private void ReplaceKeys(ShockwaveFlash flash)
        {
            foreach (IFlashTag flashTag in _flash.Tags)
            {
                if (flashTag.Header.Tag != FlashTagType.DefineBinaryData) continue;

                var binTag = (DefineBinaryDataTag)flashTag;
                string binDat = _encoding.GetString(binTag.Data);

                if (binDat.Contains("habbo_login_dialog"))
                {
                    const string dummyFieldPrefix = "name=\"dummy_field\" caption=\"";
                    string encodedKeys = binDat.GetChild(dummyFieldPrefix, '"');
                    ExtractRSAKeys(encodedKeys);

                    string encodedFakeKeys = EncodeRSAKeys(Main.FEXPONENT.ToString(), Main.FMODULUS);
                    binDat = binDat.Replace(encodedKeys, encodedFakeKeys);

                    binTag.Data = _encoding.GetBytes(binDat);
                    flash.Compile();
                    break;
                }
            }
        }
        private void ExtractRSAKeys(string base64MergedKeys)
        {
            byte[] data = Convert.FromBase64String(base64MergedKeys);
            string mergedKeys = _encoding.GetString(data);

            int modLength = mergedKeys[0];
            Main.RModulus = mergedKeys.Substring(1, modLength);

            mergedKeys = mergedKeys.Substring(modLength);
            Main.RExponent = int.Parse(mergedKeys.Substring(2));
        }
        private string EncodeRSAKeys(string exponent, string modulus)
        {
            string mergedKeys = string.Format("{0}{1} {2}",
                (char)modulus.Length, modulus, exponent);

            byte[] data = _encoding.GetBytes(mergedKeys);
            return Convert.ToBase64String(data);
        }

        private void SetAnimation(string status)
        {
            if (!status.Contains("%")) status += "%";
            _aStatus = status;
        }
        private void StopAnimation(string status)
        {
            ATimer.Stop();
            StatusTxt.Text = status;
        }
        private void StartAnimation(string status)
        {
            if (!status.Contains("%")) status += "%";

            _aStatus = status;
            ATimer.Start();
        }

        private void LoadSettings()
        {
            string port = Settings.Default.LastPort;
            string host = Settings.Default.LastHost;
            var mode = (Mode)Settings.Default.LastMode;

            if (!string.IsNullOrWhiteSpace(port))
            {
                ushort gamePort = 0;
                if (ushort.TryParse(port, out gamePort))
                {
                    if (!GamePortTxt.Items.Contains(port))
                        GamePortTxt.Items.Add(port);

                    GamePortTxt.Text = port;
                }
            }
            else if (mode == Mode.Manual) GamePortTxt.SelectedIndex = 0;

            if (!string.IsNullOrWhiteSpace(host))
            {
                if (!GameHostTxt.Items.Contains(host))
                    GameHostTxt.Items.Add(host);

                GameHostTxt.Text = host;
            }

            if (Enum.IsDefined(typeof(Mode), mode))
                SetTanjiMode(mode);
        }
        private void SaveSettings()
        {
            Settings.Default.LastPort = GamePortTxt.Text;
            Settings.Default.LastHost = GameHostTxt.Text;
            Settings.Default.LastMode = (int)TanjiMode;

            Settings.Default.Save();
        }
        private bool SetTanjiMode(Mode mode)
        {
            if (TanjiMode == mode) return false;

            TanjiMode = mode;
            Text = string.Format("Tanji ~ Connection Setup [{0}]", mode);

            ManualH.BackColor = (mode == Mode.Manual ? _tanjiGlowColor : Color.Silver);
            AutomaticH.BackColor = (mode == Mode.Automatic ? _tanjiGlowColor : Color.Silver);

            string labelSuffix = (mode == Mode.Automatic ? " ( Mask )" : string.Empty);
            GameHostLbl.Text = "Game Host" + labelSuffix;
            GamePortLbl.Text = "Game Port" + labelSuffix;

            if (TanjiMode == Mode.Automatic)
            {
                GameHostTxt.SelectedIndex = -1;
                GamePortTxt.SelectedIndex = -1;
                GameHostTxt.Text = GamePortTxt.Text = string.Empty;
            }
            else if (GameHostTxt.SelectedIndex < 0) GameHostTxt.SelectedIndex = 0;
            else GamePortTxt.SelectedIndex = Convert.ToInt32(GameHostTxt.SelectedIndex != 0);
            return true;
        }
        #endregion
    }
}