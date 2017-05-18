namespace SuperAdventure
{
    partial class frmQuestCompletionItemDetailed
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
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnViewItem = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(106, 12);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(56, 20);
            this.txtQuantity.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Quantity";
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
            // frmQuestCompletionItemDetailed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(201, 120);
            this.Controls.Add(this.btnViewItem);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmQuestCompletionItemDetailed";
            this.Text = "Quest Completion Item";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnViewItem;
    }
}