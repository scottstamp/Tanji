namespace Tanji.Dialogs
{
    partial class TanjiConnect
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TanjiConnect));
            this.MiddleGlowPnl = new System.Windows.Forms.Panel();
            this.ChooseClientDlg = new System.Windows.Forms.OpenFileDialog();
            this.GameHostLbl = new System.Windows.Forms.Label();
            this.GamePortLbl = new System.Windows.Forms.Label();
            this.TopGlowPnl = new System.Windows.Forms.Panel();
            this.ExponentTxt = new System.Windows.Forms.TextBox();
            this.ExponentGrpbx = new System.Windows.Forms.GroupBox();
            this.CustomClientTxt = new System.Windows.Forms.TextBox();
            this.FiddlerCoreGrpbx = new System.Windows.Forms.GroupBox();
            this.BrowseBtn = new Sulakore.Components.SKoreButton();
            this.ModulusTxt = new System.Windows.Forms.TextBox();
            this.ModulusGrpbx = new System.Windows.Forms.GroupBox();
            this.GameHostTxt = new System.Windows.Forms.ComboBox();
            this.GamePortTxt = new System.Windows.Forms.ComboBox();
            this.ConnectBtn = new Sulakore.Components.SKoreButton();
            this.StatusTxt = new Sulakore.Components.SKoreLabel();
            this.TanjiMode = new Tanji.Components.TanjiModePanel();
            this.ExponentGrpbx.SuspendLayout();
            this.FiddlerCoreGrpbx.SuspendLayout();
            this.ModulusGrpbx.SuspendLayout();
            this.SuspendLayout();
            // 
            // MiddleGlowPnl
            // 
            this.MiddleGlowPnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.MiddleGlowPnl.Location = new System.Drawing.Point(0, 192);
            this.MiddleGlowPnl.Name = "MiddleGlowPnl";
            this.MiddleGlowPnl.Size = new System.Drawing.Size(330, 1);
            this.MiddleGlowPnl.TabIndex = 41;
            // 
            // ChooseClientDlg
            // 
            this.ChooseClientDlg.DefaultExt = "swf";
            this.ChooseClientDlg.Filter = "Macromedia Flash file (*.swf)|*.swf";
            this.ChooseClientDlg.Title = "Tanji ~ Choose Custom Client";
            // 
            // GameHostLbl
            // 
            this.GameHostLbl.AutoSize = true;
            this.GameHostLbl.Location = new System.Drawing.Point(9, 41);
            this.GameHostLbl.Name = "GameHostLbl";
            this.GameHostLbl.Size = new System.Drawing.Size(60, 13);
            this.GameHostLbl.TabIndex = 49;
            this.GameHostLbl.Text = "Game Host";
            // 
            // GamePortLbl
            // 
            this.GamePortLbl.AutoSize = true;
            this.GamePortLbl.Location = new System.Drawing.Point(165, 41);
            this.GamePortLbl.Name = "GamePortLbl";
            this.GamePortLbl.Size = new System.Drawing.Size(57, 13);
            this.GamePortLbl.TabIndex = 51;
            this.GamePortLbl.Text = "Game Port";
            // 
            // TopGlowPnl
            // 
            this.TopGlowPnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.TopGlowPnl.Location = new System.Drawing.Point(0, 83);
            this.TopGlowPnl.Name = "TopGlowPnl";
            this.TopGlowPnl.Size = new System.Drawing.Size(330, 1);
            this.TopGlowPnl.TabIndex = 48;
            // 
            // ExponentTxt
            // 
            this.ExponentTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ExponentTxt.Location = new System.Drawing.Point(6, 19);
            this.ExponentTxt.Name = "ExponentTxt";
            this.ExponentTxt.Size = new System.Drawing.Size(77, 20);
            this.ExponentTxt.TabIndex = 0;
            this.ExponentTxt.TabStop = false;
            this.ExponentTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ExponentGrpbx
            // 
            this.ExponentGrpbx.Controls.Add(this.ExponentTxt);
            this.ExponentGrpbx.Location = new System.Drawing.Point(12, 90);
            this.ExponentGrpbx.Name = "ExponentGrpbx";
            this.ExponentGrpbx.Size = new System.Drawing.Size(89, 45);
            this.ExponentGrpbx.TabIndex = 52;
            this.ExponentGrpbx.TabStop = false;
            this.ExponentGrpbx.Text = "Exponent ( e )";
            // 
            // CustomClientTxt
            // 
            this.CustomClientTxt.Location = new System.Drawing.Point(6, 17);
            this.CustomClientTxt.Name = "CustomClientTxt";
            this.CustomClientTxt.Size = new System.Drawing.Size(220, 20);
            this.CustomClientTxt.TabIndex = 0;
            this.CustomClientTxt.TabStop = false;
            // 
            // FiddlerCoreGrpbx
            // 
            this.FiddlerCoreGrpbx.Controls.Add(this.BrowseBtn);
            this.FiddlerCoreGrpbx.Controls.Add(this.CustomClientTxt);
            this.FiddlerCoreGrpbx.Location = new System.Drawing.Point(12, 141);
            this.FiddlerCoreGrpbx.Name = "FiddlerCoreGrpbx";
            this.FiddlerCoreGrpbx.Size = new System.Drawing.Size(306, 45);
            this.FiddlerCoreGrpbx.TabIndex = 54;
            this.FiddlerCoreGrpbx.TabStop = false;
            this.FiddlerCoreGrpbx.Text = "Custom Game Client";
            // 
            // BrowseBtn
            // 
            this.BrowseBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BrowseBtn.BackColor = System.Drawing.Color.Transparent;
            this.BrowseBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BrowseBtn.Location = new System.Drawing.Point(232, 17);
            this.BrowseBtn.Name = "BrowseBtn";
            this.BrowseBtn.Size = new System.Drawing.Size(68, 20);
            this.BrowseBtn.Skin = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.BrowseBtn.TabIndex = 2;
            this.BrowseBtn.TabStop = false;
            this.BrowseBtn.Text = "Browse";
            this.BrowseBtn.Click += new System.EventHandler(this.BrowseBtn_Click);
            // 
            // ModulusTxt
            // 
            this.ModulusTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ModulusTxt.Location = new System.Drawing.Point(6, 19);
            this.ModulusTxt.Name = "ModulusTxt";
            this.ModulusTxt.Size = new System.Drawing.Size(199, 20);
            this.ModulusTxt.TabIndex = 0;
            this.ModulusTxt.TabStop = false;
            this.ModulusTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ModulusGrpbx
            // 
            this.ModulusGrpbx.Controls.Add(this.ModulusTxt);
            this.ModulusGrpbx.Location = new System.Drawing.Point(107, 90);
            this.ModulusGrpbx.Name = "ModulusGrpbx";
            this.ModulusGrpbx.Size = new System.Drawing.Size(211, 45);
            this.ModulusGrpbx.TabIndex = 53;
            this.ModulusGrpbx.TabStop = false;
            this.ModulusGrpbx.Text = "Modulus ( n )";
            // 
            // GameHostTxt
            // 
            this.GameHostTxt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.GameHostTxt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.GameHostTxt.FormattingEnabled = true;
            this.GameHostTxt.Items.AddRange(new object[] {
            "game-us.habbo.com",
            "game-br.habbo.com",
            "game-tr.habbo.com",
            "game-de.habbo.com",
            "game-dk.habbo.com",
            "game-es.habbo.com",
            "game-fi.habbo.com",
            "game-fr.habbo.com",
            "game-it.habbo.com",
            "game-nl.habbo.com",
            "game-no.habbo.com",
            "game-se.habbo.com"});
            this.GameHostTxt.Location = new System.Drawing.Point(12, 56);
            this.GameHostTxt.Name = "GameHostTxt";
            this.GameHostTxt.Size = new System.Drawing.Size(150, 21);
            this.GameHostTxt.TabIndex = 60;
            // 
            // GamePortTxt
            // 
            this.GamePortTxt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.GamePortTxt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.GamePortTxt.FormattingEnabled = true;
            this.GamePortTxt.Items.AddRange(new object[] {
            "38101",
            "30000"});
            this.GamePortTxt.Location = new System.Drawing.Point(168, 56);
            this.GamePortTxt.Name = "GamePortTxt";
            this.GamePortTxt.Size = new System.Drawing.Size(150, 21);
            this.GamePortTxt.TabIndex = 61;
            // 
            // ConnectBtn
            // 
            this.ConnectBtn.BackColor = System.Drawing.Color.Transparent;
            this.ConnectBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.ConnectBtn.Location = new System.Drawing.Point(225, 202);
            this.ConnectBtn.Name = "ConnectBtn";
            this.ConnectBtn.Size = new System.Drawing.Size(93, 23);
            this.ConnectBtn.Skin = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.ConnectBtn.TabIndex = 57;
            this.ConnectBtn.TabStop = false;
            this.ConnectBtn.Text = "Connect";
            this.ConnectBtn.Click += new System.EventHandler(this.ConnectBtn_Click);
            // 
            // StatusTxt
            // 
            this.StatusTxt.DisplayBoundary = true;
            this.StatusTxt.Location = new System.Drawing.Point(12, 202);
            this.StatusTxt.Name = "StatusTxt";
            this.StatusTxt.Size = new System.Drawing.Size(207, 23);
            this.StatusTxt.Skin = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.StatusTxt.TabIndex = 62;
            this.StatusTxt.Text = "Standing By...";
            this.StatusTxt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TanjiMode
            // 
            this.TanjiMode.Dock = System.Windows.Forms.DockStyle.Top;
            this.TanjiMode.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.TanjiMode.Location = new System.Drawing.Point(0, 0);
            this.TanjiMode.Name = "TanjiMode";
            this.TanjiMode.Size = new System.Drawing.Size(330, 33);
            this.TanjiMode.TabIndex = 64;
            this.TanjiMode.ModeChanged += new System.EventHandler(this.TanjiMode_ModeChanged);
            // 
            // TanjiConnect
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(330, 234);
            this.Controls.Add(this.FiddlerCoreGrpbx);
            this.Controls.Add(this.TanjiMode);
            this.Controls.Add(this.StatusTxt);
            this.Controls.Add(this.GamePortTxt);
            this.Controls.Add(this.GameHostTxt);
            this.Controls.Add(this.ConnectBtn);
            this.Controls.Add(this.MiddleGlowPnl);
            this.Controls.Add(this.ModulusGrpbx);
            this.Controls.Add(this.GamePortLbl);
            this.Controls.Add(this.ExponentGrpbx);
            this.Controls.Add(this.GameHostLbl);
            this.Controls.Add(this.TopGlowPnl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TanjiConnect";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tanji ~ Connection Setup [Automatic]";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TanjiConnect_FormClosing);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.TanjiConnect_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.TanjiConnect_DragEnter);
            this.ExponentGrpbx.ResumeLayout(false);
            this.ExponentGrpbx.PerformLayout();
            this.FiddlerCoreGrpbx.ResumeLayout(false);
            this.FiddlerCoreGrpbx.PerformLayout();
            this.ModulusGrpbx.ResumeLayout(false);
            this.ModulusGrpbx.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel MiddleGlowPnl;
        private System.Windows.Forms.OpenFileDialog ChooseClientDlg;
        private Sulakore.Components.SKoreButton ConnectBtn;
        private System.Windows.Forms.Label GameHostLbl;
        private System.Windows.Forms.Label GamePortLbl;
        private System.Windows.Forms.Panel TopGlowPnl;
        private System.Windows.Forms.GroupBox ExponentGrpbx;
        private System.Windows.Forms.TextBox CustomClientTxt;
        private Sulakore.Components.SKoreButton BrowseBtn;
        private System.Windows.Forms.GroupBox FiddlerCoreGrpbx;
        private System.Windows.Forms.GroupBox ModulusGrpbx;
        private System.Windows.Forms.ComboBox GameHostTxt;
        private System.Windows.Forms.ComboBox GamePortTxt;
        public System.Windows.Forms.TextBox ExponentTxt;
        public System.Windows.Forms.TextBox ModulusTxt;
        private Sulakore.Components.SKoreLabel StatusTxt;
        private Components.TanjiModePanel TanjiMode;
    }
}