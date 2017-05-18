namespace SuperAdventure
{
    partial class frmLootItemDetailed
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
            this.txtDropPercentage = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chIsDefaultItem = new System.Windows.Forms.CheckBox();
            this.btnViewItem = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtDropPercentage
            // 
            this.txtDropPercentage.Location = new System.Drawing.Point(106, 12);
            this.txtDropPercentage.Name = "txtDropPercentage";
            this.txtDropPercentage.Size = new System.Drawing.Size(56, 20);
            this.txtDropPercentage.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Drop Percentage";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(168, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "%";
            // 
            // chIsDefaultItem
            // 
            this.chIsDefaultItem.AutoSize = true;
            this.chIsDefaultItem.Location = new System.Drawing.Point(15, 45);
            this.chIsDefaultItem.Name = "chIsDefaultItem";
            this.chIsDefaultItem.Size = new System.Drawing.Size(94, 17);
            this.chIsDefaultItem.TabIndex = 12;
            this.chIsDefaultItem.Text = "Is Default Item";
            this.chIsDefaultItem.UseVisualStyleBackColor = true;
            // 
            // btnViewItem
            // 
            this.btnViewItem.Location = new System.Drawing.Point(15, 80);
            this.btnViewItem.Name = "btnViewItem";
            this.btnViewItem.Size = new System.Drawing.Size(168, 23);
            this.btnViewItem.TabIndex = 13;
            this.btnViewItem.Text = "View Item";
            this.btnViewItem.UseVisualStyleBackColor = true;
            this.btnViewItem.Click += new System.EventHandler(this.btnViewItem_Click);
            // 
            // frmLootItemDetailed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(201, 120);
            this.Controls.Add(this.btnViewItem);
            this.Controls.Add(this.chIsDefaultItem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDropPercentage);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmLootItemDetailed";
            this.Text = "Loot Item";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDropPercentage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chIsDefaultItem;
        private System.Windows.Forms.Button btnViewItem;
    }
}