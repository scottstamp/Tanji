namespace Tanji.Dialogs
{
    partial class TanjiConstructerEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TanjiConstructerEdit));
            this.ValueTxt = new System.Windows.Forms.TextBox();
            this.TypeTxt = new System.Windows.Forms.ComboBox();
            this.UpdateBtn = new Sulakore.Components.SKoreButton();
            this.SuspendLayout();
            // 
            // ValueTxt
            // 
            this.ValueTxt.Location = new System.Drawing.Point(102, 13);
            this.ValueTxt.Name = "ValueTxt";
            this.ValueTxt.Size = new System.Drawing.Size(157, 20);
            this.ValueTxt.TabIndex = 7;
            // 
            // TypeTxt
            // 
            this.TypeTxt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TypeTxt.FormattingEnabled = true;
            this.TypeTxt.Items.AddRange(new object[] {
            "String",
            "Integer",
            "Boolean"});
            this.TypeTxt.Location = new System.Drawing.Point(12, 13);
            this.TypeTxt.Name = "TypeTxt";
            this.TypeTxt.Size = new System.Drawing.Size(84, 21);
            this.TypeTxt.TabIndex = 6;
            this.TypeTxt.TabStop = false;
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.BackColor = System.Drawing.Color.Transparent;
            this.UpdateBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.UpdateBtn.Location = new System.Drawing.Point(265, 11);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(79, 23);
            this.UpdateBtn.Skin = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.UpdateBtn.TabIndex = 5;
            this.UpdateBtn.TabStop = false;
            this.UpdateBtn.Text = "Update";
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // TanjiConstructerEdit
            // 
            this.AcceptButton = this.UpdateBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(356, 45);
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.ValueTxt);
            this.Controls.Add(this.TypeTxt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TanjiConstructerEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tanji ~ Construct Edit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Sulakore.Components.SKoreButton UpdateBtn;
        private System.Windows.Forms.TextBox ValueTxt;
        private System.Windows.Forms.ComboBox TypeTxt;
    }
}