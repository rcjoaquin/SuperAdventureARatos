namespace SuperAdventure
{
    partial class frmQuest
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
            this.lbQuests = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lbQuests
            // 
            this.lbQuests.FormattingEnabled = true;
            this.lbQuests.Location = new System.Drawing.Point(12, 12);
            this.lbQuests.Name = "lbQuests";
            this.lbQuests.Size = new System.Drawing.Size(143, 238);
            this.lbQuests.TabIndex = 2;
            // 
            // frmQuest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(173, 261);
            this.Controls.Add(this.lbQuests);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmQuest";
            this.Text = "Quests";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbQuests;
    }
}