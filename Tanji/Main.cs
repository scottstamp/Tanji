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
        private int _clientStepShift;
        private Contractor _contractor;
        private bool _debugging, _extensionsLoaded;
        private byte[] _fakeClientKey, _fakeServerKey;
        private HKeyExchange _fakeClient;

        private readonly HKeyExchange _fakeServer;
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

        public static int RExponent { get; set; }
        public static string RModulus { get; set; }

        public const int FEXPONENT = 3;
        public const string FMODULUS = "86851dd364d5c5cece3c883171cc6ddc5760779b992482bd1e20dd296888df91b33b936a7b93f06d29e8870f703a216257dec7c81de0058fea4cc5116f75e6efc4e9113513e45357dc3fd43d4efab5963ef178b78bd61e81a14c603b24c8bcce0a12230b320045498edc29282ff0603bc7b7dae8fc1b05b52b2f301a9dc783b7";
        public static string FPRIVATEEXPONENT = "59ae13e243392e89ded305764bdd9e92e4eafa67bb6dac7e1415e8c645b0950bccd26246fd0d4af37145af5fa026c0ec3a94853013eaae5ff1888360f4f9449ee023762ec195dff3f30ca0b08b8c947e3859877b5d7dced5c8715c58b53740b84e11fbc71349a27c31745fcefeeea57cff291099205e230e0c7c27e8e1c0512b";

        public bool CloseOnDisconnect { get; set; }

        public const string TanjiAlert = "Tanji ~ Alert!";
        public const string TanjiError = "Tanji ~ Error!";
        public const string TanjiWarning = "Tanji ~ Warning!";

        public static HConnection Game { get; set; }

        #region Constructor(s)
        public Main(bool debugging)
        {
            InitializeComponent();

            _fakeServer = new HKeyExchange(FEXPONENT, FMODULUS, FPRIVATEEXPONENT);

            RExponent = 10001;
            RModulus = "e052808c1abef69a1a62c396396b85955e2ff522f5157639fa6a19a98b54e0e4d6e44f44c4c0390fee8ccf642a22b6d46d7228b10e34ae6fffb61a35c11333780af6dd1aaafa7388fa6c65b51e8225c6b57cf5fbac30856e896229512e1f9af034895937b2cb6637eb6edf768c10189df30c10d8a3ec20488a198063599ca6ad";

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

            _packetloggerF = new Packetlogger();
            _tanjiConnect = new TanjiConnect(this);

            _initiate = Initiate;
            _reinitiate = Reinitiate;
            _debugging = debugging;

            ISDestinationTxt.SelectedIndex = 1;
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
        private void VersionTxt_Click(object sender, EventArgs e)
        {
            if (!VersionTxt.IsLink) return;

            VersionTxt.LinkVisited = true;
            const string TanjiThread = "http://arachish.github.io/Tanji/";
            Process.Start(TanjiThread);
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

        #region Injection Related Methods
        #region Constructer Related Methods
        private void ICAppendIntegerBtn_Click(object sender, EventArgs e)
        {
            int value;
            int count = (int)ICCountTxt.Value;
            int.TryParse(ICValueTxt.Text, out value);

            ICTanjiConstructer.BeginUpdate();
            for (int i = 0; i < count; i++)
                ICTanjiConstructer.Append(value);
            ICTanjiConstructer.EndUpdate();
        }
        private void ICAppendStringBtn_Click(object sender, EventArgs e)
        {
            string value = ICValueTxt.Text;
            int count = (int)ICCountTxt.Value;

            ICTanjiConstructer.BeginUpdate();
            for (int i = 0; i < count; i++)
                ICTanjiConstructer.Append(value);
            ICTanjiConstructer.EndUpdate();
        }
        private void ICAppendBooleanBtn_Click(object sender, EventArgs e)
        {
            int count = (int)ICCountTxt.Value;
            bool value = (!string.IsNullOrEmpty(ICValueTxt.Text) && (ICValueTxt.Text[0] == 't' || ICValueTxt.Text[0] == '1'));

            ICTanjiConstructer.BeginUpdate();
            for (int i = 0; i < count; i++)
                ICTanjiConstructer.Append(value);
            ICTanjiConstructer.EndUpdate();
        }

        private void ICMoveUpBtn_Click(object sender, EventArgs e)
        {
            ICTanjiConstructer.MoveSelectedItemUp();
        }
        private void ICMoveDownBtn_Click(object sender, EventArgs e)
        {
            ICTanjiConstructer.MoveSelectedItemDown();
        }

        private void ICClearBtn_Click(object sender, EventArgs e)
        {
            ICTanjiConstructer.ClearItems();
            ICRemoveBtn.Enabled = ICMoveDownBtn.Enabled = ICMoveUpBtn.Enabled = false;
        }
        private void ICRemoveBtn_Click(object sender, EventArgs e)
        {
            ICTanjiConstructer.RemoveSelectedItem();
        }
        private void ICSchedulerBtn_Click(object sender, EventArgs e)
        {
            IInjectionTabs.SelectTab(ISchedulerTab);
            ISPacketTxt.Text = ICTanjiConstructer.GetString();
        }
        private void ICInjectionBtn_Click(object sender, EventArgs e)
        {
            IPacketTxt.Text = ICTanjiConstructer.GetString();
        }
        private void ICPrimitiveBtn_Click(object sender, EventArgs e)
        {
            IPacketTxt.Text = ICTanjiConstructer.GetString();
            IInjectionTabs.SelectTab(IPrimitiveTab);
        }

        private void ICCopyPacketBtn_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(ICTanjiConstructer.GetString());
        }

        private void ICValueTxt_TextChanged(object sender, EventArgs e)
        {
            if (ICTanjiConstructer.SelectedItems.Count < 1) return;
            string typeName = ICTanjiConstructer.SelectedItems[0].SubItems[0].Text;

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
            ICTanjiConstructer.ReplaceItem(chunk);
        }
        private void ICHeaderTxt_TextChanged(object sender, EventArgs e)
        {
            ushort header = 0;
            if (ushort.TryParse(ICHeaderTxt.Text, out header))
                ICTanjiConstructer.Header = header;
        }
        private void ICTanjiConstructer_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (ICTanjiConstructer.SelectedItems.Count < 1) return;

            object chunk = null;
            ListViewItem item = ICTanjiConstructer.SelectedItems[0];
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

            ICTanjiConstructer.ReplaceItem(chunk);
            ICValueTxt.Focus();
        }
        private void ICTanjiConstructer_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            ICRemoveBtn.Enabled = e.IsSelected;
            ICMoveUpBtn.Enabled = e.IsSelected && e.ItemIndex != 0;
            ICMoveDownBtn.Enabled = e.IsSelected && e.ItemIndex != ICTanjiConstructer.Items.Count - 1;
            ICValueTxt.Text = e.IsSelected ? e.Item.SubItems[1].Text : string.Empty;

            const string ChunkCountFormat = "Chunk Count: {0}";
            ICChunkCountLbl.Text = string.Format(ChunkCountFormat, ICTanjiConstructer.ChunksWritten.Count);
        }
        #endregion

        #region Scheduler Related Methods
        private void ISStopAllBtn_Click(object sender, EventArgs e)
        {
            ISTanjiScheduler.StopAllSchedules();
            SchedulesTxt.Text = string.Format(ScheduleFormat, ISTanjiScheduler.Running, ISTanjiScheduler.Items.Count);
        }
        private void ISStartAllBtn_Click(object sender, EventArgs e)
        {
            ISTanjiScheduler.StartAllSchedules();
            SchedulesTxt.Text = string.Format(ScheduleFormat, ISTanjiScheduler.Running, ISTanjiScheduler.Items.Count);
        }
        private void ISRemoveBtn_Click(object sender, EventArgs e)
        {
            ISTanjiScheduler.RemoveSelectedItem();
            ISStopAllBtn.Enabled = (ISTanjiScheduler.Items.Count > 0);
            SchedulesTxt.Text = string.Format(ScheduleFormat, ISTanjiScheduler.Running, ISTanjiScheduler.Items.Count);
        }
        private void ISCreateBtn_Click(object sender, EventArgs e)
        {
            var packet = GetSchedulerPacket();
            if (packet == null) return;

            ISTanjiScheduler.AutoStart = ISAutoStartChckbx.Checked;
            ISStopAllBtn.Enabled = true;
            ISTanjiScheduler.AddSchedule(packet, (int)ISBurstTxt.Value, (int)ISIntervalTxt.Value, ISDescriptionTxt.Text);

            SchedulesTxt.Text = string.Format(ScheduleFormat, ISTanjiScheduler.Running, ISTanjiScheduler.Items.Count);
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
            if (ISRemoveBtn.Enabled != e.IsSelected)
                ISRemoveBtn.Enabled = ISStartAllBtn.Enabled = e.IsSelected;
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

                        ICTanjiConstructer.BeginUpdate();
                        for (int i = 1; i < e.Args.Length; i++)
                            ICTanjiConstructer.Append(e.Args[i]);
                        ICTanjiConstructer.EndUpdate();
                        break;
                    }
                }
                e.Result = true;
            }
            catch { e.Result = false; }
        }

        private void EOpenExtensionBtn_Click(object sender, EventArgs e)
        {
            ETanjiExtensionViewer.InitializeItemExtension();
        }
        private void EInstallExtensionBtn_Click(object sender, EventArgs e)
        {
            ChooseExtensionDlg.FileName = ChooseExtensionDlg.SafeFileName;
            if (ChooseExtensionDlg.ShowDialog() != DialogResult.OK) return;

            LoadSingleExtension(ChooseExtensionDlg.FileName);
        }
        private void EUninstallExtensionBtn_Click(object sender, EventArgs e)
        {
            ETanjiExtensionViewer.RemoveSelectedItem();

            // TODO: Get the amount of extensions running.
            const string ExtensionFormat = "Extensions Active: {0}/{1}";
            ExtensionsActiveTxt.Text = string.Format(ExtensionFormat, 0, _contractor.Extensions.Count);

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
            Settings.Default.CloseOnDC = OSCloseOnDisconnectChckbx.Checked;
            Settings.Default.Save();
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
                        _fakeClient.DoHandshake(e.Packet.ReadString(), e.Packet.ReadString(e.Packet.Position));
                        e.Replacement.ReplaceAt<string>(0, _fakeServer.SignedPrime);
                        e.Replacement.ReplaceAt<string>(e.Packet.Position, _fakeServer.SignedGenerator);
                        break;
                    }
                    case 2:
                    {
                        if (e.Packet.Length == 2) { _clientStepShift++; break; }

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
                    default: HandshakeFinished(); break;
                }
            }
            catch { HandshakeFinished(); }
            Game_DataToClient(sender, e);
        }

        private void Game_Disconnected(object sender, DisconnectedEventArgs e)
        {
            if (Settings.Default.CloseOnDC)
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
            _contractor = new Contractor(Game, _tanjiConnect.PlayerName, _tanjiConnect.GameData);
            _contractor.Invoked += Contractor_CommandReceived;

            if (!_extensionsLoaded)
            {
                _extensionsLoaded = true;
                LoadTanjiExtensions();
            }
        }
        private void LoadSingleExtension(string path)
        {
            ETanjiExtensionViewer.Install(_contractor.Install(path));

            const string ExtensionFormat = "Extensions Active: {0}/{1}";
            ExtensionsActiveTxt.Text = string.Format(ExtensionFormat, 0, _contractor.Extensions.Count);
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

        private HMessage GetSchedulerPacket()
        {
            var packet = new HMessage(ISPacketTxt.Text, (HDestination)(ISDestinationTxt.SelectedIndex + 1));
            if (!packet.IsCorrupted) return packet;

            MessageBox.Show(CorrPack, TanjiError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            return null;
        }
        #endregion

        #region Public Methods
        public void HookGameEvents()
        {
            InitializeContractor();

            if (_tanjiConnect.CustomExponent != 0)
                RExponent = _tanjiConnect.CustomExponent;

            if (!string.IsNullOrWhiteSpace(_tanjiConnect.CustomModulus))
                RModulus = _tanjiConnect.CustomModulus;

            _fakeClient = new HKeyExchange(RExponent, RModulus);

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