namespace Tanji.Dialogs
{
    partial class TanjiUpdater
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TanjiUpdater));
            this.InfoLbl = new System.Windows.Forms.Label();
            this.DetailsBtn = new Sulakore.Components.SKoreButton();
            this.YesBtn = new Sulakore.Components.SKoreButton();
            this.NoBtn = new Sulakore.Components.SKoreButton();
            this.SuspendLayout();
            // 
            // InfoLbl
            // 
            this.InfoLbl.Dock = System.Windows.Forms.DockStyle.Top;
            this.InfoLbl.Location = new System.Drawing.Point(0, 0);
            this.InfoLbl.Name = "InfoLbl";
            this.InfoLbl.Size = new System.Drawing.Size(329, 51);
            this.InfoLbl.TabIndex = 2;
            this.InfoLbl.Text = "An update for Tanji has been found!; Would you like to download this newer spiffy" +
    " version to your desktop?";
            this.InfoLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DetailsBtn
            // 
            this.DetailsBtn.BackColor = System.Drawing.Color.Transparent;
            this.DetailsBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.DetailsBtn.Location = new System.Drawing.Point(12, 54);
            this.DetailsBtn.Name = "DetailsBtn";
            this.DetailsBtn.Size = new System.Drawing.Size(80, 23);
            this.DetailsBtn.Skin = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.DetailsBtn.TabIndex = 3;
            this.DetailsBtn.Text = "Details";
            this.DetailsBtn.Click += new System.EventHandler(this.DetailsBtn_Click);
            // 
            // YesBtn
            // 
            this.YesBtn.BackColor = System.Drawing.Color.Transparent;
            this.YesBtn.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.YesBtn.Location = new System.Drawing.Point(181, 54);
            this.YesBtn.Name = "YesBtn";
            this.YesBtn.Size = new System.Drawing.Size(65, 23);
            this.YesBtn.Skin = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.YesBtn.TabIndex = 4;
            this.YesBtn.Text = "Yes";
            this.YesBtn.Click += new System.EventHandler(this.YesBtn_Click);
            // 
            // NoBtn
            // 
            this.NoBtn.BackColor = System.Drawing.Color.Transparent;
            this.NoBtn.DialogResult = System.Windows.Forms.DialogResult.No;
            this.NoBtn.Location = new System.Drawing.Point(252, 54);
            this.NoBtn.Name = "NoBtn";
            this.NoBtn.Size = new System.Drawing.Size(65, 23);
            this.NoBtn.Skin = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.NoBtn.TabIndex = 5;
            this.NoBtn.Text = "No";
            this.NoBtn.Click += new System.EventHandler(this.NoBtn_Click);
            // 
            // TanjiUpdater
            // 
            this.AcceptButton = this.YesBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(329, 87);
            this.Controls.Add(this.NoBtn);
            this.Controls.Add(this.YesBtn);
            this.Controls.Add(this.DetailsBtn);
            this.Controls.Add(this.InfoLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TanjiUpdater";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tanji ~ Update Found!";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label InfoLbl;
        private Sulakore.Components.SKoreButton DetailsBtn;
        private Sulakore.Components.SKoreButton YesBtn;
        private Sulakore.Components.SKoreButton NoBtn;
    }
}