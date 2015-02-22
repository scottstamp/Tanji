using System;
using System.Drawing;
using System.Windows.Forms;

using Sulakore.Protocol;
using Sulakore.Components;

namespace Tanji.Dialogs
{
    public partial class TanjiSchedulerEdit : Form
    {
        private readonly bool _wasRunning;
        private readonly HSchedule _schedule;
        private readonly SKoreScheduler _scheduler;

        public TanjiSchedulerEdit(SKoreScheduler scheduler)
        {
            InitializeComponent();

            _scheduler = scheduler;
            _schedule = _scheduler.GetSelected();

            _wasRunning = _schedule.IsRunning;
            _schedule.Stop();

            bool toServer = _schedule.Packet.Destination == HDestination.Server;
            (toServer ? ServerRdiBtn : ClientRdiBtn).Checked = true;
            PacketTxt.ForeColor = (toServer ? SystemColors.HotTrack : Color.Firebrick);

            DescriptionTxt.Text = _scheduler.GetSelectedDescription();

            BurstTxt.Value = _schedule.Burst;
            IntervalTxt.Value = _schedule.Interval;

            PacketTxt.Text = _schedule.Packet.ToString();
            PacketTxt_TextChanged(this, EventArgs.Empty);
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            if (!UpdateBtn.Enabled) return;

            _schedule.Burst = (int)BurstTxt.Value;
            _schedule.Interval = (int)IntervalTxt.Value;
            _schedule.Packet = new HMessage(PacketTxt.Text, ClientRdiBtn.Checked ? HDestination.Client : HDestination.Server);
            _scheduler.SetSelectedDescription(DescriptionTxt.Text);

            ListViewItem item = _scheduler.SelectedItems[0];
            item.SubItems[0].Text = PacketTxt.Text;
            item.SubItems[1].Text = _schedule.Packet.Destination.ToString();
            item.SubItems[2].Text = BurstTxt.Value.ToString();
            item.SubItems[3].Text = IntervalTxt.Value.ToString();
            item.SubItems[4].Text = _wasRunning ? "Running" : "Stopped";

            Close();
        }
        private void Destination_Changed(object sender, EventArgs e)
        {
            var rdiBtn = (RadioButton)sender;
            PacketTxt.ForeColor = (rdiBtn.Text == "Server" ? SystemColors.HotTrack : Color.Firebrick);
        }
        private void PacketTxt_TextChanged(object sender, EventArgs e)
        {
            if (PacketTxt.TextLength < 1) return;

            var packet = new HMessage(PacketTxt.Text);
            const string PacketInfoFormat = "Header: {0} | Length: {1} | Corrupted:";

            IsCorruptedLbl.Text = packet.IsCorrupted.ToString();
            PacketInfoLbl.Text = string.Format(PacketInfoFormat, packet.IsCorrupted ? 0 : packet.Header, packet.Length);

            IsCorruptedLbl.Location = new Point((PacketInfoLbl.Location.X + PacketInfoLbl.Width) - 5, IsCorruptedLbl.Location.Y);
            IsCorruptedLbl.ForeColor = packet.IsCorrupted ? Color.Firebrick : SystemColors.HotTrack;

            UpdateBtn.Enabled = !packet.IsCorrupted;
        }

        private void TanjiSchedulerEdit_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (_wasRunning)
                _schedule.Start();
        }
    }
}