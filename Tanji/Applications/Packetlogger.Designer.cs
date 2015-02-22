namespace Tanji.Applications
{
    partial class Packetlogger
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Packetlogger));
            this.LoggerTxt = new System.Windows.Forms.RichTextBox();
            this.LoggerMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.CopyBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.PacketloggerMenu = new System.Windows.Forms.MenuStrip();
            this.OptionsBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.ToggleOutgoingBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.ToggleIncomingBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.OptionsSep = new System.Windows.Forms.ToolStripSeparator();
            this.EmptyLogBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.SettingsBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.DisplayVisualSplitBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.SettingsSeperator = new System.Windows.Forms.ToolStripSeparator();
            this.TopMostBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.PacketloggerStrip = new System.Windows.Forms.StatusStrip();
            this.CapturingINLbl = new System.Windows.Forms.ToolStripStatusLabel();
            this.CapturingOUTLbl = new System.Windows.Forms.ToolStripStatusLabel();
            this.LoggerMenu.SuspendLayout();
            this.PacketloggerMenu.SuspendLayout();
            this.PacketloggerStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // LoggerTxt
            // 
            this.LoggerTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.LoggerTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LoggerTxt.ContextMenuStrip = this.LoggerMenu;
            this.LoggerTxt.DetectUrls = false;
            this.LoggerTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LoggerTxt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LoggerTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.LoggerTxt.HideSelection = false;
            this.LoggerTxt.Location = new System.Drawing.Point(0, 24);
            this.LoggerTxt.Name = "LoggerTxt";
            this.LoggerTxt.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.LoggerTxt.ShowSelectionMargin = true;
            this.LoggerTxt.Size = new System.Drawing.Size(714, 477);
            this.LoggerTxt.TabIndex = 0;
            this.LoggerTxt.Text = "";
            // 
            // LoggerMenu
            // 
            this.LoggerMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CopyBtn});
            this.LoggerMenu.Name = "LoggerMenu";
            this.LoggerMenu.Size = new System.Drawing.Size(103, 26);
            // 
            // CopyBtn
            // 
            this.CopyBtn.Name = "CopyBtn";
            this.CopyBtn.Size = new System.Drawing.Size(102, 22);
            this.CopyBtn.Text = "Copy";
            this.CopyBtn.Click += new System.EventHandler(this.CopyBtn_Click);
            // 
            // PacketloggerMenu
            // 
            this.PacketloggerMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OptionsBtn,
            this.SettingsBtn});
            this.PacketloggerMenu.Location = new System.Drawing.Point(0, 0);
            this.PacketloggerMenu.Name = "PacketloggerMenu";
            this.PacketloggerMenu.Size = new System.Drawing.Size(714, 24);
            this.PacketloggerMenu.TabIndex = 6;
            this.PacketloggerMenu.Text = "menuStrip1";
            // 
            // OptionsBtn
            // 
            this.OptionsBtn.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToggleOutgoingBtn,
            this.ToggleIncomingBtn,
            this.OptionsSep,
            this.EmptyLogBtn});
            this.OptionsBtn.Name = "OptionsBtn";
            this.OptionsBtn.Size = new System.Drawing.Size(61, 20);
            this.OptionsBtn.Text = "Options";
            // 
            // ToggleOutgoingBtn
            // 
            this.ToggleOutgoingBtn.Checked = true;
            this.ToggleOutgoingBtn.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ToggleOutgoingBtn.Name = "ToggleOutgoingBtn";
            this.ToggleOutgoingBtn.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.ToggleOutgoingBtn.Size = new System.Drawing.Size(196, 22);
            this.ToggleOutgoingBtn.Text = "View Outgoing";
            this.ToggleOutgoingBtn.Click += new System.EventHandler(this.ItemClicked);
            // 
            // ToggleIncomingBtn
            // 
            this.ToggleIncomingBtn.Checked = true;
            this.ToggleIncomingBtn.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ToggleIncomingBtn.Name = "ToggleIncomingBtn";
            this.ToggleIncomingBtn.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this.ToggleIncomingBtn.Size = new System.Drawing.Size(196, 22);
            this.ToggleIncomingBtn.Text = "View Incoming";
            this.ToggleIncomingBtn.Click += new System.EventHandler(this.ItemClicked);
            // 
            // OptionsSep
            // 
            this.OptionsSep.Name = "OptionsSep";
            this.OptionsSep.Size = new System.Drawing.Size(193, 6);
            // 
            // EmptyLogBtn
            // 
            this.EmptyLogBtn.Name = "EmptyLogBtn";
            this.EmptyLogBtn.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.EmptyLogBtn.Size = new System.Drawing.Size(196, 22);
            this.EmptyLogBtn.Text = "Empty Log";
            this.EmptyLogBtn.Click += new System.EventHandler(this.EmptyLogBtn_Click);
            // 
            // SettingsBtn
            // 
            this.SettingsBtn.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DisplayVisualSplitBtn,
            this.SettingsSeperator,
            this.TopMostBtn});
            this.SettingsBtn.Name = "SettingsBtn";
            this.SettingsBtn.Size = new System.Drawing.Size(61, 20);
            this.SettingsBtn.Text = "Settings";
            // 
            // DisplayVisualSplitBtn
            // 
            this.DisplayVisualSplitBtn.Checked = true;
            this.DisplayVisualSplitBtn.CheckState = System.Windows.Forms.CheckState.Checked;
            this.DisplayVisualSplitBtn.Name = "DisplayVisualSplitBtn";
            this.DisplayVisualSplitBtn.Size = new System.Drawing.Size(172, 22);
            this.DisplayVisualSplitBtn.Text = "Display Visual Split";
            this.DisplayVisualSplitBtn.Click += new System.EventHandler(this.ItemClicked);
            // 
            // SettingsSeperator
            // 
            this.SettingsSeperator.Name = "SettingsSeperator";
            this.SettingsSeperator.Size = new System.Drawing.Size(169, 6);
            // 
            // TopMostBtn
            // 
            this.TopMostBtn.CheckOnClick = true;
            this.TopMostBtn.Name = "TopMostBtn";
            this.TopMostBtn.Size = new System.Drawing.Size(172, 22);
            this.TopMostBtn.Text = "Always On Top";
            this.TopMostBtn.Click += new System.EventHandler(this.TopMostBtn_Click);
            // 
            // PacketloggerStrip
            // 
            this.PacketloggerStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CapturingINLbl,
            this.CapturingOUTLbl});
            this.PacketloggerStrip.Location = new System.Drawing.Point(0, 501);
            this.PacketloggerStrip.Name = "PacketloggerStrip";
            this.PacketloggerStrip.Size = new System.Drawing.Size(714, 24);
            this.PacketloggerStrip.TabIndex = 6;
            // 
            // CapturingINLbl
            // 
            this.CapturingINLbl.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.CapturingINLbl.Name = "CapturingINLbl";
            this.CapturingINLbl.Size = new System.Drawing.Size(148, 19);
            this.CapturingINLbl.Text = "Capturing Incoming: True";
            // 
            // CapturingOUTLbl
            // 
            this.CapturingOUTLbl.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.CapturingOUTLbl.Name = "CapturingOUTLbl";
            this.CapturingOUTLbl.Size = new System.Drawing.Size(148, 19);
            this.CapturingOUTLbl.Text = "Capturing Outgoing: True";
            // 
            // Packetlogger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 525);
            this.Controls.Add(this.LoggerTxt);
            this.Controls.Add(this.PacketloggerStrip);
            this.Controls.Add(this.PacketloggerMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(434, 298);
            this.Name = "Packetlogger";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tanji ~ Packetlogger";
            this.Activated += new System.EventHandler(this.Packetlogger_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Packetlogger_FormClosing);
            this.LoggerMenu.ResumeLayout(false);
            this.PacketloggerMenu.ResumeLayout(false);
            this.PacketloggerMenu.PerformLayout();
            this.PacketloggerStrip.ResumeLayout(false);
            this.PacketloggerStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox LoggerTxt;
        private System.Windows.Forms.MenuStrip PacketloggerMenu;
        private System.Windows.Forms.ToolStripMenuItem OptionsBtn;
        private System.Windows.Forms.ToolStripMenuItem ToggleOutgoingBtn;
        private System.Windows.Forms.ToolStripMenuItem ToggleIncomingBtn;
        private System.Windows.Forms.ToolStripSeparator OptionsSep;
        private System.Windows.Forms.ToolStripMenuItem EmptyLogBtn;
        private System.Windows.Forms.ToolStripMenuItem SettingsBtn;
        private System.Windows.Forms.ToolStripMenuItem DisplayVisualSplitBtn;
        private System.Windows.Forms.StatusStrip PacketloggerStrip;
        private System.Windows.Forms.ToolStripStatusLabel CapturingINLbl;
        private System.Windows.Forms.ToolStripStatusLabel CapturingOUTLbl;
        private System.Windows.Forms.ContextMenuStrip LoggerMenu;
        private System.Windows.Forms.ToolStripMenuItem CopyBtn;
        private System.Windows.Forms.ToolStripSeparator SettingsSeperator;
        private System.Windows.Forms.ToolStripMenuItem TopMostBtn;
    }
}