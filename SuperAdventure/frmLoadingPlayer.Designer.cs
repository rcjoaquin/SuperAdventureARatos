namespace SuperAdventure
{
    partial class frmLoadingPlayer
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
            this.lblDescription = new System.Windows.Forms.Label();
            this.pbLoad = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(91, 9);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(99, 18);
            this.lblDescription.TabIndex = 0;
            this.lblDescription.Text = "Description ...";
            // 
            // pbLoad
            // 
            this.pbLoad.Location = new System.Drawing.Point(12, 68);
            this.pbLoad.Name = "pbLoad";
            this.pbLoad.Size = new System.Drawing.Size(276, 23);
            this.pbLoad.TabIndex = 1;
            // 
            // frmLoadingPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 103);
            this.Controls.Add(this.pbLoad);
            this.Controls.Add(this.lblDescription);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLoadingPlayer";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "frmLoadingPlayer";
            this.Load += new System.EventHandler(this.frmLoadingPlayer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.ProgressBar pbLoad;
    }
}