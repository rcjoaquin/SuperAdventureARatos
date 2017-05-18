namespace SuperAdventure
{
    partial class frmInventoryItemDetailed
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
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(77, 9);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(125, 20);
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
            this.btnViewItem.Location = new System.Drawing.Point(12, 146);
            this.btnViewItem.Name = "btnViewItem";
            this.btnViewItem.Size = new System.Drawing.Size(190, 23);
            this.btnViewItem.TabIndex = 13;
            this.btnViewItem.Text = "View Item";
            this.btnViewItem.UseVisualStyleBackColor = true;
            this.btnViewItem.Click += new System.EventHandler(this.btnViewItem_Click);
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(77, 35);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(125, 20);
            this.txtPrice.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Price";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(77, 61);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(125, 79);
            this.txtDescription.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Description";
            // 
            // frmInventoryItemDetailed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(214, 181);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnViewItem);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmInventoryItemDetailed";
            this.Text = "Inventory Item";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnViewItem;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label3;
    }
}