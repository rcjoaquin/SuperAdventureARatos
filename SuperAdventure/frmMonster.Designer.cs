namespace SuperAdventure
{
    partial class frmMonster
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
            this.lbMonsters = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lbMonsters
            // 
            this.lbMonsters.FormattingEnabled = true;
            this.lbMonsters.Location = new System.Drawing.Point(12, 12);
            this.lbMonsters.Name = "lbMonsters";
            this.lbMonsters.Size = new System.Drawing.Size(143, 238);
            this.lbMonsters.TabIndex = 1;
            // 
            // frmMonster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(182, 261);
            this.Controls.Add(this.lbMonsters);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmMonster";
            this.Text = "Monsters";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbMonsters;
    }
}