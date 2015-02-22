using System;
using System.IO;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Collections.Generic;

using Tanji.Dialogs;
using Tanji.Properties;
using Tanji.Applications;

using Sulakore;
using Sulakore.Protocol;
using Sulakore.Extensions;
using Sulakore.Communication;
using Sulakore.Protocol.Encryption;

namespace Tanji
{
    public partial class Main : Form
    {
        #region Private Fields
        private int _clientStepShift;
        private Contractor _contractor;
        private bool _debugging, _extensionsLoaded;
        private byte[] _fakeClientKey, _fakeServerKey;
        private HKeyExchange _fakeClient, _fakeServer;

        private readonly TanjiConnect _tanjiConnect;
        private readonly Packetlogger _packetloggerF;
        private readonly Action _initiate, _reinitiate;

        private const string ScheduleFormat = "Schedules Active: {0}/{1}";
        private const string TanjiTitleFormat = "Tanji ~ Connected[{0}:{1}]";
        private const string CorrPack = "The given packet seems to be corrupted.";
        private const string BadHeader = "The header you've specified does not qualify as an UInt16 type.";
        private const string NotInt32 = "The given value does not qualify as an Int32 type.";
        private const string NotUInt16 = "The given value does not qualify as an UInt16 type.";
        private const string InjClientCanc = "The specified data is corrupted, injection to client cancelled!";
        private const string InjServerCanc = "The specified data is corrupted, injection to server cancelled!";
        #endregion

        #region Public Properties/Fields
        public IList<string[]> RsaKeys;

        public bool CloseOnDC { get; set; }

        public const string TanjiAlert = "Tanji ~ Alert!";
        public const string TanjiError = "Tanji ~ Error!";
        public const string TanjiWarning = "Tanji ~ Warning!";

        public static HConnection Game { get; set; }
        public static int RealExponent { get; set; }
        public static string RealModulus { get; set; }
        #endregion

        #region Constructor(s)
        public Main(bool debugging)
        {
            InitializeComponent();

            OSAlwaysOnTopChckbx.Checked = Settings.Default.IsOnTop;
            OSScreenEdgeSnappingChckbx.Checked = Settings.Default.EdgeSnap;
            OSCloseOnDisconnectChckbx.Checked = Settings.Default.CloseOnDC;
            OSTransparencyChckbx.Checked = Settings.Default.OpacEnabled;
            OSDeactivatedChckbx.Checked = Settings.Default.OnlyOnDeac;
            OSTransparencyTbar.Value = Settings.Default.OpacValue;

            using (var updater = new TanjiUpdater())
            {
                if (updater.UpdateFound())
                {
                    updater.ShowDialog();
                    VersionTxt.Text = "Update Found!";
                    VersionTxt.IsLink = true;
                }
                else VersionTxt.Text = "v" + Application.ProductVersion;
            }

            #region Populate Keys
            RealExponent = 10001;
            RealModulus = "e052808c1abef69a1a62c396396b85955e2ff522f5157639fa6a19a98b54e0e4d6e44f44c4c0390fee8ccf642a22b6d46d7228b10e34ae6fffb61a35c11333780af6dd1aaafa7388fa6c65b51e8225c6b57cf5fbac30856e896229512e1f9af034895937b2cb6637eb6edf768c10189df30c10d8a3ec20488a198063599ca6ad";

            RsaKeys = new List<string[]>();
            RsaKeys.Add(new[]
            {
                "3",
                "86851dd364d5c5cece3c883171cc6ddc5760779b992482bd1e20dd296888df91b33b936a7b93f06d29e8870f703a216257dec7c81de0058fea4cc5116f75e6efc4e9113513e45357dc3fd43d4efab5963ef178b78bd61e81a14c603b24c8bcce0a12230b320045498edc29282ff0603bc7b7dae8fc1b05b52b2f301a9dc783b7",
                "59ae13e243392e89ded305764bdd9e92e4eafa67bb6dac7e1415e8c645b0950bccd26246fd0d4af37145af5fa026c0ec3a94853013eaae5ff1888360f4f9449ee023762ec195dff3f30ca0b08b8c947e3859877b5d7dced5c8715c58b53740b84e11fbc71349a27c31745fcefeeea57cff291099205e230e0c7c27e8e1c0512b"
            });
            RsaKeys.Add(new[]
            {
                "10001",
                "a55bb171aefecc9844b44970eedb4e94e74373a775642b0ea827326eeea039969385c59bc48b3a3fac4455768e2248f8d16ad244481c2c47e0f0c17c7643408ef2dc9205825852bc7f050d3681670bf9f6ebe5cdad4cded26b031ec45f1e36f1ba0aa7e1dda23682132aeaad4f05fec723dc589c30a17dcca8e4e839de3001ff",
                "854ab0728f395cfab10712dc31ee1e1df17d71d0ded3ebd158c29fe8c3f9ebf1f0e0b835a3ed06fb2485c0ce5c2c4ede231114856e0b27b6991ff917b6cce75007c93a94846890df86cf51abc555eb94a7f6ad62bc1f4f232579abe62a0f4b464b4354a956919a8437b684ca8e2c229b3d5c48d7d9869d712a78b7c8339ab001",
            });
            #endregion

            _packetloggerF = new Packetlogger();
            _tanjiConnect = new TanjiConnect(this);

            _initiate = Initiate;
            _reinitiate = Reinitiate;
            _debugging = debugging;

            ISDirectionTxt.SelectedIndex = 1;
            EPriorityTxt.SelectedIndex = 0;
        }
        #endregion

        #region User Interface Event Listeners
        private void Main_Load(object sender, EventArgs e)
        {
            if (!_debugging)
                Initiate();
            else InitializeContractor();
        }
        private void Main_Activated(object sender, EventArgs e)
        {
            if (OSTransparencyChckbx.Checked)
                Opacity = ((!OSDeactivatedChckbx.Checked ? OSTransparencyTbar.Value : 100) * 0.01);
        }
        private void Main_Deactivate(object sender, EventArgs e)
        {
            if (OSTransparencyChckbx.Checked && OSDeactivatedChckbx.Checked)
                Opacity = (OSTransparencyTbar.Value * 0.01);
        }
        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveSettings();
            if (!_debugging)
            {
                e.Cancel = true;
                Task.Factory.StartNew(Game.Disconnect);
            }
        }

        private void VersionTxt_Click(object sender, EventArgs e)
        {
            if (!VersionTxt.IsLink) return;

            VersionTxt.LinkVisited = true;
            const string TanjiThread = "http://Darkbox.nl/showthread.php?tid=42";
            Process.Start(TanjiThread);
        }

        #region Injection Related Methods
        #region Constructer Related Methods
        private void ICAppendIntegerBtn_Click(object sender, EventArgs e)
        {
            int value;
            int count = (int)ICCountTxt.Value;
            if (int.TryParse(ICValueTxt.Text, out value) || string.IsNullOrWhiteSpace(ICValueTxt.Text))
            {
                ICTanjiConstructer.BeginUpdate();
                for (int i = 0; i < count; i++)
                    ICTanjiConstructer.AppendChunk(value);
                ICTanjiConstructer.EndUpdate();
            }
            else MessageBox.Show(NotInt32, TanjiError, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void ICAppendStringBtn_Click(object sender, EventArgs e)
        {
            string value = ICValueTxt.Text;
            int count = (int)ICCountTxt.Value;

            ICTanjiConstructer.BeginUpdate();
            for (int i = 0; i < count; i++)
                ICTanjiConstructer.AppendChunk(value);
            ICTanjiConstructer.EndUpdate();
        }
        private void ICAppendBooleanBtn_Click(object sender, EventArgs e)
        {
            int count = (int)ICCountTxt.Value;
            bool value = (!string.IsNullOrEmpty(ICValueTxt.Text) && (ICValueTxt.Text[0] == 't' || ICValueTxt.Text[0] == '1'));

            ICTanjiConstructer.BeginUpdate();
            for (int i = 0; i < count; i++)
                ICTanjiConstructer.AppendChunk(value);
            ICTanjiConstructer.EndUpdate();
        }

        private void ICMoveUpBtn_Click(object sender, EventArgs e)
        {
            ICTanjiConstructer.MoveSelectedUp();
        }
        private void ICMoveDownBtn_Click(object sender, EventArgs e)
        {
            ICTanjiConstructer.MoveSelectedDown();
        }

        private void ICClearBtn_Click(object sender, EventArgs e)
        {
            ICTanjiConstructer.ClearChunks();
            ICEditBtn.Enabled = ICRemoveBtn.Enabled = ICMoveDownBtn.Enabled = ICMoveUpBtn.Enabled = false;
        }
        private void ICRemoveBtn_Click(object sender, EventArgs e)
        {
            ICTanjiConstructer.RemoveSelected();
        }
        private void ICEditBtn_Click(object sender, EventArgs e)
        {
            var tanjiEditF = new TanjiConstructerEdit(ICTanjiConstructer);
            tanjiEditF.ShowDialog();
        }
        private void ICTransferBtn_Click(object sender, EventArgs e)
        {
            HMessage packet = GetConstructerPacket();
            if (packet != null) IPacketTxt.Text = packet.ToString();
        }
        private void ICSchedulerBtn_Click(object sender, EventArgs e)
        {
            IInjectionTabs.SelectTab(ISchedulerTab);

            HMessage packet = GetConstructerPacket();
            if (packet != null) ISPacketTxt.Text = packet.ToString();
        }

        private void ICCopyPacketBtn_Click(object sender, EventArgs e)
        {
            HMessage packet = GetConstructerPacket();
            if (packet != null) Clipboard.SetText(packet.ToString());
        }
        private void ICSendToServerBtn_Click(object sender, EventArgs e)
        {
            HMessage packet = GetConstructerPacket();
            if (packet == null) return;
            AttemptSendToServer(packet);
        }
        private void ICSendToClientBtn_Click(object sender, EventArgs e)
        {
            HMessage packet = GetConstructerPacket();
            if (packet == null) return;
            AttemptSendToClient(packet);
        }

        private void ICTanjiConstructer_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (ICTanjiConstructer.SelectedItems.Count == 1)
                ICEditBtn_Click(sender, e);
        }
        private void ICTanjiConstructer_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (e.IsSelected)
            {
                ICEditBtn.Enabled = ICRemoveBtn.Enabled = true;
                if (ICTanjiConstructer.Items.Count > 1)
                {
                    ICMoveUpBtn.Enabled = e.ItemIndex != 0;
                    ICMoveDownBtn.Enabled = e.ItemIndex != ICTanjiConstructer.Items.Count - 1;
                }
            }
            else ICEditBtn.Enabled = ICRemoveBtn.Enabled = ICMoveUpBtn.Enabled = ICMoveDownBtn.Enabled = false;
        }
        #endregion

        #region Scheduler Related Methods
        private void ISStopAllBtn_Click(object sender, EventArgs e)
        {
            ISTanjiScheduler.StopAll();
            SchedulesTxt.Text = string.Format(ScheduleFormat, ISTanjiScheduler.SchedulesRunning, ISTanjiScheduler.Items.Count);
        }
        private void ISStartAllBtn_Click(object sender, EventArgs e)
        {
            ISTanjiScheduler.StartAll();
            SchedulesTxt.Text = string.Format(ScheduleFormat, ISTanjiScheduler.SchedulesRunning, ISTanjiScheduler.Items.Count);
        }
        private void ISRemoveBtn_Click(object sender, EventArgs e)
        {
            ISTanjiScheduler.RemoveSelected();
            ISStopAllBtn.Enabled = (ISTanjiScheduler.Items.Count > 0);
            SchedulesTxt.Text = string.Format(ScheduleFormat, ISTanjiScheduler.SchedulesRunning, ISTanjiScheduler.Items.Count);
        }
        private void ISEditBtn_Click(object sender, EventArgs e)
        {
            var tanjiEditF = new TanjiSchedulerEdit(ISTanjiScheduler);
            tanjiEditF.ShowDialog();
        }
        private void ISCreateBtn_Click(object sender, EventArgs e)
        {
            var packet = GetSchedulerPacket();
            if (packet == null) return;


            ISStopAllBtn.Enabled = true;
            ISTanjiScheduler.AddSchedule(new HSchedule(packet, (int)ISIntervalTxt.Value, (int)ISBurstTxt.Value), ISAutoStartChckbx.Checked, ISDescriptionTxt.Text);

            SchedulesTxt.Text = string.Format(ScheduleFormat, ISTanjiScheduler.SchedulesRunning, ISTanjiScheduler.Items.Count);
        }

        private void ISTanjiScheduler_ItemActivate(object sender, EventArgs e)
        {
            if (ISTanjiScheduler.SelectedItems.Count == 1)
            {
                ISTanjiScheduler.ToggleSelected();
                SchedulesTxt.Text = string.Format(ScheduleFormat, ISTanjiScheduler.SchedulesRunning, ISTanjiScheduler.Items.Count);
            }
        }
        private void ISTanjiScheduler_ScheduleTriggered(object sender, HScheduleTriggeredEventArgs e)
        {
            if (e.Packet.IsCorrupted) return;

            if (e.Packet.Destination == HDestination.Client)
                AttemptSendToClient(e.Packet);
            else if (e.Packet.Destination == HDestination.Server)
                AttemptSendToServer(e.Packet);
        }
        private void ISTanjiScheduler_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (ISEditBtn.Enabled != e.IsSelected)
                ISRemoveBtn.Enabled = ISStartAllBtn.Enabled = ISEditBtn.Enabled = e.IsSelected;
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
            if (string.IsNullOrWhiteSpace(IPacketTxt.Text)) return;
            AttemptSendToServer(new HMessage(IPacketTxt.Text));
        }
        private void SendToClientBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(IPacketTxt.Text)) return;
            AttemptSendToClient(new HMessage(IPacketTxt.Text));
        }
        #endregion

        #region Encode/Decoder Related Methods
        private void ModernCypherIntegerBtn_Click(object sender, EventArgs e)
        {
            int value;
            if (int.TryParse(ModernIntegerInputTxt.Text, out value))
                ModernIntegerOutputTxt.Text = HMessage.ToString(BigEndian.CypherInt(value));
            else MessageBox.Show(NotInt32, TanjiError, MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            else MessageBox.Show(NotUInt16, TanjiError, MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            if (extensionSelected)
            {
                ExtensionBase extension = ETanjiExtensionViewer.GetSelected();

                if (extension.UIContext != null)
                {
                    EExtensionLogoPctbx.Image = extension.Logo ?? Resources.Tanji;

                    if (EExtensionLogoPctbx.Size.Width < 64 || EExtensionLogoPctbx.Image.Size.Height < 64)
                        EExtensionLogoPctbx.SizeMode = PictureBoxSizeMode.CenterImage;
                    else EExtensionLogoPctbx.SizeMode = PictureBoxSizeMode.Zoom;

                    extension.UIContext.BringToFront();
                }
            }
            else
            {
                EExtensionLogoPctbx.Image = Resources.Tanji;
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

                        ICTanjiConstructer.BeginUpdate();
                        for (int i = 1; i < e.Args.Length; i++)
                            ICTanjiConstructer.AppendChunk(e.Args[i]);
                        ICTanjiConstructer.EndUpdate();
                        break;
                    }
                }
                e.Result = true;
            }
            catch { e.Result = false; }
        }

        private void EOpenBtn_Click(object sender, EventArgs e)
        {
            ETanjiExtensionViewer.OpenSelected();
        }
        private void EUninstallBtn_Click(object sender, EventArgs e)
        {
            ETanjiExtensionViewer.UninstallSelected();

            const string ExtensionFormat = "Extensions Installed: {0}";
            ExtensionsActiveTxt.Text = string.Format(ExtensionFormat,
                _contractor.Extensions.Count);

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

        private void EInstallExtensionBtn_Click(object sender, EventArgs e)
        {
            ChooseExtensionDlg.FileName = ChooseExtensionDlg.SafeFileName;
            if (ChooseExtensionDlg.ShowDialog() != DialogResult.OK) return;

            LoadSingleExtension(ChooseExtensionDlg.FileName);
        }
        private void ETanjiExtensionViewer_ItemActivate(object sender, EventArgs e)
        {
            ETanjiExtensionViewer.OpenSelected();
            UpdateExtensionInfo(true);
        }
        private void ETanjiExtensionViewer_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            EOpenBtn.Enabled = EUninstallBtn.Enabled = e.IsSelected;
            UpdateExtensionInfo(e.IsSelected);
        }
        #endregion

        #region Option Related Methods
        private void OSTransparencyTbar_ValueChanged(object sender, EventArgs e)
        {
            if (!OSDeactivatedChckbx.Checked)
                Opacity = (OSTransparencyTbar.Value * 0.01);
        }
        private void OSAlwaysOnTopChckbx_CheckedChanged(object sender, EventArgs e)
        {
            TopMost = OSAlwaysOnTopChckbx.Checked;
        }
        private void OSDeactivatedChckbx_CheckedChanged(object sender, EventArgs e)
        {
            if (OSDeactivatedChckbx.Checked) Opacity = 1;
            else Opacity = (OSTransparencyTbar.Value * 0.01);
        }
        private void OSTransparencyChckbx_CheckedChanged(object sender, EventArgs e)
        {
            bool isEnabled = OSTransparencyChckbx.Checked;
            OSTransparencyTbar.Enabled = OSDeactivatedChckbx.Enabled = isEnabled;

            Opacity = ((!isEnabled || OSDeactivatedChckbx.Checked ? 100 : OSTransparencyTbar.Value) * 0.01);
        }
        private void OSCloseOnDisconnectChckbx_CheckedChanged(object sender, EventArgs e)
        {
            CloseOnDC = OSCloseOnDisconnectChckbx.Checked;
        }
        private void OSScreenEdgeSnappingChckbx_CheckedChanged(object sender, EventArgs e)
        {
            if (OSScreenEdgeSnappingChckbx.Checked)
                OnResizeEnd(EventArgs.Empty);
        }
        #endregion
        #endregion

        #region Game Connection Event Listeners
        private void Game_DataToServer(object sender, DataToEventArgs e)
        {
            if (_packetloggerF.ViewOutgoing)
                _packetloggerF.PushToQueue(e);

            _contractor.ProcessOutgoing(e.Replacement.ToBytes());
        }
        private void Game_DataToClient(object sender, DataToEventArgs e)
        {
            if (_packetloggerF.ViewIncoming)
                _packetloggerF.PushToQueue(e);

            _contractor.ProcessIncoming(e.Replacement.ToBytes());
        }

        private void Handshake_ToServer(object sender, DataToEventArgs e)
        {
            try
            {
                switch (e.Step)
                {
                    case 3:
                    {
                        _fakeServerKey = _fakeServer.GetSharedKey(e.Packet.ReadString());
                        e.Replacement = new HMessage(e.Packet.Header, HDestination.Server, _fakeClient.PublicKey);
                        break;
                    }
                    case 4:
                    {
                        if (e.Packet.IsCorrupted)
                        {
                            Game.ClientEncrypt = new Rc4(_fakeClientKey);
                            Game.ClientDecrypt = new Rc4(_fakeServerKey);
                            Game.ClientDecrypt.Parse(e.Packet.ToBytes());
                            e.Replacement = new HMessage(e.Packet.ToBytes(), HDestination.Server);
                        }
                        break;
                    }
                }
            }
            catch { HandshakeFinished(); }
            Game_DataToServer(sender, e);
        }
        private void Handshake_ToClient(object sender, DataToEventArgs e)
        {
            try
            {
                switch (e.Step - _clientStepShift)
                {
                    case 1:
                    {
                        try
                        {
                            _fakeClient.DoHandshake(e.Packet.ReadString(), e.Packet.ReadString());
                        }
                        catch
                        {
                            if (!AttemptHandshake(e.Packet))
                            {
                                HandshakeFinished();
                                break;
                            }
                        }

                        e.Replacement = new HMessage(e.Packet.Header, HDestination.Client, _fakeServer.SignedPrime, _fakeServer.SignedGenerator);
                        break;
                    }
                    case 2:
                    {
                        if (e.Packet.Length == 2) { _clientStepShift++; break; }
                        _fakeClientKey = _fakeClient.GetSharedKey(e.Packet.ReadString());

                        e.Replacement = new HMessage(e.Packet.Header, HDestination.Client, _fakeServer.PublicKey, true);
                        break;
                    }
                    case 3:
                    {
                        if (e.Packet.IsCorrupted)
                        {
                            Game.ServerDecrypt = new Rc4(_fakeClientKey);
                            Game.ServerEncrypt = new Rc4(_fakeServerKey);
                            Game.ServerDecrypt.Parse(e.Packet.ToBytes());
                            e.Replacement = new HMessage(e.Packet.ToBytes(), HDestination.Client);
                        }
                        break;
                    }
                    default: HandshakeFinished(); break;
                }
            }
            catch { HandshakeFinished(); }
            Game_DataToClient(sender, e);
        }

        private void Game_Disconnected(object sender, DisconnectedEventArgs e)
        {
            if (CloseOnDC)
            {
                SaveSettings();
                Environment.Exit(0);
            }

            Game.LockEvents = Game.CaptureEvents = false;
            e.UnsubscribeFromEvents = true;
            Task.Factory.StartNew(Reinitiate);
        }
        #endregion

        #region Overrided Methods
        protected override void OnResizeEnd(EventArgs e)
        {
            base.OnResize(e);
            if (!OSScreenEdgeSnappingChckbx.Checked) return;

            var screen = Screen.FromPoint(Location);
            if (DoSnap(Left, screen.WorkingArea.Left)) Left = screen.WorkingArea.Left;
            if (DoSnap(Top, screen.WorkingArea.Top)) Top = screen.WorkingArea.Top;
            if (DoSnap(screen.WorkingArea.Right, Right)) Left = screen.WorkingArea.Right - Width;
            if (DoSnap(screen.WorkingArea.Bottom, Bottom)) Top = screen.WorkingArea.Bottom - Height;
        }
        #endregion

        #region Private Methods
        private void Initiate()
        {
            if (InvokeRequired) { Invoke(_initiate); return; }

            _tanjiConnect.ShowDialog();

            BringToFront();
            Show();

            _packetloggerF.Show();
            _packetloggerF.BringToFront();

            Text = string.Format(TanjiTitleFormat, Game.Host, Game.Port);
        }

        private void Reinitiate()
        {
            if (InvokeRequired) { Invoke(_reinitiate); return; }

            if (_contractor.Extensions.Count > 0)
            {
                var extensions = new ExtensionBase[_contractor.Extensions.Count];
                _contractor.Extensions.CopyTo(extensions, 0);

                foreach (ExtensionBase extension in extensions)
                    _contractor.Dispose(extension);
            }

            _clientStepShift = 0;

            if (_fakeClient != null)
                _fakeClient.Flush();

            if (_fakeServer != null)
                _fakeServer.Flush();

            _packetloggerF.Halt();

            Hide();
            _packetloggerF.Hide();

            Task.Factory.StartNew(Initiate);
        }
        private void SaveSettings()
        {
            Settings.Default.IsOnTop = OSAlwaysOnTopChckbx.Checked;
            Settings.Default.EdgeSnap = OSScreenEdgeSnappingChckbx.Checked;
            Settings.Default.CloseOnDC = OSCloseOnDisconnectChckbx.Checked;
            Settings.Default.OpacEnabled = OSTransparencyChckbx.Checked;
            Settings.Default.OnlyOnDeac = OSDeactivatedChckbx.Checked;
            Settings.Default.OpacValue = OSTransparencyTbar.Value;
            Settings.Default.Save();
        }
        private void HandshakeFinished()
        {
            Game.DataToClient -= Handshake_ToClient;
            Game.DataToClient += Game_DataToClient;

            Game.DataToServer -= Handshake_ToServer;
            Game.DataToServer += Game_DataToServer;
        }
        private void LoadTanjiExtensions()
        {
            if (!Directory.Exists("Extensions")) return;

            var extDirInfo = new DirectoryInfo("Extensions");
            FileInfo[] extDirFiles = extDirInfo.GetFiles();

            foreach (FileInfo extensionFile in extDirFiles)
            {
                if (extensionFile.Extension != ".dll") continue;

                try
                {
                    LoadSingleExtension(extensionFile.FullName);
                }
                catch { extensionFile.Delete(); }
            }
        }
        private void InitializeContractor()
        {
            _contractor = new Contractor(Game, _tanjiConnect.PlayerName, SKore.ToHotel(Game.Host));
            ETanjiExtensionViewer.Contractor = _contractor;
            _contractor.Invoked += Contractor_CommandReceived;

            if (!_extensionsLoaded)
            {
                _extensionsLoaded = true;
                LoadTanjiExtensions();
            }
        }
        private void LoadSingleExtension(string path)
        {
            ETanjiExtensionViewer.InstallExtension(path);

            const string ExtensionFormat = "Extensions Installed: {0}";
            ExtensionsActiveTxt.Text = string.Format(ExtensionFormat,
                _contractor.Extensions.Count);
        }

        private bool AttemptHandshake(HMessage packet)
        {
            int position = 0;
            return RsaKeyVerifier(_fakeClient, packet.ReadString(ref position), packet.ReadString(ref position));
        }
        private void AttemptSendToServer(HMessage packet)
        {
            if (!packet.IsCorrupted) Game.SendToServer(packet.ToBytes());
            else MessageBox.Show(InjServerCanc, TanjiError, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void AttemptSendToClient(HMessage packet)
        {
            if (!packet.IsCorrupted) Game.SendToClient(packet.ToBytes());
            else MessageBox.Show(InjClientCanc, TanjiError, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private bool RsaKeyVerifier(HKeyExchange handshakee, string signedPrime, string signedGenerator)
        {
            foreach (string[] fakeKeys in RsaKeys)
            {
                try
                {
                    int exponent = int.Parse(fakeKeys[0]);
                    string modulus = fakeKeys[1];
                    string privateExponent = fakeKeys[2];

                    _fakeClient = new HKeyExchange(exponent, modulus);
                    _fakeServer = new HKeyExchange(exponent, modulus, privateExponent);

                    _fakeClient.DoHandshake(signedPrime, signedGenerator);
                    return true;
                }
                catch { }
            }
            return false;
        }

        private HMessage GetSchedulerPacket()
        {
            var packet = new HMessage(ISPacketTxt.Text, (HDestination)(ISDirectionTxt.SelectedIndex));
            if (!packet.IsCorrupted) return packet;

            MessageBox.Show(CorrPack, TanjiError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            return null;
        }
        private HMessage GetConstructerPacket()
        {
            ushort header;
            if (ushort.TryParse(ICHeaderTxt.Text, out header))
                return ICTanjiConstructer.Construct(header);

            MessageBox.Show(BadHeader, TanjiError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            return null;
        }
        #endregion

        #region Public Methods
        public void HookGameEvents()
        {
            InitializeContractor();

            if (_tanjiConnect.CustomExponent != 0)
                RealExponent = _tanjiConnect.CustomExponent;

            if (!string.IsNullOrWhiteSpace(_tanjiConnect.CustomModulus))
                RealModulus = _tanjiConnect.CustomModulus;

            _fakeClient = new HKeyExchange(RealExponent, RealModulus);
            _fakeServer = new HKeyExchange(int.Parse(RsaKeys[0][0]), RsaKeys[0][1], RsaKeys[0][2]);

            Game.DataToClient += Handshake_ToClient;
            Game.DataToServer += Handshake_ToServer;

            Game.Disconnected += Game_Disconnected;
        }

        public static bool DoSnap(int position, int edge)
        {
            int delta = position - edge;
            return delta < 0 || delta > 0 && delta <= 20;
        }
        #endregion
    }
}