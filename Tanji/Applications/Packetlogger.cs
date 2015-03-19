using System;
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
        private Queue<DataToEventArgs> _dataQueue;
        private bool _loaded, _wasClosed, _queueRunning;

        private const string INFO_CHUNK_FORMAT = "( {0} - {1} )";
        private const string INCOMING_FORMAT = "<- Incoming{0} <- {1}";
        private const string OUTGOING_FORMAT = "-> Outgoing{0} -> {1}";

        public Color BlockHighlight { get; set; }
        public Color ReplaceHighlight { get; set; }
        public Color IncomingHighlight { get; set; }
        public Color OutgoingHighlight { get; set; }

        public bool ViewOutgoing { get; private set; }
        public bool ViewIncoming { get; private set; }

        public bool DisplayBlocked { get; private set; }
        public bool DisplayReplaced { get; private set; }
        public bool DisplaySplitter { get; private set; }

        public Packetlogger()
        {
            InitializeComponent();

            _dataQueue = new Queue<DataToEventArgs>();

            BlockHighlight = Color.DimGray;
            ReplaceHighlight = Color.DarkCyan;
            IncomingHighlight = Color.Firebrick;
            OutgoingHighlight = SystemColors.HotTrack;

            ViewOutgoing = ViewIncoming = true;
            DisplayBlocked = DisplayReplaced = DisplaySplitter = true;
        }

        private void ItemClicked(object sender, EventArgs e)
        {
            var item = (ToolStripMenuItem)sender;
            bool isChecked = (item.Checked = !item.Checked);

            switch (item.Name)
            {
                case "ViewIncomingBtn":
                {
                    CaptureIncomingLbl.Text = "Capture Incoming: " + isChecked;
                    ViewIncoming = isChecked;
                    break;
                }
                case "ViewOutgoingBtn":
                {
                    CaptureOutgoingLbl.Text = "Capture Outgoing: " + isChecked;
                    ViewOutgoing = isChecked;
                    break;
                }
                case "BlockedBtn":
                {
                    DisplayBlockedLbl.Text = "Display Blocked: " + isChecked;
                    DisplayBlocked = isChecked;
                    break;
                }
                case "ReplacedBtn":
                {
                    DisplayReplacedLbl.Text = "Display Replaced: " + isChecked;
                    DisplayReplaced = isChecked;
                    break;
                }
                case "DisplaySplitterBtn":
                {
                    DisplaySplitter = isChecked;
                    break;
                }
            }
        }
        private void CopyBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(LoggerTxt.SelectedText))
                Clipboard.SetText(LoggerTxt.SelectedText);
        }
        private void EmptyLogBtn_Click(object sender, EventArgs e)
        {
            LoggerTxt.Clear();
        }
        private void AlwaysOnTopBtn_Click(object sender, EventArgs e)
        {
            TopMost = AlwaysOnTopBtn.Checked;
        }

        private void Packetlogger_Activated(object sender, EventArgs e)
        {
            _loaded = true;
            if (_wasClosed)
            {
                _wasClosed = false;

                ToggleItem(ViewIncomingBtn, true);
                ToggleItem(ViewOutgoingBtn, true);
                ToggleItem(DisplaySplitterBtn, true);
            }
        }
        private void Packetlogger_FormClosing(object sender, FormClosingEventArgs e)
        {
            _loaded = false;
            e.Cancel = true;
            WindowState = FormWindowState.Minimized;

            Halt();
        }

        public void Halt()
        {
            _wasClosed = true;
            ToggleItem(ViewIncomingBtn, false);
            ToggleItem(ViewOutgoingBtn, false);
            ToggleItem(DisplaySplitterBtn, false);
            _dataQueue.Clear();
            LoggerTxt.Clear();
        }
        public void PushToQueue(DataToEventArgs e)
        {
            bool toServer = (e.Replacement.Destination == HDestination.Server);
            if (!ViewOutgoing && toServer || !ViewIncoming && !toServer
                || e.IsBlocked && !DisplayBlocked || e.IsReplaced && !DisplayReplaced) return;

            _dataQueue.Enqueue(e);

            if (!_queueRunning)
                Task.Factory.StartNew(RunQueue);
        }

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
                    HMessage packet = data.Replacement;

                    bool toServer = (packet.Destination == HDestination.Server);
                    if (!ViewOutgoing && toServer || !ViewIncoming && !toServer
                        || data.IsBlocked && !DisplayBlocked || data.IsReplaced && !DisplayReplaced) return;

                    var arguments = new object[] { packet.IsCorrupted
                        ? "Corrupted" : packet.Header.ToString(), packet.Length };

                    string info = string.Format(INFO_CHUNK_FORMAT, arguments);
                    string log = string.Format(toServer ? OUTGOING_FORMAT : INCOMING_FORMAT, info, packet);

                    while (!_loaded) Thread.Sleep(100);
                    Invoke(new MethodInvoker(() => Display(log, data)));
                }
            }
            finally { _queueRunning = false; }
        }
        private void Display(string message, DataToEventArgs e)
        {
            Color highlight = (e.Packet.Destination == HDestination.Client
                ? IncomingHighlight : OutgoingHighlight);

            if (e.IsBlocked) WriteHighlight("Blocked | ", BlockHighlight);
            else if (e.IsReplaced) WriteHighlight("Replaced | ", ReplaceHighlight);

            WriteHighlight(message + (DisplaySplitter ? "\n--------------------\n" : "\n"), highlight);
            LoggerTxt.SelectionStart = LoggerTxt.TextLength;
            LoggerTxt.ScrollToCaret();

            Application.DoEvents();
        }
        private void ToggleItem(ToolStripMenuItem item, bool check)
        {
            item.Checked = !check;
            ItemClicked(item, EventArgs.Empty);
        }
        private void WriteHighlight(string message, Color highlight)
        {
            LoggerTxt.SelectionStart = LoggerTxt.TextLength;
            LoggerTxt.SelectionLength = 0;
            LoggerTxt.SelectionColor = highlight;
            LoggerTxt.AppendText(message);
        }
    }
}