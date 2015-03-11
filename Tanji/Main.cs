using System;
using System.IO;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;
using System.Threading.Tasks;

using Tanji.Dialogs;
using Tanji.Utilities;
using Tanji.Properties;
using Tanji.Applications;

using Sulakore.Protocol;
using Sulakore.Extensions;
using Sulakore.Communication;
using Sulakore.Protocol.Encryption;

namespace Tanji
{
    public partial class Main : Form
    {
        public const int FAKE_EXPONENT = 3;
        public const string FAKE_MODULUS = "86851dd364d5c5cece3c883171cc6ddc5760779b992482bd1e20dd296888df91b33b936a7b93f06d29e8870f703a216257dec7c81de0058fea4cc5116f75e6efc4e9113513e45357dc3fd43d4efab5963ef178b78bd61e81a14c603b24c8bcce0a12230b320045498edc29282ff0603bc7b7dae8fc1b05b52b2f301a9dc783b7";
        public const string FAKE_PRIVATE_EXPONENT = "59ae13e243392e89ded305764bdd9e92e4eafa67bb6dac7e1415e8c645b0950bccd26246fd0d4af37145af5fa026c0ec3a94853013eaae5ff1888360f4f9449ee023762ec195dff3f30ca0b08b8c947e3859877b5d7dced5c8715c58b53740b84e11fbc71349a27c31745fcefeeea57cff291099205e230e0c7c27e8e1c0512b";

        public const int REAL_EXPONENT = 10001;
        public const string REAL_MODULUS = "e052808c1abef69a1a62c396396b85955e2ff522f5157639fa6a19a98b54e0e4d6e44f44c4c0390fee8ccf642a22b6d46d7228b10e34ae6fffb61a35c11333780af6dd1aaafa7388fa6c65b51e8225c6b57cf5fbac30856e896229512e1f9af034895937b2cb6637eb6edf768c10189df30c10d8a3ec20488a198063599ca6ad";

        private Contractor _contractor;
        private bool _debugging, _extensionsLoaded;
        private byte[] _fakeClientKey, _fakeServerKey;
        private HKeyExchange _fakeClient, _fakeServer;

        private readonly TanjiConnect _tanjiConnect;
        private readonly Packetlogger _packetloggerF;
        private readonly Action _initiate, _reinitiate;

        private const string TITLE_FORMAT = "Tanji ~ Connected[{0}:{1}]";
        private const string SCHEDULES_FORMAT = "Schedules Active: {0}/{1}";
        private const string EXTENSIONS_FORMAT = "Extensions Active: {0}/{1}";

        private const string CorrPack = "The given packet seems to be corrupted.";
        private const string BadHeader = "The header you've specified does not qualify as an UInt16 type.";
        private const string NotInt32 = "The given value does not qualify as an Int32 type.";
        private const string NotUInt16 = "The given value does not qualify as an UInt16 type.";
        private const string InjClientCanc = "The specified data is corrupted, injection to client cancelled!";
        private const string InjServerCanc = "The specified data is corrupted, injection to server cancelled!";

        private int _exponent = REAL_EXPONENT;
        public int Exponent
        {
            get { return _exponent; }
            set
            {
                if (value != 0)
                    _exponent = value;
            }
        }

        private string _modulus = REAL_MODULUS;
        public string Modulus
        {
            get { return _modulus; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    _modulus = value;
            }
        }

        private readonly HConnection _game;
        public HConnection Game
        {
            get { return _game; }
        }

        public Main(bool debugging)
        {
            InitializeComponent();

            CheckForUpdates();
            TanjiSettings.Load();

            _game = new HConnection();
            _game.Connected += Game_Connected;
            _game.DataToClient += Game_DataToClient;
            _game.DataToServer += Game_DataToServer;

            _packetloggerF = new Packetlogger();
            _tanjiConnect = new TanjiConnect(this);

            OSAlwaysOnTopChckbx.Checked = TanjiSettings.Global.IsAlwaysOnTop;
            OSCloseOnDisconnectChckbx.Checked = TanjiSettings.Global.ShouldCloseOnDisconnect;

            _initiate = Initiate;
            _reinitiate = Reinitiate;
            _debugging = debugging;

            ISDestinationTxt.SelectedIndex = 1;
        }

        private void Game_Connected(object sender, EventArgs e)
        {
            BeginInvoke(new MethodInvoker(() => _tanjiConnect.Close()));
            InitializeContractor();

            _fakeClient = new HKeyExchange(Exponent, Modulus);
            _fakeServer = new HKeyExchange(FAKE_EXPONENT, FAKE_MODULUS, FAKE_PRIVATE_EXPONENT);

            _game.Disconnected += Game_Disconnected;
        }
        private void Game_Disconnected(object sender, EventArgs e)
        {
            _game.Disconnected -= Game_Disconnected;
            if (TanjiSettings.Global.ShouldCloseOnDisconnect)
            {
                TanjiSettings.Save();
                Environment.Exit(0);
            }
            Task.Factory.StartNew(Reinitiate);
        }
        private void Game_DataToServer(object sender, DataToEventArgs e)
        {
            try
            {
                switch (e.Step)
                {
                    case 3:
                    {
                        _fakeServerKey = _fakeServer.GetSharedKey(e.Packet.ReadString());
                        e.Replacement.Replace<string>(_fakeClient.PublicKey);
                        break;
                    }
                    case 4:
                    {
                        if (e.Packet.IsCorrupted)
                        {
                            Game.ClientEncrypt = new Rc4(_fakeClientKey);
                            Game.ClientDecrypt = new Rc4(_fakeServerKey);

                            byte[] decrypted = Game.ClientDecrypt.SafeParse(e.Packet.ToBytes());
                            e.Replacement = new HMessage(decrypted, HDestination.Server);
                        }
                        break;
                    }
                }
            }
            catch { }
            finally
            {
                if (_packetloggerF.ViewOutgoing)
                    _packetloggerF.PushToQueue(e);

                _contractor.ProcessOutgoing(e.Replacement.ToBytes());
            }
        }
        private void Game_DataToClient(object sender, DataToEventArgs e)
        {
            try
            {
                switch (e.Step)
                {
                    case 1:
                    {
                        _fakeClient.DoHandshake(e.Packet.ReadString(), e.Packet.ReadString(e.Packet.Position));
                        e.Replacement.ReplaceAt<string>(0, _fakeServer.SignedPrime);
                        e.Replacement.ReplaceAt<string>(e.Packet.Position, _fakeServer.SignedGenerator);
                        break;
                    }
                    case 2:
                    {
                        _fakeClientKey = _fakeClient.GetSharedKey(e.Packet.ReadString());
                        e.Replacement.Replace<string>(_fakeServer.PublicKey);
                        break;
                    }
                    case 3:
                    {
                        if (e.Packet.IsCorrupted)
                        {
                            Game.ServerDecrypt = new Rc4(_fakeClientKey);
                            Game.ServerEncrypt = new Rc4(_fakeServerKey);

                            byte[] decrypted = Game.ServerDecrypt.SafeParse(e.Packet.ToBytes());
                            e.Replacement = new HMessage(decrypted, HDestination.Client);
                        }
                        break;
                    }
                }
            }
            catch { }
            finally
            {
                if (_packetloggerF.ViewIncoming)
                    _packetloggerF.PushToQueue(e);

                _contractor.ProcessIncoming(e.Replacement.ToBytes());
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {
            if (!_debugging) Initiate();
            else InitializeContractor();
        }
        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            TanjiSettings.Save();
            if (!_debugging)
            {
                e.Cancel = true;
                Task.Factory.StartNew(Game.Disconnect);
            }
        }

        private void VersionTxt_Click(object sender, EventArgs e)
        {
            VersionTxt.LinkVisited = true;
            Process.Start(TanjiUpdater.RELEASE_PAGE);
        }
        private void TanjiInfoTxt_Click(object sender, EventArgs e)
        {
            TanjiInfoTxt.LinkVisited = true;
            Process.Start(TanjiUpdater.TANJI_PAGE);
        }

        #region Injection Related Methods
        #region Constructer Related Methods
        private void ICAppendIntegerBtn_Click(object sender, EventArgs e)
        {
            int value;
            int count = (int)ICCountTxt.Value;
            int.TryParse(ICValueTxt.Text, out value);

            ICConstructerLstVw.BeginUpdate();
            for (int i = 0; i < count; i++)
                ICConstructerLstVw.Append(value);
            ICConstructerLstVw.EndUpdate();
        }
        private void ICAppendStringBtn_Click(object sender, EventArgs e)
        {
            string value = ICValueTxt.Text;
            int count = (int)ICCountTxt.Value;

            ICConstructerLstVw.BeginUpdate();
            for (int i = 0; i < count; i++)
                ICConstructerLstVw.Append(value);
            ICConstructerLstVw.EndUpdate();
        }
        private void ICAppendBooleanBtn_Click(object sender, EventArgs e)
        {
            int count = (int)ICCountTxt.Value;
            bool value = (!string.IsNullOrEmpty(ICValueTxt.Text) && (ICValueTxt.Text[0] == 't' || ICValueTxt.Text[0] == '1'));

            ICConstructerLstVw.BeginUpdate();
            for (int i = 0; i < count; i++)
                ICConstructerLstVw.Append(value);
            ICConstructerLstVw.EndUpdate();
        }

        private void ICMoveUpBtn_Click(object sender, EventArgs e)
        {
            ICConstructerLstVw.MoveSelectedItemUp();
        }
        private void ICMoveDownBtn_Click(object sender, EventArgs e)
        {
            ICConstructerLstVw.MoveSelectedItemDown();
        }

        private void ICClearBtn_Click(object sender, EventArgs e)
        {
            ICConstructerLstVw.ClearItems();
            ICRemoveBtn.Enabled = ICMoveDownBtn.Enabled = ICMoveUpBtn.Enabled = false;
        }
        private void ICRemoveBtn_Click(object sender, EventArgs e)
        {
            ICConstructerLstVw.RemoveSelectedItem();
        }
        private void ICSchedulerBtn_Click(object sender, EventArgs e)
        {
            IInjectionTabs.SelectTab(ISchedulerTab);
            ISPacketTxt.Text = ICConstructerLstVw.GetString();
        }
        private void ICInjectionBtn_Click(object sender, EventArgs e)
        {
            IPacketTxt.Text = ICConstructerLstVw.GetString();
        }
        private void ICPrimitiveBtn_Click(object sender, EventArgs e)
        {
            IPacketTxt.Text = ICConstructerLstVw.GetString();
            IInjectionTabs.SelectTab(IPrimitiveTab);
        }

        private void ICCopyPacketBtn_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(ICConstructerLstVw.GetString());
        }

        private void ICValueTxt_TextChanged(object sender, EventArgs e)
        {
            if (ICConstructerLstVw.SelectedItems.Count < 1) return;
            string typeName = ICConstructerLstVw.SelectedItems[0].SubItems[0].Text;

            object chunk = null;
            switch (typeName)
            {
                case "Integer":
                {
                    int value = 0;
                    chunk = int.TryParse(ICValueTxt.Text, out value) ? value : 0;
                    break;
                }
                case "String": chunk = ICValueTxt.Text; break;
                case "Boolean": chunk = (!string.IsNullOrEmpty(ICValueTxt.Text) && (ICValueTxt.Text[0] == 't' || ICValueTxt.Text[0] == '1')); break;
                default: return;
            }
            ICConstructerLstVw.ReplaceItem(chunk);
        }
        private void ICHeaderTxt_TextChanged(object sender, EventArgs e)
        {
            ushort header = 0;
            if (ushort.TryParse(ICHeaderTxt.Text, out header))
                ICConstructerLstVw.Header = header;
        }
        private void ICConstructerLstVw_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (ICConstructerLstVw.SelectedItems.Count < 1) return;

            object chunk = null;
            ListViewItem item = ICConstructerLstVw.SelectedItems[0];
            switch (item.SubItems[0].Text)
            {
                case "Integer": chunk = ""; break;
                case "String": chunk = false; break;
                case "Boolean": chunk = 0; break;
                default: return;
            }
            ICValueTxt.TextChanged -= ICValueTxt_TextChanged;
            ICValueTxt.Text = chunk.ToString();
            ICValueTxt.TextChanged += ICValueTxt_TextChanged;

            ICConstructerLstVw.ReplaceItem(chunk);
            ICValueTxt.Focus();
        }
        private void ICConstructerLstVw_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            ICRemoveBtn.Enabled = e.IsSelected;
            ICMoveUpBtn.Enabled = e.IsSelected && e.ItemIndex != 0;
            ICMoveDownBtn.Enabled = e.IsSelected && e.ItemIndex != ICConstructerLstVw.Items.Count - 1;
            ICValueTxt.Text = e.IsSelected ? e.Item.SubItems[1].Text : string.Empty;

            const string ChunkCountFormat = "Chunk Count: {0}";
            ICChunkCountLbl.Text = string.Format(ChunkCountFormat, ICConstructerLstVw.ChunksWritten.Count);
        }
        #endregion

        #region Scheduler Related Methods
        private void UpdateSchedulerUI(bool itemSelected)
        {
            int itemCount = ISSchedulesLstVw.Items.Count;
            bool containsItems = itemCount > 0;

            SchedulesTxt.Text = string.Format(SCHEDULES_FORMAT,
                ISSchedulesLstVw.Running, itemCount);

            ISRemoveBtn.Enabled = itemSelected;
            ISClearBtn.Enabled = containsItems;
            ISStopAllBtn.Enabled = containsItems;
            ISStartAllBtn.Enabled = containsItems;
        }

        private void ISStopAllBtn_Click(object sender, EventArgs e)
        {
            ISSchedulesLstVw.StopAllSchedules();
            UpdateSchedulerUI(ISSchedulesLstVw.SelectedItems.Count > 0);
        }
        private void ISStartAllBtn_Click(object sender, EventArgs e)
        {
            ISSchedulesLstVw.StartAllSchedules();
            UpdateSchedulerUI(ISSchedulesLstVw.SelectedItems.Count > 0);
        }

        private void ISClearBtn_Click(object sender, EventArgs e)
        {
            ISSchedulesLstVw.ClearItems();
            UpdateSchedulerUI(false);
        }
        private void ISRemoveBtn_Click(object sender, EventArgs e)
        {
            ISSchedulesLstVw.RemoveSelectedItem();
            UpdateSchedulerUI(ISSchedulesLstVw.SelectedItems.Count > 0);
        }
        private void ISCreateBtn_Click(object sender, EventArgs e)
        {
            var packet = new HMessage(ISPacketTxt.Text, (HDestination)ISDestinationTxt.SelectedIndex + 1);
            ISSchedulesLstVw.AddSchedule(packet, (int)ISBurstTxt.Value, (int)ISIntervalTxt.Value, ISDescriptionTxt.Text);
            UpdateSchedulerUI(true);
        }

        private void ISSchedulesLstVw_ScheduleTriggered(object sender, HScheduleTriggeredEventArgs e)
        {
            if (!e.Packet.IsCorrupted) SendTo(e.Packet);
            else e.Cancel = true;
        }
        private void ISSchedulesLstVw_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            UpdateSchedulerUI(e.IsSelected);
        }

        private void ISAutoStartChckbx_CheckedChanged(object sender, EventArgs e)
        {
            ISSchedulesLstVw.AutoStart = ISAutoStartChckbx.Checked;
        }
        #endregion

        #region Primitive Related Methods
        private void IPPacketTxt_TextChanged(object sender, EventArgs e)
        {
            if (IPPacketTxt.TextLength < 1) IPacketTxt.Text = string.Empty;
            else if (IPPacketTxt.TextLength < 2) return;

            HMessage packet = null;
            bool isCorrupted = false;
            try
            {
                byte[] data = HMessage.ToBytes(IPPacketTxt.Text);
                if (data.Length > 1)
                {
                    packet = new HMessage(data);
                    isCorrupted = (data.Length < 2 || packet.IsCorrupted);
                }
                else isCorrupted = true;
            }
            catch { isCorrupted = true; }
            finally
            {
                IPacketTxt.Text = isCorrupted ? IPPacketTxt.Text : packet.ToString();

                const string PacketInfoFormat = "Header: {0} | Length: {1} | Corrupted:";
                IPPacketInfoLbl.Text = string.Format(PacketInfoFormat, (isCorrupted ? 0 : packet.Header), (isCorrupted ? IPPacketTxt.TextLength : packet.Length));

                IPIsCorruptedLbl.Text = isCorrupted.ToString();
                IPIsCorruptedLbl.ForeColor = isCorrupted ? Color.Firebrick : SystemColors.HotTrack;
                IPIsCorruptedLbl.Location = new Point((IPPacketInfoLbl.Location.X + IPPacketInfoLbl.Width) - 5, IPIsCorruptedLbl.Location.Y);
            }
        }
        private void IInjectionTabs_Selected(object sender, TabControlEventArgs e)
        {
            if (IPacketTxt.ReadOnly = (e.TabPage == IPrimitiveTab))
                IPPacketTxt.Text = IPacketTxt.Text;
        }
        #endregion

        private void SendToServerBtn_Click(object sender, EventArgs e)
        {
            SendTo(new HMessage(IPacketTxt.Text, HDestination.Server));
        }
        private void SendToClientBtn_Click(object sender, EventArgs e)
        {
            SendTo(new HMessage(IPacketTxt.Text, HDestination.Client));
        }
        #endregion

        #region Encode/Decoder Related Methods
        private void ModernCypherIntegerBtn_Click(object sender, EventArgs e)
        {
            int value;
            if (int.TryParse(ModernIntegerInputTxt.Text, out value))
                ModernIntegerOutputTxt.Text = HMessage.ToString(BigEndian.CypherInt(value));
            else MessageBox.Show(NotInt32, "Tanji ~ Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void ModernDecypherIntegerBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(ModernIntegerOutputTxt.Text))
                ModernIntegerInputTxt.Text = BigEndian.DecypherInt(HMessage.ToBytes(ModernIntegerOutputTxt.Text)).ToString();
        }

        private void ModernCypherShortBtn_Click(object sender, EventArgs e)
        {
            ushort value;
            if (ushort.TryParse(ModernShortInputTxt.Text, out value))
                ModernShortOutputTxt.Text = HMessage.ToString(BigEndian.CypherShort(value));
            else MessageBox.Show(NotUInt16, "Tanji ~ Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void ModernDecypherShortBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(ModernShortOutputTxt.Text))
                ModernShortInputTxt.Text = BigEndian.DecypherShort(HMessage.ToBytes(ModernShortOutputTxt.Text)).ToString();
        }
        #endregion

        #region Extension Related Methods
        private void UpdateExtensionInfo(bool extensionSelected)
        {
            if (!extensionSelected) EExtensionLogoPctbx.Image = Resources.Tanji;
            else
            {
                ExtensionBase extension = ETanjiExtensionViewer.GetItemExtension();
                if (extension == null || extension.UIContext == null) return;

                EExtensionLogoPctbx.Image = extension.Logo ?? Resources.Tanji;

                if (EExtensionLogoPctbx.Size.Width < 64 || EExtensionLogoPctbx.Image.Size.Height < 64)
                    EExtensionLogoPctbx.SizeMode = PictureBoxSizeMode.CenterImage;
                else EExtensionLogoPctbx.SizeMode = PictureBoxSizeMode.Zoom;

                extension.UIContext.BringToFront();
            }
        }
        private void Contractor_CommandReceived(object sender, InvokedEventArgs e)
        {
            try
            {
                switch (e.Command)
                {
                    case "Construct":
                    {
                        ICClearBtn_Click(this, e);
                        ICHeaderTxt.Text = e.Args[0].ToString();
                        if (e.Args.Length < 2) return;

                        ICConstructerLstVw.BeginUpdate();
                        for (int i = 1; i < e.Args.Length; i++)
                            ICConstructerLstVw.Append(e.Args[i]);
                        ICConstructerLstVw.EndUpdate();
                        break;
                    }
                }
                e.Result = true;
            }
            catch { e.Result = false; }
        }

        // TODO: Update the extension info.. properly, next time.
        private void EOpenExtensionBtn_Click(object sender, EventArgs e)
        {
            ETanjiExtensionViewer.InitializeItemExtension();

            const string ExtensionFormat = "Extensions Active: {0}/{1}";
            ExtensionsActiveTxt.Text = string.Format(ExtensionFormat,
                _contractor.ExtensionsRunning.Count, _contractor.Extensions.Count);
        }
        private void EInstallExtensionBtn_Click(object sender, EventArgs e)
        {
            ChooseExtensionDlg.FileName = ChooseExtensionDlg.SafeFileName;
            if (ChooseExtensionDlg.ShowDialog() != DialogResult.OK) return;

            LoadSingleExtension(ChooseExtensionDlg.FileName);

            const string ExtensionFormat = "Extensions Active: {0}/{1}";
            ExtensionsActiveTxt.Text = string.Format(ExtensionFormat,
                _contractor.ExtensionsRunning.Count, _contractor.Extensions.Count);
        }
        private void EUninstallExtensionBtn_Click(object sender, EventArgs e)
        {
            ETanjiExtensionViewer.RemoveSelectedItem();

            const string ExtensionFormat = "Extensions Active: {0}/{1}";
            ExtensionsActiveTxt.Text = string.Format(ExtensionFormat,
                _contractor.ExtensionsRunning.Count, _contractor.Extensions.Count);

            if (_contractor.Extensions.Count < 1)
                EOpenBtn.Enabled = EUninstallBtn.Enabled = false;
        }

        private void ExtensionViewer_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Effect != DragDropEffects.Copy) return;

            string path = ((string[])(e.Data.GetData(DataFormats.FileDrop)))[0];
            LoadSingleExtension(path);
        }
        private void ExtensionViewer_DragEnter(object sender, DragEventArgs e)
        {
            if (((string[])(e.Data.GetData(DataFormats.FileDrop)))[0].EndsWith(".dll"))
                e.Effect = DragDropEffects.Copy;
        }

        private void ETanjiExtensionViewer_ItemActivate(object sender, EventArgs e)
        {
            ETanjiExtensionViewer.InitializeItemExtension();
            UpdateExtensionInfo(true);
        }
        private void ETanjiExtensionViewer_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (EOpenBtn.Enabled != e.IsSelected)
                EOpenBtn.Enabled = EUninstallBtn.Enabled = e.IsSelected;

            UpdateExtensionInfo(e.IsSelected);
        }
        #endregion

        #region Option Related Methods
        private void OSAlwaysOnTopChckbx_CheckedChanged(object sender, EventArgs e)
        {
            TopMost = OSAlwaysOnTopChckbx.Checked;
        }
        private void OSCloseOnDisconnectChckbx_CheckedChanged(object sender, EventArgs e)
        {
            TanjiSettings.Global.ShouldCloseOnDisconnect = OSCloseOnDisconnectChckbx.Checked;
        }
        #endregion

        private void Initiate()
        {
            if (InvokeRequired) { Invoke(_initiate); return; }

            _tanjiConnect.ShowDialog();

            Show();
            BringToFront();

            _packetloggerF.Show();
            _packetloggerF.BringToFront();

            Text = string.Format(TITLE_FORMAT, Game.Host, Game.Port);
        }
        private void Reinitiate()
        {
            if (InvokeRequired) { Invoke(_reinitiate); return; }

            if (_contractor.Extensions.Count > 0)
            {
                var extensions = new IExtension[_contractor.Extensions.Count];
                _contractor.Extensions.CopyTo(extensions, 0);

                foreach (ExtensionBase extension in extensions)
                    _contractor.Dispose(extension);
            }

            if (_fakeClient != null)
                _fakeClient.Dispose();

            if (_fakeServer != null)
                _fakeServer.Dispose();

            Hide();
            _packetloggerF.Halt();
            _packetloggerF.Hide();

            Task.Factory.StartNew(Initiate);
        }
        private void CheckForUpdates()
        {
            using (var updater = new TanjiUpdater())
            {
                VersionTxt.Text = "v" + TanjiUpdater.LocalVersion.ToString();

                if (updater.UpdateFound())
                    updater.ShowDialog();
            }
        }
        private void InitializeContractor()
        {
            _contractor = new Contractor(Game, _tanjiConnect.GameData);
            _contractor.Invoked += Contractor_CommandReceived;

            if (!_extensionsLoaded && Directory.Exists("Extensions"))
            {
                _extensionsLoaded = true;
                var extensionDirectory = new DirectoryInfo("Extensions");
                FileInfo[] extensionFiles = extensionDirectory.GetFiles();
                foreach (FileInfo extensionFile in extensionFiles)
                {
                    if (extensionFile.Extension != ".dll") continue;
                    try { LoadSingleExtension(extensionFile.FullName); }
                    catch { extensionFile.Delete(); }
                }
            }
        }
        private void SendTo(HMessage packet)
        {
            Func<byte[], int> sendToX = null;
            switch (packet.Destination)
            {
                case HDestination.Client: sendToX = Game.SendToClient; break;
                case HDestination.Server: sendToX = Game.SendToServer; break;
                case HDestination.Unknown: throw new Exception("Unsupported HDestination type provided: HDestination.Unknown");
            }

            if (!packet.IsCorrupted) sendToX(packet.ToBytes());
            else MessageBox.Show(InjClientCanc, "Tanji ~ Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void LoadSingleExtension(string path)
        {
            ETanjiExtensionViewer.Install(_contractor.Install(path));

            const string ExtensionFormat = "Extensions Active: {0}/{1}";
            ExtensionsActiveTxt.Text = string.Format(ExtensionFormat,
                _contractor.ExtensionsRunning.Count, _contractor.Extensions.Count);
        }
    }
}