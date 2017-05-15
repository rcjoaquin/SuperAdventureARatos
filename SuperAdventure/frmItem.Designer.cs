namespace SuperAdventure
{
    partial class frmItem
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
            this.lbItems = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNamePlural = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMinimumDamage = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.chIsWeapon = new System.Windows.Forms.CheckBox();
            this.txtMaximumDamage = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.chIsHealingPotion = new System.Windows.Forms.CheckBox();
            this.txtAmountToHeal = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbItems
            // 
            this.lbItems.FormattingEnabled = true;
            this.lbItems.Location = new System.Drawing.Point(13, 13);
            this.lbItems.Name = "lbItems";
            this.lbItems.Size = new System.Drawing.Size(143, 238);
            this.lbItems.TabIndex = 0;
            
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(174, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(270, 13);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 2;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(270, 72);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(174, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "ID";
            // 
            // txtNamePlural
            // 
            this.txtNamePlural.Location = new System.Drawing.Point(270, 39);
            this.txtNamePlural.Name = "txtNamePlural";
            this.txtNamePlural.Size = new System.Drawing.Size(100, 20);
            this.txtNamePlural.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(174, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Name";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(270, 98);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(100, 20);
            this.txtPrice.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(174, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Price";
            // 
            // txtMinimumDamage
            // 
            this.txtMinimumDamage.Location = new System.Drawing.Point(270, 152);
            this.txtMinimumDamage.Name = "txtMinimumDamage";
            this.txtMinimumDamage.Size = new System.Drawing.Size(100, 20);
            this.txtMinimumDamage.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(174, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Minimum Damage";
            // 
            // chIsWeapon
            // 
            this.chIsWeapon.AutoSize = true;
            this.chIsWeapon.Location = new System.Drawing.Point(177, 132);
            this.chIsWeapon.Name = "chIsWeapon";
            this.chIsWeapon.Size = new System.Drawing.Size(78, 17);
            this.chIsWeapon.TabIndex = 11;
            this.chIsWeapon.Text = "Is Weapon";
            this.chIsWeapon.UseVisualStyleBackColor = true;
            // 
            // txtMaximumDamage
            // 
            this.txtMaximumDamage.Location = new System.Drawing.Point(270, 178);
            this.txtMaximumDamage.Name = "txtMaximumDamage";
            this.txtMaximumDamage.Size = new System.Drawing.Size(100, 20);
            this.txtMaximumDamage.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(174, 178);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Maximum Damage";
            // 
            // chIsHealingPotion
            // 
            this.chIsHealingPotion.AutoSize = true;
            this.chIsHealingPotion.Location = new System.Drawing.Point(177, 209);
            this.chIsHealingPotion.Name = "chIsHealingPotion";
            this.chIsHealingPotion.Size = new System.Drawing.Size(106, 17);
            this.chIsHealingPotion.TabIndex = 16;
            this.chIsHealingPotion.Text = "Is Healing Potion";
            this.chIsHealingPotion.UseVisualStyleBackColor = true;
            // 
            // txtAmountToHeal
            // 
            this.txtAmountToHeal.Location = new System.Drawing.Point(270, 229);
            this.txtAmountToHeal.Name = "txtAmountToHeal";
            this.txtAmountToHeal.Size = new System.Drawing.Size(100, 20);
            this.txtAmountToHeal.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(174, 229);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Amount To Heal";
            // 
            // frmItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 261);
            this.Controls.Add(this.chIsHealingPotion);
            this.Controls.Add(this.txtAmountToHeal);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtMaximumDamage);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.chIsWeapon);
            this.Controls.Add(this.txtMinimumDamage);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNamePlural);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbItems);
            this.Name = "frmItem";
            this.Text = "Items";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbItems;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNamePlural;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMinimumDamage;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chIsWeapon;
        private System.Windows.Forms.TextBox txtMaximumDamage;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox chIsHealingPotion;
        private System.Windows.Forms.TextBox txtAmountToHeal;
        private System.Windows.Forms.Label label7;
    }
}