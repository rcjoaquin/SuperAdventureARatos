namespace SuperAdventure
{
    partial class frmWorld
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
            this.dgvWorld = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWorld)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvWorld
            // 
            this.dgvWorld.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWorld.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvWorld.Location = new System.Drawing.Point(0, 0);
            this.dgvWorld.Name = "dgvWorld";
            this.dgvWorld.Size = new System.Drawing.Size(668, 401);
            this.dgvWorld.TabIndex = 0;
            // 
            // frmWorld
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 401);
            this.Controls.Add(this.dgvWorld);
            this.Name = "frmWorld";
            this.Text = "World";
            ((System.ComponentModel.ISupportInitialize)(this.dgvWorld)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvWorld;
    }
}