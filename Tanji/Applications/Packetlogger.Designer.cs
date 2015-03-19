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
            this.ViewOutgoingBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.ViewIncomingBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.OptionsSep = new System.Windows.Forms.ToolStripSeparator();
            this.EmptyLogBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.SettingsBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.DisplaySplitterBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.SettingsSeperator = new System.Windows.Forms.ToolStripSeparator();
            this.AlwaysOnTopBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.PacketloggerStrip = new System.Windows.Forms.StatusStrip();
            this.CaptureIncomingLbl = new System.Windows.Forms.ToolStripStatusLabel();
            this.CaptureOutgoingLbl = new System.Windows.Forms.ToolStripStatusLabel();
            this.DisplayBlockedLbl = new System.Windows.Forms.ToolStripStatusLabel();
            this.DisplayReplacedLbl = new System.Windows.Forms.ToolStripStatusLabel();
            this.DisplayFiltersBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.BlockedBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.ReplacedBtn = new System.Windows.Forms.ToolStripMenuItem();
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
            this.LoggerTxt.ForeColor = System.Drawing.Color.White;
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
            this.ViewOutgoingBtn,
            this.ViewIncomingBtn,
            this.OptionsSep,
            this.EmptyLogBtn});
            this.OptionsBtn.Name = "OptionsBtn";
            this.OptionsBtn.Size = new System.Drawing.Size(61, 20);
            this.OptionsBtn.Text = "Options";
            // 
            // ViewOutgoingBtn
            // 
            this.ViewOutgoingBtn.Checked = true;
            this.ViewOutgoingBtn.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ViewOutgoingBtn.Name = "ViewOutgoingBtn";
            this.ViewOutgoingBtn.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.ViewOutgoingBtn.Size = new System.Drawing.Size(196, 22);
            this.ViewOutgoingBtn.Text = "View Outgoing";
            this.ViewOutgoingBtn.Click += new System.EventHandler(this.ItemClicked);
            // 
            // ViewIncomingBtn
            // 
            this.ViewIncomingBtn.Checked = true;
            this.ViewIncomingBtn.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ViewIncomingBtn.Name = "ViewIncomingBtn";
            this.ViewIncomingBtn.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this.ViewIncomingBtn.Size = new System.Drawing.Size(196, 22);
            this.ViewIncomingBtn.Text = "View Incoming";
            this.ViewIncomingBtn.Click += new System.EventHandler(this.ItemClicked);
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
            this.DisplayFiltersBtn,
            this.DisplaySplitterBtn,
            this.SettingsSeperator,
            this.AlwaysOnTopBtn});
            this.SettingsBtn.Name = "SettingsBtn";
            this.SettingsBtn.Size = new System.Drawing.Size(61, 20);
            this.SettingsBtn.Text = "Settings";
            // 
            // DisplaySplitterBtn
            // 
            this.DisplaySplitterBtn.Checked = true;
            this.DisplaySplitterBtn.CheckState = System.Windows.Forms.CheckState.Checked;
            this.DisplaySplitterBtn.Name = "DisplaySplitterBtn";
            this.DisplaySplitterBtn.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.DisplaySplitterBtn.Size = new System.Drawing.Size(195, 22);
            this.DisplaySplitterBtn.Text = "Display Splitter";
            this.DisplaySplitterBtn.Click += new System.EventHandler(this.ItemClicked);
            // 
            // SettingsSeperator
            // 
            this.SettingsSeperator.Name = "SettingsSeperator";
            this.SettingsSeperator.Size = new System.Drawing.Size(192, 6);
            // 
            // AlwaysOnTopBtn
            // 
            this.AlwaysOnTopBtn.CheckOnClick = true;
            this.AlwaysOnTopBtn.Name = "AlwaysOnTopBtn";
            this.AlwaysOnTopBtn.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
            this.AlwaysOnTopBtn.Size = new System.Drawing.Size(195, 22);
            this.AlwaysOnTopBtn.Text = "Always On Top";
            this.AlwaysOnTopBtn.Click += new System.EventHandler(this.AlwaysOnTopBtn_Click);
            // 
            // PacketloggerStrip
            // 
            this.PacketloggerStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CaptureOutgoingLbl,
            this.CaptureIncomingLbl,
            this.DisplayBlockedLbl,
            this.DisplayReplacedLbl});
            this.PacketloggerStrip.Location = new System.Drawing.Point(0, 501);
            this.PacketloggerStrip.Name = "PacketloggerStrip";
            this.PacketloggerStrip.Size = new System.Drawing.Size(714, 24);
            this.PacketloggerStrip.TabIndex = 6;
            // 
            // CaptureIncomingLbl
            // 
            this.CaptureIncomingLbl.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.CaptureIncomingLbl.Name = "CaptureIncomingLbl";
            this.CaptureIncomingLbl.Size = new System.Drawing.Size(137, 19);
            this.CaptureIncomingLbl.Text = "Capture Incoming: True";
            // 
            // CaptureOutgoingLbl
            // 
            this.CaptureOutgoingLbl.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.CaptureOutgoingLbl.Name = "CaptureOutgoingLbl";
            this.CaptureOutgoingLbl.Size = new System.Drawing.Size(137, 19);
            this.CaptureOutgoingLbl.Text = "Capture Outgoing: True";
            // 
            // DisplayBlockedLbl
            // 
            this.DisplayBlockedLbl.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.DisplayBlockedLbl.Name = "DisplayBlockedLbl";
            this.DisplayBlockedLbl.Size = new System.Drawing.Size(124, 19);
            this.DisplayBlockedLbl.Text = "Display Blocked: True";
            // 
            // DisplayReplacedLbl
            // 
            this.DisplayReplacedLbl.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.DisplayReplacedLbl.Name = "DisplayReplacedLbl";
            this.DisplayReplacedLbl.Size = new System.Drawing.Size(130, 19);
            this.DisplayReplacedLbl.Text = "Display Replaced: True";
            // 
            // DisplayFiltersBtn
            // 
            this.DisplayFiltersBtn.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BlockedBtn,
            this.ReplacedBtn});
            this.DisplayFiltersBtn.Name = "DisplayFiltersBtn";
            this.DisplayFiltersBtn.Size = new System.Drawing.Size(195, 22);
            this.DisplayFiltersBtn.Text = "Display Filters";
            // 
            // BlockedBtn
            // 
            this.BlockedBtn.Checked = true;
            this.BlockedBtn.CheckState = System.Windows.Forms.CheckState.Checked;
            this.BlockedBtn.Name = "BlockedBtn";
            this.BlockedBtn.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.BlockedBtn.Size = new System.Drawing.Size(163, 22);
            this.BlockedBtn.Text = "Blocked";
            this.BlockedBtn.Click += new System.EventHandler(this.ItemClicked);
            // 
            // ReplacedBtn
            // 
            this.ReplacedBtn.Checked = true;
            this.ReplacedBtn.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ReplacedBtn.Name = "ReplacedBtn";
            this.ReplacedBtn.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.ReplacedBtn.Size = new System.Drawing.Size(163, 22);
            this.ReplacedBtn.Text = "Replaced";
            this.ReplacedBtn.Click += new System.EventHandler(this.ItemClicked);
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
            this.MinimumSize = new System.Drawing.Size(591, 455);
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
        private System.Windows.Forms.ToolStripMenuItem ViewOutgoingBtn;
        private System.Windows.Forms.ToolStripMenuItem ViewIncomingBtn;
        private System.Windows.Forms.ToolStripSeparator OptionsSep;
        private System.Windows.Forms.ToolStripMenuItem EmptyLogBtn;
        private System.Windows.Forms.ToolStripMenuItem SettingsBtn;
        private System.Windows.Forms.ToolStripMenuItem DisplaySplitterBtn;
        private System.Windows.Forms.StatusStrip PacketloggerStrip;
        private System.Windows.Forms.ToolStripStatusLabel CaptureIncomingLbl;
        private System.Windows.Forms.ToolStripStatusLabel CaptureOutgoingLbl;
        private System.Windows.Forms.ContextMenuStrip LoggerMenu;
        private System.Windows.Forms.ToolStripMenuItem CopyBtn;
        private System.Windows.Forms.ToolStripSeparator SettingsSeperator;
        private System.Windows.Forms.ToolStripMenuItem AlwaysOnTopBtn;
        private System.Windows.Forms.ToolStripStatusLabel DisplayBlockedLbl;
        private System.Windows.Forms.ToolStripStatusLabel DisplayReplacedLbl;
        private System.Windows.Forms.ToolStripMenuItem DisplayFiltersBtn;
        private System.Windows.Forms.ToolStripMenuItem BlockedBtn;
        private System.Windows.Forms.ToolStripMenuItem ReplacedBtn;
    }
}