﻿using System;
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
using System.Collections.Generic;

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
        private readonly Packetlogger _packetlogger;
        private readonly Action _initiate, _reinitiate;

        private const string CHUNK_COUNT_FORMAT = "Chunk Count: {0}";
        private const string TITLE_FORMAT = "Tanji ~ Connected[{0}:{1}]";
        private const string SCHEDULES_FORMAT = "Schedules Active: {0}/{1}";
        private const string EXTENSIONS_FORMAT = "Extensions Active: {0}/{1}";
        private const string PRIMITIVE_INFO_FORMAT = "Header: {0} | Length: {1} | Corrupted:";
        private const string TANJI_NEW_ISSUE_PAGE = "https://github.com/ArachisH/Tanji/issues/new";

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

            _packetlogger = new Packetlogger();
            _tanjiConnect = new TanjiConnect(this);

            _inBlockedHeaders = new List<ushort>();
            _inReplacedHeaders = new List<ushort>();

            _outBlockedHeaders = new List<ushort>();
            _outReplacedHeaders = new List<ushort>();

            OSAlwaysOnTopChckbx.Checked = TanjiSettings.Global.IsAlwaysOnTop;
            OSCloseOnDisconnectChckbx.Checked = TanjiSettings.Global.ShouldCloseOnDisconnect;

            _initiate = Initiate;
            _reinitiate = Reinitiate;
            _debugging = debugging;

            ISDestinationTxt.SelectedIndex = 1;
            IFBDestinationTxt.SelectedIndex = 1;
            IFRDestinationTxt.SelectedIndex = 1;
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
                            Game.OutgoingEncrypt = new Rc4(_fakeClientKey);
                            Game.OutgoingDecrypt = new Rc4(_fakeServerKey);

                            byte[] decrypted = Game.OutgoingDecrypt.SafeParse(e.Packet.ToBytes());
                            e.Replacement = new HMessage(decrypted, HDestination.Server);
                        }
                        break;
                    }
                }
            }
            catch { }
            finally
            {
                if (_packetlogger.ViewOutgoing)
                    _packetlogger.PushToQueue(e);

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
                            Game.IncomingDecrypt = new Rc4(_fakeClientKey);
                            Game.IncomingEncrypt = new Rc4(_fakeServerKey);

                            byte[] decrypted = Game.IncomingDecrypt.SafeParse(e.Packet.ToBytes());
                            e.Replacement = new HMessage(decrypted, HDestination.Client);
                        }
                        break;
                    }
                }
            }
            catch { }
            finally
            {
                if (_packetlogger.ViewIncoming)
                    _packetlogger.PushToQueue(e);

                _contractor.ProcessIncoming(e.Replacement.ToBytes());
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {
            if (!_debugging) Initiate();
            else
            {
                InitializeContractor();
                _packetlogger.Show();
            }
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

        #region Injection | Methods
        #region Constructer | Methods
        private void ICClearBtn_Click(object sender, EventArgs e)
        {
            ICConstructerLstvw.ClearItems();
            ICRemoveBtn.Enabled = ICMoveDownBtn.Enabled = ICMoveUpBtn.Enabled = false;

            ICChunkCountLbl.Text = string.Format(CHUNK_COUNT_FORMAT,
                ICConstructerLstvw.ChunksWritten.Count);
        }
        private void ICAppendBtn_Click(object sender, EventArgs e)
        {
            object value = null;
            int count = (int)ICCountTxt.Value;
            switch (((Control)sender).Text.Split(' ')[1])
            {
                case "String": value = ICValueTxt.Text; break;
                case "Integer":
                {
                    int outcome = 0;
                    int.TryParse(ICValueTxt.Text, out outcome);
                    value = outcome;
                    break;
                }
                case "Boolean":
                {
                    if (string.IsNullOrWhiteSpace(ICValueTxt.Text))
                        value = false;
                    else
                    {
                        char start = ICValueTxt.Text[0];
                        value = (start == 't' || start == '1');
                    }
                    break;
                }
            }

            var values = new object[count];
            for (int i = 0; i < values.Length; i++)
                values[i] = value;

            ICConstructerLstvw.Append(values);

            ICChunkCountLbl.Text = string.Format(CHUNK_COUNT_FORMAT,
                ICConstructerLstvw.ChunksWritten.Count);
        }
        private void ICRemoveBtn_Click(object sender, EventArgs e)
        {
            ICConstructerLstvw.RemoveSelectedItem();

            ICChunkCountLbl.Text = string.Format(CHUNK_COUNT_FORMAT,
                ICConstructerLstvw.ChunksWritten.Count);
        }

        private void ICMoveUpBtn_Click(object sender, EventArgs e)
        {
            ICConstructerLstvw.MoveSelectedItemUp();
        }
        private void ICMoveDownBtn_Click(object sender, EventArgs e)
        {
            ICConstructerLstvw.MoveSelectedItemDown();
        }

        private void ICSchedulerBtn_Click(object sender, EventArgs e)
        {
            IInjectionTabs.SelectTab(ISchedulerTab);
            ISPacketTxt.Text = ICConstructerLstvw.GetString();
        }
        private void ICInjectionBtn_Click(object sender, EventArgs e)
        {
            IPacketTxt.Text = ICConstructerLstvw.GetString();
        }
        private void ICPrimitiveBtn_Click(object sender, EventArgs e)
        {
            IPacketTxt.Text = ICConstructerLstvw.GetString();
            IInjectionTabs.SelectTab(IPrimitiveTab);
        }
        private void ICCopyPacketBtn_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(ICConstructerLstvw.GetString());
        }

        private void ICValueTxt_TextChanged(object sender, EventArgs e)
        {
            if (ICConstructerLstvw.SelectedItems.Count < 1) return;
            string typeName = ICConstructerLstvw.SelectedItems[0].SubItems[0].Text;

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
            ICConstructerLstvw.ReplaceItem(chunk);
        }
        private void ICHeaderTxt_TextChanged(object sender, EventArgs e)
        {
            ushort header = 0;
            if (ushort.TryParse(ICHeaderTxt.Text, out header))
                ICConstructerLstvw.Header = header;
        }
        private void ICConstructerLstVw_ItemActivate(object sender, EventArgs e)
        {
            if (ICConstructerLstvw.SelectedItems.Count < 1) return;

            object chunk = null;
            ListViewItem item = ICConstructerLstvw.SelectedItems[0];
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

            ICConstructerLstvw.ReplaceItem(chunk);
            ICValueTxt.Focus();
        }
        private void ICConstructerLstVw_ItemsDeselected(object sender, EventArgs e)
        {
            ICRemoveBtn.Enabled = false;
            ICMoveUpBtn.Enabled = false;
            ICMoveDownBtn.Enabled = false;

            ICValueTxt.Text = string.Empty;
        }
        private void ICConstructerLstVw_ItemSelected(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            ICRemoveBtn.Enabled = true;

            ICMoveUpBtn.Enabled = e.ItemIndex != 0;
            ICMoveDownBtn.Enabled = e.ItemIndex != ICConstructerLstvw.Items.Count - 1;

            ICValueTxt.Text = e.IsSelected ? e.Item.SubItems[1].Text : string.Empty;
        }
        #endregion

        #region Scheduler | Methods
        private void UpdateSchedulerUI(bool itemSelected)
        {
            int itemCount = ISSchedulerLstvw.Items.Count;
            bool containsItems = itemCount > 0;

            SchedulesTxt.Text = string.Format(SCHEDULES_FORMAT,
                ISSchedulerLstvw.Running, itemCount);

            ISRemoveBtn.Enabled = itemSelected;
            ISClearBtn.Enabled = containsItems;
            ISStopAllBtn.Enabled = containsItems;
            ISStartAllBtn.Enabled = containsItems;
        }

        private void ISStopAllBtn_Click(object sender, EventArgs e)
        {
            ISSchedulerLstvw.StopAllSchedules();
            UpdateSchedulerUI(ISSchedulerLstvw.SelectedItems.Count > 0);
        }
        private void ISStartAllBtn_Click(object sender, EventArgs e)
        {
            ISSchedulerLstvw.StartAllSchedules();
            UpdateSchedulerUI(ISSchedulerLstvw.SelectedItems.Count > 0);
        }

        private void ISClearBtn_Click(object sender, EventArgs e)
        {
            ISSchedulerLstvw.ClearItems();
        }
        private void ISRemoveBtn_Click(object sender, EventArgs e)
        {
            ISSchedulerLstvw.RemoveSelectedItem();
            UpdateSchedulerUI(ISSchedulerLstvw.SelectedItems.Count > 0);
        }
        private void ISCreateBtn_Click(object sender, EventArgs e)
        {
            var packet = new HMessage(ISPacketTxt.Text, (HDestination)ISDestinationTxt.SelectedIndex + 1);
            ISSchedulerLstvw.AddSchedule(packet, (int)ISBurstTxt.Value, (int)ISIntervalTxt.Value, ISDescriptionTxt.Text);
        }
        private void ISAutoStartChckbx_CheckedChanged(object sender, EventArgs e)
        {
            ISSchedulerLstvw.AutoStart = ISAutoStartChckbx.Checked;
        }

        private void ISSchedulesLstVw_ItemsDeselected(object sender, EventArgs e)
        {
            UpdateSchedulerUI(false);
        }
        private void ISSchedulesLstVw_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            UpdateSchedulerUI(ISSchedulerLstvw.SelectedItems.Count > 0);
        }
        private void ISSchedulesLstVw_ScheduleTriggered(object sender, HScheduleTriggeredEventArgs e)
        {
            if (!e.Packet.IsCorrupted && Game.IsConnected) SendTo(e.Packet);
            else e.Cancel = true;
        }
        private void ISSchedulesLstVw_ItemSelected(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            UpdateSchedulerUI(true);
        }
        #endregion

        #region Primitive | Methods
        private void IPPrimitiveTxt_TextChanged(object sender, EventArgs e)
        {
            if (IPPrimitiveTxt.TextLength < 1) IPacketTxt.Text = string.Empty;
            else if (IPPrimitiveTxt.TextLength < 2) return;

            HMessage packet = null;
            bool isCorrupted = false;
            try
            {
                byte[] data = HMessage.ToBytes(IPPrimitiveTxt.Text);
                if (data.Length >= 6)
                {
                    packet = new HMessage(data);
                    isCorrupted = (data.Length < 2 || packet.IsCorrupted);
                }
                else isCorrupted = true;
            }
            catch { isCorrupted = true; }
            finally
            {
                IPacketTxt.Text = isCorrupted ? IPPrimitiveTxt.Text : packet.ToString();

                IPPacketInfoLbl.Text = string.Format(PRIMITIVE_INFO_FORMAT,
                    (isCorrupted ? 0 : packet.Header),
                    (isCorrupted ? IPPrimitiveTxt.TextLength : packet.Length));

                IPIsCorruptedLbl.Text = isCorrupted.ToString();
                IPIsCorruptedLbl.ForeColor = isCorrupted ? Color.Firebrick : SystemColors.HotTrack;

                IPIsCorruptedLbl.Location = new Point((IPPacketInfoLbl.Location.X + IPPacketInfoLbl.Width) - 5,
                    IPIsCorruptedLbl.Location.Y);
            }
        }
        private void IInjectionTabs_Selected(object sender, TabControlEventArgs e)
        {
            if (IPacketTxt.ReadOnly = (e.TabPage == IPrimitiveTab))
                IPPrimitiveTxt.Text = IPacketTxt.Text;
        }
        #endregion

        #region Triggers | Methods
        #endregion

        #region Filters | Methods
        private HMessage _replacement;
        private ushort _headerToBlock, _headerToReplace;

        private readonly IList<ushort> _inBlockedHeaders, _outBlockedHeaders,
            _inReplacedHeaders, _outReplacedHeaders;

        private void IFRReplacementTxt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _replacement = new HMessage(IFRReplacementTxt.Text,
                    (HDestination)IFRDestinationTxt.SelectedIndex + 1);
            }
            catch { _replacement = null; }
            finally
            {
                IFRReplaceBtn.Enabled = (_headerToReplace != 0
                    && _replacement != null && !_replacement.IsCorrupted);
            }
        }

        private void IFBlockBtn_Click(object sender, EventArgs e)
        {
            ushort header = _headerToBlock;
            switch (IFBDestinationTxt.SelectedIndex)
            {
                case 0:
                {
                    if (_inBlockedHeaders.Contains(header)) return;
                    _inBlockedHeaders.Add(header);
                    Game.Filters.InBlock(header); break;
                }
                case 1:
                {
                    if (_outBlockedHeaders.Contains(header)) return;
                    _outBlockedHeaders.Add(header);
                    Game.Filters.OutBlock(header); break;
                }
            }

            IFBBlockLstvw.ItemChecked -= IFBlockLstvw_ItemChecked;
            IFBBlockLstvw.FocusAdd((string)IFBDestinationTxt.SelectedItem, header.ToString(), "MASTER")
                .Checked = true;
            IFBBlockLstvw.ItemChecked += IFBlockLstvw_ItemChecked;
        }
        private void IFRReplaceBtn_Click(object sender, EventArgs e)
        {
            ushort header = _headerToReplace;
            var replacement = new HMessage(_replacement.ToBytes(), _replacement.Destination);

            switch (_replacement.Destination)
            {
                case HDestination.Client:
                {
                    if (_inReplacedHeaders.Contains(header)) return;
                    _inReplacedHeaders.Add(header);
                    Game.Filters.InReplace(header, replacement);
                    break;
                }
                case HDestination.Server:
                {
                    if (_outReplacedHeaders.Contains(header)) return;
                    _outReplacedHeaders.Add(header);
                    Game.Filters.OutReplace(header, replacement);
                    break;
                }
            }

            IFRReplaceLstvw.ItemChecked -= IFRReplaceLstvw_ItemChecked;
            IFRReplaceLstvw.FocusAdd(replacement.Destination.ToString(), header.ToString(), replacement.ToString())
                .Checked = true;
            IFRReplaceLstvw.ItemChecked += IFRReplaceLstvw_ItemChecked;
        }

        private void IFUnblockBtn_Click(object sender, EventArgs e)
        {
            ListViewItem item = IFBBlockLstvw.GetSelectedItem();
            ushort header = ushort.Parse(item.SubItems[1].Text);
            switch (item.SubItems[0].Text)
            {
                case "Client":
                {
                    if (!_inBlockedHeaders.Contains(header)) return;
                    _inBlockedHeaders.Remove(header);
                    Game.Filters.InUnblock(header);
                    break;
                }
                case "Server":
                {
                    if (!_outBlockedHeaders.Contains(header)) return;
                    _outBlockedHeaders.Remove(header);
                    Game.Filters.OutUnblock(header);
                    break;
                }
            }
            IFBBlockLstvw.RemoveSelectedItem();
        }
        private void IFRUnreplaceBtn_Click(object sender, EventArgs e)
        {
            ListViewItem item = IFRReplaceLstvw.GetSelectedItem();
            ushort header = ushort.Parse(item.SubItems[1].Text);
            switch (item.SubItems[0].Text)
            {
                case "Client":
                {
                    if (!_inReplacedHeaders.Contains(header)) return;
                    _inReplacedHeaders.Remove(header);
                    Game.Filters.InUnreplace(header);
                    break;
                }
                case "Server":
                {
                    if (!_outReplacedHeaders.Contains(header)) return;
                    _outReplacedHeaders.Remove(header);
                    Game.Filters.OutUnreplace(header);
                    break;
                }
            }
            IFRReplaceLstvw.RemoveSelectedItem();
        }

        private void IFHeaderTxt_TextChanged(object sender, EventArgs e)
        {
            ushort header = 0;
            bool convertSuccess = ushort.TryParse(IFBHeaderTxt.Text, out header);
            _headerToBlock = header;

            IFBBlockBtn.Enabled = convertSuccess;
        }
        private void IFRHeaderTxt_TextChanged(object sender, EventArgs e)
        {
            ushort header = 0;
            bool convertSuccess = ushort.TryParse(IFRHeaderTxt.Text, out header);
            _headerToReplace = header;

            IFRReplaceBtn.Enabled = convertSuccess && (_replacement != null && !_replacement.IsCorrupted);
        }

        private void IFBlockLstvw_ItemsDeselected(object sender, EventArgs e)
        {
            IFBUnblockBtn.Enabled = false;
        }
        private void IFRReplaceLstvw_ItemsDeselected(object sender, EventArgs e)
        {
            IFRUnreplaceBtn.Enabled = false;
        }

        private void IFBlockLstvw_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            ushort header = ushort.Parse(e.Item.SubItems[1].Text);
            switch (e.Item.SubItems[0].Text)
            {
                case "Client":
                {
                    if (e.Item.Checked) Game.Filters.InBlock(header);
                    else Game.Filters.InUnblock(header);
                    break;
                }
                case "Server":
                {
                    if (e.Item.Checked) Game.Filters.OutBlock(header);
                    else Game.Filters.OutUnblock(header);
                    break;
                }
            }
        }
        private void IFRReplaceLstvw_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            ushort header = ushort.Parse(e.Item.SubItems[1].Text);
            var destination = (HDestination)Enum.Parse(typeof(HDestination), e.Item.SubItems[0].Text);
            var replacement = new HMessage(e.Item.SubItems[2].Text, destination);

            switch (destination)
            {
                case HDestination.Client:
                {
                    if (e.Item.Checked) Game.Filters.InReplace(header, replacement);
                    else Game.Filters.InUnreplace(header);
                    break;
                }
                case HDestination.Server:
                {
                    if (e.Item.Checked) Game.Filters.OutReplace(header, replacement);
                    else Game.Filters.OutUnreplace(header);
                    break;
                }
            }
        }

        private void IFBlockLstvw_ItemSelected(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            IFBUnblockBtn.Enabled = true;
        }
        private void IFRReplaceLstvw_ItemSelected(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            IFRUnreplaceBtn.Enabled = true;
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

        #region Encode/Decoder | Methods
        private void EDCypherIntegerBtn_Click(object sender, EventArgs e)
        {
            int value;
            if (int.TryParse(EDIntegerInputTxt.Text, out value))
                EDIntegerOutputTxt.Text = HMessage.ToString(BigEndian.CypherInt(value));
            else MessageBox.Show(NotInt32, "Tanji ~ Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void EDDecypherIntegerBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(EDIntegerOutputTxt.Text))
                EDIntegerInputTxt.Text = BigEndian.DecypherInt(HMessage.ToBytes(EDIntegerOutputTxt.Text)).ToString();
        }

        private void EDCypherShortBtn_Click(object sender, EventArgs e)
        {
            ushort value;
            if (ushort.TryParse(EDShortInputTxt.Text, out value))
                EDShortOutputTxt.Text = HMessage.ToString(BigEndian.CypherShort(value));
            else MessageBox.Show(NotUInt16, "Tanji ~ Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void EDDecypherShortBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(EDShortOutputTxt.Text))
                EDShortInputTxt.Text = BigEndian.DecypherShort(HMessage.ToBytes(EDShortOutputTxt.Text)).ToString();
        }

        private void EDExtractValuesBtn_Click(object sender, EventArgs e)
        {
            EDExtracterLstvw.Items.Clear();
            byte[] encodedBlocks = HMessage.ToBytes(EDEncodedBlocksTxt.Text);
            if (encodedBlocks.Length % 4 == 0)
            {
                int value = 0;
                string encoded = string.Empty;
                byte[] encodedBlock = new byte[4];
                for (int i = 0; i < encodedBlocks.Length; i += 4)
                {
                    Buffer.BlockCopy(encodedBlocks, i, encodedBlock, 0, 4);
                    value = BigEndian.DecypherInt(encodedBlock);
                    encoded = HMessage.ToString(encodedBlock);

                    EDExtracterLstvw.FocusAdd(value.ToString(), encoded, i.ToString());
                }
            }
        }
        #endregion

        #region Toolbox | Methods
        private void TRequestLbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            TRequestLbl.LinkVisited = true;
            Process.Start(TANJI_NEW_ISSUE_PAGE);
        }
        #endregion

        #region Extensions | Methods
        private void UpdateExtensionInfo(bool extensionSelected)
        {
            if (!extensionSelected) EExtensionLogoPctbx.Image = Resources.Tanji;
            else
            {
                ExtensionBase extension = EExtensionsLstvw.GetItemExtension();
                if (extension == null || extension.UIContext == null) return;

                EExtensionLogoPctbx.Image = extension.Logo ?? Resources.Tanji;

                if (EExtensionLogoPctbx.Size.Width < 64 || EExtensionLogoPctbx.Image.Size.Height < 64)
                    EExtensionLogoPctbx.SizeMode = PictureBoxSizeMode.CenterImage;
                else EExtensionLogoPctbx.SizeMode = PictureBoxSizeMode.Zoom;

                extension.UIContext.BringToFront();
            }

            ExtensionsActiveTxt.Text = string.Format(EXTENSIONS_FORMAT,
                _contractor.ExtensionsRunning.Count, _contractor.Extensions.Count);
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

                        ICConstructerLstvw.BeginUpdate();
                        for (int i = 1; i < e.Args.Length; i++)
                            ICConstructerLstvw.Append(e.Args[i]);
                        ICConstructerLstvw.EndUpdate();
                        break;
                    }
                }
                e.Result = true;
            }
            catch { e.Result = false; }
        }

        private void EOpenExtensionBtn_Click(object sender, EventArgs e)
        {
            EExtensionsLstvw.InitializeItemExtension();
            UpdateExtensionInfo(EExtensionsLstvw.SelectedItems.Count > 1);
        }
        private void EInstallExtensionBtn_Click(object sender, EventArgs e)
        {
            ChooseExtensionDlg.FileName = ChooseExtensionDlg.SafeFileName;
            if (ChooseExtensionDlg.ShowDialog() != DialogResult.OK) return;

            LoadSingleExtension(ChooseExtensionDlg.FileName);
            UpdateExtensionInfo(EExtensionsLstvw.SelectedItems.Count > 1);
        }
        private void EUninstallExtensionBtn_Click(object sender, EventArgs e)
        {
            EExtensionsLstvw.RemoveSelectedItem();

            if (_contractor.Extensions.Count < 1)
                EOpenBtn.Enabled = EUninstallBtn.Enabled = false;

            UpdateExtensionInfo(EExtensionsLstvw.SelectedItems.Count > 1);
        }

        private void ExtensionViewer_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Effect != DragDropEffects.Copy) return;

            string path = ((string[])(e.Data.GetData(DataFormats.FileDrop)))[0];
            LoadSingleExtension(path);

            UpdateExtensionInfo(EExtensionsLstvw.SelectedItems.Count > 1);
        }
        private void ExtensionViewer_DragEnter(object sender, DragEventArgs e)
        {
            if (((string[])(e.Data.GetData(DataFormats.FileDrop)))[0].EndsWith(".dll"))
                e.Effect = DragDropEffects.Copy;
        }

        private void ETanjiExtensionViewer_ItemActivate(object sender, EventArgs e)
        {
            EExtensionsLstvw.InitializeItemExtension();
            UpdateExtensionInfo(true);
        }
        private void ETanjiExtensionViewer_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (EOpenBtn.Enabled != e.IsSelected)
                EOpenBtn.Enabled = EUninstallBtn.Enabled = e.IsSelected;

            UpdateExtensionInfo(e.IsSelected);
        }
        #endregion

        #region Options | Methods
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

            _packetlogger.Show();
            _packetlogger.BringToFront();

            Text = string.Format(TITLE_FORMAT, Game.Host, Game.Port);
        }
        private void Reinitiate()
        {
            if (InvokeRequired) { Invoke(_reinitiate); return; }

            if (ISSchedulerLstvw.Items.Count > 0)
                ISSchedulerLstvw.StopAllSchedules();

            foreach (ExtensionBase extension in _contractor.Extensions)
                _contractor.Dispose(extension);

            if (_fakeClient != null)
                _fakeClient.Dispose();

            if (_fakeServer != null)
                _fakeServer.Dispose();

            Hide();
            _packetlogger.Halt();
            _packetlogger.Hide();

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
            EExtensionsLstvw.Install(_contractor.Install(path));

            ExtensionsActiveTxt.Text = string.Format(EXTENSIONS_FORMAT,
                _contractor.ExtensionsRunning.Count, _contractor.Extensions.Count);
        }
    }
}