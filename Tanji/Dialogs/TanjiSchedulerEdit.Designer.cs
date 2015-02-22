namespace Tanji.Dialogs
{
    partial class TanjiSchedulerEdit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TanjiSchedulerEdit));
            this.UpdateBtn = new Sulakore.Components.SKoreButton();
            this.IsCorruptedLbl = new System.Windows.Forms.Label();
            this.PacketInfoLbl = new System.Windows.Forms.Label();
            this.PacketTxt = new System.Windows.Forms.RichTextBox();
            this.ClientRdiBtn = new System.Windows.Forms.RadioButton();
            this.ServerRdiBtn = new System.Windows.Forms.RadioButton();
            this.DescriptionTxt = new System.Windows.Forms.TextBox();
            this.DescriptionLbl = new System.Windows.Forms.Label();
            this.IntervalLbl = new System.Windows.Forms.Label();
            this.IntervalTxt = new System.Windows.Forms.NumericUpDown();
            this.BurstLbl = new System.Windows.Forms.Label();
            this.BurstTxt = new System.Windows.Forms.NumericUpDown();
            this.BottomGlowPnl = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.IntervalTxt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BurstTxt)).BeginInit();
            this.SuspendLayout();
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.BackColor = System.Drawing.Color.Transparent;
            this.UpdateBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.UpdateBtn.Location = new System.Drawing.Point(270, 198);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(79, 23);
            this.UpdateBtn.Skin = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.UpdateBtn.TabIndex = 0;
            this.UpdateBtn.Text = "Update";
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // IsCorruptedLbl
            // 
            this.IsCorruptedLbl.AutoSize = true;
            this.IsCorruptedLbl.ForeColor = System.Drawing.Color.Firebrick;
            this.IsCorruptedLbl.Location = new System.Drawing.Point(171, 9);
            this.IsCorruptedLbl.Name = "IsCorruptedLbl";
            this.IsCorruptedLbl.Size = new System.Drawing.Size(29, 13);
            this.IsCorruptedLbl.TabIndex = 4;
            this.IsCorruptedLbl.Text = "True";
            // 
            // PacketInfoLbl
            // 
            this.PacketInfoLbl.AutoSize = true;
            this.PacketInfoLbl.Location = new System.Drawing.Point(12, 9);
            this.PacketInfoLbl.Name = "PacketInfoLbl";
            this.PacketInfoLbl.Size = new System.Drawing.Size(164, 13);
            this.PacketInfoLbl.TabIndex = 3;
            this.PacketInfoLbl.Text = "Header: 0 | Length: 0 | Corrupted:";
            // 
            // PacketTxt
            // 
            this.PacketTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.PacketTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PacketTxt.DetectUrls = false;
            this.PacketTxt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.PacketTxt.HideSelection = false;
            this.PacketTxt.Location = new System.Drawing.Point(12, 28);
            this.PacketTxt.Name = "PacketTxt";
            this.PacketTxt.Size = new System.Drawing.Size(337, 110);
            this.PacketTxt.TabIndex = 5;
            this.PacketTxt.Text = "";
            this.PacketTxt.TextChanged += new System.EventHandler(this.PacketTxt_TextChanged);
            // 
            // ClientRdiBtn
            // 
            this.ClientRdiBtn.AutoSize = true;
            this.ClientRdiBtn.Location = new System.Drawing.Point(236, 7);
            this.ClientRdiBtn.Name = "ClientRdiBtn";
            this.ClientRdiBtn.Size = new System.Drawing.Size(51, 17);
            this.ClientRdiBtn.TabIndex = 7;
            this.ClientRdiBtn.TabStop = true;
            this.ClientRdiBtn.Text = "Client";
            this.ClientRdiBtn.UseVisualStyleBackColor = true;
            this.ClientRdiBtn.CheckedChanged += new System.EventHandler(this.Destination_Changed);
            // 
            // ServerRdiBtn
            // 
            this.ServerRdiBtn.AutoSize = true;
            this.ServerRdiBtn.Location = new System.Drawing.Point(293, 7);
            this.ServerRdiBtn.Name = "ServerRdiBtn";
            this.ServerRdiBtn.Size = new System.Drawing.Size(56, 17);
            this.ServerRdiBtn.TabIndex = 8;
            this.ServerRdiBtn.TabStop = true;
            this.ServerRdiBtn.Text = "Server";
            this.ServerRdiBtn.UseVisualStyleBackColor = true;
            this.ServerRdiBtn.CheckedChanged += new System.EventHandler(this.Destination_Changed);
            // 
            // DescriptionTxt
            // 
            this.DescriptionTxt.Location = new System.Drawing.Point(15, 157);
            this.DescriptionTxt.Multiline = true;
            this.DescriptionTxt.Name = "DescriptionTxt";
            this.DescriptionTxt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DescriptionTxt.Size = new System.Drawing.Size(334, 35);
            this.DescriptionTxt.TabIndex = 9;
            // 
            // DescriptionLbl
            // 
            this.DescriptionLbl.AutoSize = true;
            this.DescriptionLbl.Location = new System.Drawing.Point(12, 141);
            this.DescriptionLbl.Name = "DescriptionLbl";
            this.DescriptionLbl.Size = new System.Drawing.Size(60, 13);
            this.DescriptionLbl.TabIndex = 10;
            this.DescriptionLbl.Text = "Description";
            // 
            // IntervalLbl
            // 
            this.IntervalLbl.AutoSize = true;
            this.IntervalLbl.Location = new System.Drawing.Point(12, 201);
            this.IntervalLbl.Name = "IntervalLbl";
            this.IntervalLbl.Size = new System.Drawing.Size(67, 13);
            this.IntervalLbl.TabIndex = 40;
            this.IntervalLbl.Text = "Interval (ms):";
            // 
            // IntervalTxt
            // 
            this.IntervalTxt.Location = new System.Drawing.Point(79, 199);
            this.IntervalTxt.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.IntervalTxt.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.IntervalTxt.Name = "IntervalTxt";
            this.IntervalTxt.Size = new System.Drawing.Size(70, 20);
            this.IntervalTxt.TabIndex = 39;
            this.IntervalTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.IntervalTxt.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // BurstLbl
            // 
            this.BurstLbl.AutoSize = true;
            this.BurstLbl.Location = new System.Drawing.Point(160, 201);
            this.BurstLbl.Name = "BurstLbl";
            this.BurstLbl.Size = new System.Drawing.Size(34, 13);
            this.BurstLbl.TabIndex = 42;
            this.BurstLbl.Text = "Burst:";
            // 
            // BurstTxt
            // 
            this.BurstTxt.Location = new System.Drawing.Point(194, 199);
            this.BurstTxt.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.BurstTxt.Name = "BurstTxt";
            this.BurstTxt.Size = new System.Drawing.Size(70, 20);
            this.BurstTxt.TabIndex = 41;
            this.BurstTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BurstTxt.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // BottomGlowPnl
            // 
            this.BottomGlowPnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.BottomGlowPnl.Location = new System.Drawing.Point(156, 198);
            this.BottomGlowPnl.Name = "BottomGlowPnl";
            this.BottomGlowPnl.Size = new System.Drawing.Size(1, 21);
            this.BottomGlowPnl.TabIndex = 43;
            // 
            // TanjiSchedulerEdit
            // 
            this.AcceptButton = this.UpdateBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(361, 233);
            this.Controls.Add(this.BottomGlowPnl);
            this.Controls.Add(this.IntervalLbl);
            this.Controls.Add(this.BurstLbl);
            this.Controls.Add(this.BurstTxt);
            this.Controls.Add(this.IntervalTxt);
            this.Controls.Add(this.DescriptionLbl);
            this.Controls.Add(this.DescriptionTxt);
            this.Controls.Add(this.ServerRdiBtn);
            this.Controls.Add(this.ClientRdiBtn);
            this.Controls.Add(this.PacketTxt);
            this.Controls.Add(this.IsCorruptedLbl);
            this.Controls.Add(this.PacketInfoLbl);
            this.Controls.Add(this.UpdateBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TanjiSchedulerEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tanji ~ Schedule Edit";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TanjiSchedulerEdit_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.IntervalTxt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BurstTxt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Sulakore.Components.SKoreButton UpdateBtn;
        private System.Windows.Forms.Label IsCorruptedLbl;
        private System.Windows.Forms.Label PacketInfoLbl;
        private System.Windows.Forms.RichTextBox PacketTxt;
        private System.Windows.Forms.RadioButton ClientRdiBtn;
        private System.Windows.Forms.RadioButton ServerRdiBtn;
        private System.Windows.Forms.TextBox DescriptionTxt;
        private System.Windows.Forms.Label DescriptionLbl;
        private System.Windows.Forms.Label IntervalLbl;
        private System.Windows.Forms.NumericUpDown IntervalTxt;
        private System.Windows.Forms.Label BurstLbl;
        private System.Windows.Forms.NumericUpDown BurstTxt;
        private System.Windows.Forms.Panel BottomGlowPnl;
    }
}