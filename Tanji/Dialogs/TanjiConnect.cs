using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

using Sulakore;
using Sulakore.Habbo;
using Sulakore.Editor;
using Sulakore.Editor.Tags;
using Sulakore.Communication;

using Tanji.Utilities;
using System.Threading.Tasks;

namespace Tanji.Dialogs
{
    public partial class TanjiConnect : Form
    {
        #region Private Fields
        private Main _main;
        private ShockwaveFlash _flash;

        private int _maskPort;
        private string _maskHost;
        private bool _setupFinished, _wasSetInManual, _replaceKeys;

        private readonly EventHandler _onConnected;
        private readonly Action<string> _processSwf;
        #endregion

        public HGameData GameData { get; private set; }
        public bool UseCustomClient { get; private set; }

        public TanjiConnect(Main main)
        {
            InitializeComponent();

            if (!Directory.Exists("Patched Clients"))
                Directory.CreateDirectory("Patched Clients");

            Eavesdropper.IsCacheDisabled = true;
            Eavesdropper.EavesdropperResponse += Eavesdropper_EavesdropperResponse;

            _main = main;
            _processSwf = ProcessSwf;
            _onConnected = Game_Connected;
        }

        private void Connect_Click(object sender, EventArgs e)
        {
            int gamePort = 0;
            string gameHost = GameHostTxt.Text.ToLower();
            bool portConvertSuccess = int.TryParse(GamePortTxt.Text, out gamePort);

            ProcessBtn.Click -= Connect_Click;
            ProcessBtn.Click += Cancel_Click;
            ProcessBtn.Text = "Cancel";
            ToggleSetupControls(false);

            if (TanjiMode.IsManual)
            {
                if (UseCustomClient)
                    Eavesdropper.Initiate();

                _main.Game = new HConnection(gameHost, gamePort);
                _main.Game.Connected += Game_Connected;
                _main.Game.Connect(true);

                StatusTxt.BeginAnimation("Connecting{0} | Port: " + GamePortTxt.Text, "...");
            }
            else
            {
                _maskHost = gameHost;
                _maskPort = gamePort;
                Eavesdropper.Initiate();

                StatusTxt.BeginAnimation("Extracting Host/Port{0}", "...");
            }
        }
        private void Cancel_Click(object sender, EventArgs e)
        {
            ProcessBtn.Click -= Cancel_Click;
            ProcessBtn.Click += Connect_Click;
            ProcessBtn.Text = "Connect";

            ResetSetup();
            if (_main.Game != null)
            {
                _main.Game.Dispose();
                _main.Game = null;
            }
        }

        private void BrowseBtn_Click(object sender, EventArgs e)
        {
            ChooseClientDlg.FileName = ChooseClientDlg.SafeFileName;
            if (ChooseClientDlg.ShowDialog() != DialogResult.OK) return;

            ProcessSwf(ChooseClientDlg.FileName);
        }
        private void CustomChckbx_CheckedChanged(object sender, EventArgs e)
        {
            _wasSetInManual = TanjiMode.IsManual;

            CustomChckbx.Checked = CustomClientTxt.Enabled = BrowseBtn.Enabled = true;

            UseCustomClient = (_flash != null && !_flash.IsCompressed);
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
            TanjiSettings.Save();
            if (!_setupFinished)
            {
                Eavesdropper.Terminate();

                if (_main.Game != null)
                    _main.Game.Dispose();

                Environment.Exit(0);
            }
            ResetSetup();
        }

        private void Game_Connected(object sender, EventArgs e)
        {
            if (InvokeRequired) { Invoke(_onConnected, sender, e); return; }

            if (!string.IsNullOrWhiteSpace(ExponentTxt.Text))
            {
                int customExp = 0;
                if (int.TryParse(ExponentTxt.Text, out customExp))
                    _main.Exponent = customExp;
            }
            if (!string.IsNullOrWhiteSpace(ModulusTxt.Text))
                _main.Modulus = ModulusTxt.Text;

            _main.HookGameEvents();

            _setupFinished = true;
            Close();
        }

        private void Eavesdropper_EavesdropperResponse(EavesdropperResponseEventArgs e)
        {
            if (UseCustomClient && e.Response.ContentType == "application/x-shockwave-flash"
                && e.Payload.Length > 3000000)
            {
                if (!_replaceKeys) e.Payload = _flash.ToBytes();
                else
                {
                    _flash = new ShockwaveFlash(e.Payload);

                    ReplaceKeys(_flash);
                    e.Payload = _flash.ToBytes();

                    string clientPath = Path.Combine("Patched Clients", GameData.FlashClientBuild + ".swf");
                    Task.Factory.StartNew(() => _flash.Save(clientPath, true));
                }
                e.ShouldTerminate = true;
                StatusTxt.BeginAnimation("Connecting{0} | Port: " + _maskPort, "...");
                return;
            }
            else if (TanjiMode.IsManual) return;

            string response = Encoding.UTF8.GetString(e.Payload);
            if (response.Contains("connection.info.host") && response.Contains("connection.info.port"))
            {
                GameData = new HGameData(response);
                if (!UseCustomClient)
                {
                    string patchedClientPath = Path.Combine("Patched Clients", GameData.FlashClientBuild + ".swf");

                    if (!File.Exists(patchedClientPath)) UseCustomClient = _replaceKeys = true;
                    else Invoke(new MethodInvoker(() => ProcessSwf(patchedClientPath)));
                }

                if (!UseCustomClient)
                {
                    Eavesdropper.Terminate();
                    StatusTxt.BeginAnimation("Connecting{0} | Port: " + _maskPort, "...");
                }
                else if (_replaceKeys) StatusTxt.BeginAnimation("Modifying Client{0}", "...");
                else StatusTxt.BeginAnimation("Replacing Client{0}", "...");

                _main.Game = new HConnection(GameData.Host, GameData.Port);
                _main.Game.Connected += Game_Connected;
                _main.Game.Connect(true);
            }
        }

        private void ResetSetup()
        {
            Eavesdropper.Terminate();

            _replaceKeys = false;
            _setupFinished = false;

            _maskPort = 0;
            _maskHost = string.Empty;

            ToggleSetupControls(true);

            if (!CustomChckbx.Checked)
                CustomClientTxt.Text = string.Empty;

            StatusTxt.EndAnimation("Standing By...");
        }
        private void ProcessSwf(string path)
        {
            if (InvokeRequired) { Invoke(_processSwf, path); return; }

            try { _flash = new ShockwaveFlash(path); }
            catch
            {
                CustomChckbx.Checked = false;
                CustomClientTxt.Text = string.Empty;
            }
            finally
            {
                UseCustomClient = (_flash != null && !_flash.IsCompressed);

                if (UseCustomClient)
                    CustomClientTxt.Text = path;
            }
        }

        private void ReplaceKeys(ShockwaveFlash flash)
        {
            foreach (IFlashTag flashTag in _flash.Tags)
            {
                if (flashTag.Header.Tag != FlashTagType.DefineBinaryData) continue;

                var binTag = (DefineBinaryDataTag)flashTag;
                string binDat = Encoding.UTF8.GetString(binTag.Data);

                if (binDat.Contains("habbo_login_dialog"))
                {
                    const string dummyFieldPrefix = "name=\"dummy_field\" caption=\"";
                    string encodedKeys = binDat.GetChild(dummyFieldPrefix, '"');
                    ExtractRSAKeys(encodedKeys);

                    string encodedFakeKeys = EncodeRSAKeys(Main.FAKE_EXPONENT.ToString(), Main.FAKE_MODULUS);
                    binDat = binDat.Replace(encodedKeys, encodedFakeKeys);

                    binTag.Data = Encoding.UTF8.GetBytes(binDat);
                    flash.Compile();
                    break;
                }
            }
        }
        private void ExtractRSAKeys(string base64MergedKeys)
        {
            byte[] data = Convert.FromBase64String(base64MergedKeys);
            string mergedKeys = Encoding.UTF8.GetString(data);

            int modLength = mergedKeys[0];
            _main.Modulus = mergedKeys.Substring(1, modLength);

            mergedKeys = mergedKeys.Substring(modLength);
            _main.Exponent = int.Parse(mergedKeys.Substring(2));
        }
        private string EncodeRSAKeys(string exponent, string modulus)
        {
            string mergedKeys = string.Format("{0}{1} {2}",
                (char)modulus.Length, modulus, exponent);

            byte[] data = Encoding.UTF8.GetBytes(mergedKeys);
            return Convert.ToBase64String(data);
        }

        private void ToggleSetupControls(bool enable)
        {
            TanjiMode.Enabled = enable;
            GameHostTxt.Enabled = GamePortTxt.Enabled = enable;
            ExponentTxt.ReadOnly = ModulusTxt.ReadOnly = !enable;

            CustomChckbx.Enabled = enable;
            CustomClientTxt.ReadOnly = !enable;
        }

        private void TanjiMode_ModeChanged(object sender, EventArgs e)
        {
            Text = string.Format("Tanji ~ Connection Setup [{0}]",
                TanjiMode.IsManual ? "Manual" : "Automatic");

            if (!TanjiMode.IsManual)
            {
                GameHostTxt.SelectedIndex = -1;
                GamePortTxt.SelectedIndex = -1;
                GameHostTxt.Text = GamePortTxt.Text = string.Empty;
            }
        }
    }
}