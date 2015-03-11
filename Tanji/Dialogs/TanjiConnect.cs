using System;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;

using Sulakore;
using Sulakore.Habbo;
using Sulakore.Editor;
using Sulakore.Editor.Tags;
using Sulakore.Communication;

using Tanji.Utilities;

namespace Tanji.Dialogs
{
    public partial class TanjiConnect : Form
    {
        private Main _main;
        private bool _replaceKeys;
        private ShockwaveFlash _flash;

        private readonly Random _numberGenerator;
        private readonly Action<string> _loadGameClient;

        public HGameData GameData { get; private set; }
        public bool UseCustomClient { get; private set; }

        public TanjiConnect(Main main)
        {
            InitializeComponent();

            _main = main;
            _loadGameClient = LoadGameClient;
            _numberGenerator = new Random();

            if (!Directory.Exists("Patched Clients"))
                Directory.CreateDirectory("Patched Clients");

            Eavesdropper.IsCacheDisabled = true;
            Eavesdropper.EavesdropperResponse += Eavesdropper_EavesdropperResponse;
        }

        private void BrowseBtn_Click(object sender, EventArgs e)
        {
            ChooseClientDlg.FileName = ChooseClientDlg.SafeFileName;

            if (ChooseClientDlg.ShowDialog() == DialogResult.OK)
                LoadGameClient(ChooseClientDlg.FileName);
        }
        private void ConnectBtn_Click(object sender, EventArgs e)
        {
            bool isCancelling = ConnectBtn.Text == "Cancel";
            ConnectBtn.Text = isCancelling ? "Connect" : "Cancel";

            if (isCancelling)
            {
                ResetSetup();
                _main.Game.Disconnect();
                return;
            }

            _main.Modulus = ModulusTxt.Text;
            _main.Exponent = int.Parse(string.IsNullOrEmpty(ExponentTxt.Text)
                ? "0" : ExponentTxt.Text);

            int gamePort = 0;
            string gameHost = GameHostTxt.Text.ToLower();
            bool portConvertSuccess = int.TryParse(GamePortTxt.Text, out gamePort);

            if (TanjiMode.IsManual)
            {
                if (UseCustomClient)
                    Eavesdropper.Initiate();

                _main.Game.Connect(true, gameHost, gamePort);
                StatusTxt.BeginAnimation("Connecting{0} | Port: " + GamePortTxt.Text, "...");
            }
            else
            {
                Eavesdropper.Initiate();
                StatusTxt.BeginAnimation("Extracting Host/Port{0}", "...");
            }
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

        private void TanjiConnect_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Effect == DragDropEffects.Copy)
                LoadGameClient(((string[])(e.Data.GetData(DataFormats.FileDrop)))[0]);
        }
        private void TanjiConnect_DragEnter(object sender, DragEventArgs e)
        {
            if (((string[])(e.Data.GetData(DataFormats.FileDrop)))[0].EndsWith(".swf"))
                e.Effect = DragDropEffects.Copy;
        }
        private void TanjiConnect_FormClosing(object sender, FormClosingEventArgs e)
        {
            TanjiSettings.Save();
            if (!_main.Game.IsConnected)
            {
                Eavesdropper.Terminate();
                _main.Game.Dispose();
                Environment.Exit(0);
            }
            ResetSetup();
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

                    ReplaceRsaKeys(_flash);
                    e.Payload = _flash.ToBytes();

                    string clientPath = Path.Combine("Patched Clients", GameData.FlashClientBuild + ".swf");
                    Task.Factory.StartNew(() => _flash.Save(clientPath, true));
                }
                Eavesdropper.Terminate();
                StatusTxt.BeginAnimation("Connecting{0} | Port: " + GameData.Port, "...");
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
                    else LoadGameClient(patchedClientPath);
                }

                if (!UseCustomClient)
                {
                    Eavesdropper.Terminate();
                    StatusTxt.BeginAnimation("Connecting{0} | Port: " + GameData.Port, "...");
                }
                else if (_replaceKeys) StatusTxt.BeginAnimation("Modifying Client{0}", "...");
                else StatusTxt.BeginAnimation("Replacing Client{0}", "...");

                _main.Game.Connect(true, GameData.Host, GameData.Port);

                response = response.Replace(GameData.FlashClientBuild + "/Habbo.swf", GameData.FlashClientBuild + "/Habbo.swf?" + _numberGenerator.Next());
                e.Payload = Encoding.UTF8.GetBytes(response);
            }
        }

        private void ResetSetup()
        {
            Eavesdropper.Terminate();

            ConnectBtn.Text = "Connect";
            CustomClientTxt.Text = string.Empty;
            UseCustomClient = _replaceKeys = false;

            StatusTxt.EndAnimation("Standing By...");
        }
        private void LoadGameClient(string path)
        {
            if (InvokeRequired) { Invoke(_loadGameClient, path); return; }

            try { _flash = new ShockwaveFlash(path); }
            catch { path = string.Empty; }
            finally
            {
                UseCustomClient = (_flash != null && !_flash.IsCompressed);
                CustomClientTxt.Text = path;
            }
        }

        private void DecodeRsaKeys(string base64RsaKeys)
        {
            byte[] data = Convert.FromBase64String(base64RsaKeys);
            string mergedKeys = Encoding.UTF8.GetString(data);

            int modLength = mergedKeys[0];
            _main.Modulus = mergedKeys.Substring(1, modLength);

            mergedKeys = mergedKeys.Substring(modLength);
            _main.Exponent = int.Parse(mergedKeys.Substring(2));
        }
        private void ReplaceRsaKeys(ShockwaveFlash flash)
        {
            foreach (IFlashTag flashTag in _flash.Tags)
            {
                if (flashTag.Header.Tag != FlashTagType.DefineBinaryData) continue;

                var binaryDataTag = (DefineBinaryDataTag)flashTag;
                string binaryData = Encoding.UTF8.GetString(binaryDataTag.Data);
                if (binaryData.Contains("habbo_login_dialog"))
                {
                    string extractedRsaKeys = binaryData.GetChild("name=\"dummy_field\" caption=\"", '"');
                    DecodeRsaKeys(extractedRsaKeys);

                    string generatedRsaKeys = EncodeRsaKeys(Main.FAKE_EXPONENT, Main.FAKE_MODULUS);
                    binaryData = binaryData.Replace(extractedRsaKeys, generatedRsaKeys);
                    binaryDataTag.Data = Encoding.UTF8.GetBytes(binaryData);

                    flash.Compile();
                    break;
                }
            }
        }
        private string EncodeRsaKeys(int exponent, string modulus)
        {
            string mergedKeys = string.Format("{0}{1} {2}",
                (char)modulus.Length, modulus, exponent);

            byte[] data = Encoding.UTF8.GetBytes(mergedKeys);
            return Convert.ToBase64String(data);
        }
    }
}