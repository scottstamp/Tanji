using System;
using System.Linq;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Collections.Generic;

using Sulakore.Protocol;
using Sulakore.Communication;

namespace Tanji.Applications
{
    public partial class Packetlogger : Form
    {
        #region Private Fields
        private Queue<DataToEventArgs> _dataQueue;
        private bool _loaded, _wasClosed, _queueRunning;

        private readonly object _queuePushLock;
        private readonly Color _defaultHightlight;

        private const string TitlePrefix = "Tanji ~ Packetlogger";
        private const string InfoChunkFormat = "( {0} - {1} )";
        private const string IncomingFormat = "<- Incoming{0} <- {1}";
        private const string OutgoingFormat = "-> Outgoing{0} -> {1}";
        private const string CorruptedChunkFormat = "( Corrupted - {0} )";
        #endregion

        #region Public Properties
        public Color IncomingHighlight { get; set; }
        public Color OutgoingHighlight { get; set; }

        public bool ViewOutgoing { get; private set; }
        public bool ViewIncoming { get; private set; }

        public bool DisplayVisualSplit { get; private set; }
        #endregion

        #region Constructor(s)
        public Packetlogger()
        {
            InitializeComponent();

            _queuePushLock = new object();
            _dataQueue = new Queue<DataToEventArgs>();
            _defaultHightlight = Color.FromArgb(225, 225, 225);

            IncomingHighlight = Color.Firebrick;
            OutgoingHighlight = SystemColors.HotTrack;
            ViewOutgoing = ViewIncoming = DisplayVisualSplit = true;

            LoggerTxt.ForeColor = _defaultHightlight;
        }
        #endregion

        #region User Interface Event Listeners
        private void ItemClicked(object sender, EventArgs e)
        {
            var item = (ToolStripMenuItem)sender;
            bool isChecked = (item.Checked = !item.Checked);

            switch (item.Name)
            {
                case "ToggleIncomingBtn":
                {
                    CapturingINLbl.Text = "Capturing Incoming: " + isChecked;
                    ViewIncoming = isChecked;

                    if (!ViewIncoming)
                        _dataQueue = new Queue<DataToEventArgs>(_dataQueue.Where(x => x.Packet.Destination != HDestination.Client));

                    break;
                }
                case "ToggleOutgoingBtn":
                {
                    CapturingOUTLbl.Text = "Capturing Outgoing: " + isChecked;
                    ViewOutgoing = isChecked;

                    if (!ViewOutgoing)
                        _dataQueue = new Queue<DataToEventArgs>(_dataQueue.Where(x => x.Packet.Destination != HDestination.Server));

                    break;
                }
                case "DisplayVisualSplitBtn": DisplayVisualSplit = isChecked; break;
            }
        }
        private void CopyBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(LoggerTxt.SelectedText))
                Clipboard.SetText(LoggerTxt.SelectedText);
        }
        private void TopMostBtn_Click(object sender, EventArgs e)
        {
            TopMost = TopMostBtn.Checked;
        }
        private void EmptyLogBtn_Click(object sender, EventArgs e)
        {
            LoggerTxt.Clear();
        }

        private void Packetlogger_Activated(object sender, EventArgs e)
        {
            _loaded = true;
            if (_wasClosed)
            {
                _wasClosed = false;
                Text = TitlePrefix;

                ToggleItem(ToggleIncomingBtn, true);
                ToggleItem(ToggleOutgoingBtn, true);
                ToggleItem(DisplayVisualSplitBtn, true);
            }
        }
        private void Packetlogger_FormClosing(object sender, FormClosingEventArgs e)
        {
            _loaded = false;
            e.Cancel = true;
            WindowState = FormWindowState.Minimized;

            Halt();
            Text = TitlePrefix + " [Paused]";
        }
        #endregion

        #region Public Methods
        public void Halt()
        {
            _wasClosed = true;
            ToggleItem(ToggleIncomingBtn, false);
            ToggleItem(ToggleOutgoingBtn, false);
            ToggleItem(DisplayVisualSplitBtn, false);
            _dataQueue.Clear();
            LoggerTxt.Clear();
        }
        public void PushToQueue(DataToEventArgs e)
        {
            bool toServer = (e.Replacement.Destination == HDestination.Server);
            if (!ViewOutgoing && toServer || !ViewIncoming && !toServer) return;

            _dataQueue.Enqueue(e);
            if (!_queueRunning) Task.Factory.StartNew(RunQueue);
        }
        public void DisplayMessage(string message)
        {
            Invoke(new MethodInvoker(() => Display(message, _defaultHightlight)));
        }
        #endregion

        #region Private Methods
        private void RunQueue()
        {
            if (_queueRunning) return;
            _queueRunning = true;

            try
            {
                while (_dataQueue.Count > 0)
                {
                    if (_dataQueue.Count == 0) break;
                    DataToEventArgs data = _dataQueue.Dequeue();
                    if (data == null) continue;

                    bool toServer = (data.Replacement.Destination == HDestination.Server);
                    if (!ViewOutgoing && toServer || !ViewIncoming && !toServer) continue;

                    object[] arguments = data.Replacement.IsCorrupted ? new object[] { data.Replacement.Length } : new object[] { data.Replacement.Header, data.Replacement.Length };
                    string infoChunk = string.Format(data.Replacement.IsCorrupted ? CorruptedChunkFormat : InfoChunkFormat, arguments);
                    string message = string.Format(toServer ? OutgoingFormat : IncomingFormat, infoChunk, data.Replacement);

                    if (data.Blocked)
                        message = string.Format("Blocked | {0}", message);

                    while (!_loaded) Thread.Sleep(100);
                    Invoke(new MethodInvoker(() => Display(message, !data.Blocked ? (toServer ? OutgoingHighlight : IncomingHighlight) : Color.FromArgb(225, 225, 225))));
                }
            }
            catch (Exception ex) { DisplayMessage(ex.ToString()); }
            finally { _queueRunning = false; }
        }
        private void Display(string message, Color highlight)
        {
            LoggerTxt.SelectionStart = LoggerTxt.TextLength;
            LoggerTxt.SelectionLength = 0;
            LoggerTxt.SelectionColor = highlight;
            LoggerTxt.AppendText(message + (DisplayVisualSplit ? "\n--------------------\n" : "\n"));
            LoggerTxt.SelectionStart = LoggerTxt.TextLength;
            LoggerTxt.ScrollToCaret();
            Application.DoEvents();
        }
        private void ToggleItem(ToolStripMenuItem item, bool check)
        {
            item.Checked = !check;
            ItemClicked(item, EventArgs.Empty);
        }
        #endregion
    }
}