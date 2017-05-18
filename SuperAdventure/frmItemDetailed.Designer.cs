namespace SuperAdventure
{
    partial class frmItemDetailed
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
            this.txtMaximumDamage = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAmountToHeal = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.gpIsWeapon = new System.Windows.Forms.GroupBox();
            this.gpIsHealingPotion = new System.Windows.Forms.GroupBox();
            this.gpIsWeapon.SuspendLayout();
            this.gpIsHealingPotion.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(108, 12);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(144, 20);
            this.txtName.TabIndex = 2;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(108, 71);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(144, 20);
            this.txtID.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "ID";
            // 
            // txtNamePlural
            // 
            this.txtNamePlural.Location = new System.Drawing.Point(108, 38);
            this.txtNamePlural.Name = "txtNamePlural";
            this.txtNamePlural.Size = new System.Drawing.Size(144, 20);
            this.txtNamePlural.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Name Plural";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(108, 97);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(144, 20);
            this.txtPrice.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Price";
            // 
            // txtMinimumDamage
            // 
            this.txtMinimumDamage.Location = new System.Drawing.Point(112, 28);
            this.txtMinimumDamage.Name = "txtMinimumDamage";
            this.txtMinimumDamage.Size = new System.Drawing.Size(100, 20);
            this.txtMinimumDamage.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Minimum Damage";
            // 
            // txtMaximumDamage
            // 
            this.txtMaximumDamage.Location = new System.Drawing.Point(112, 54);
            this.txtMaximumDamage.Name = "txtMaximumDamage";
            this.txtMaximumDamage.Size = new System.Drawing.Size(100, 20);
            this.txtMaximumDamage.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Maximum Damage";
            // 
            // txtAmountToHeal
            // 
            this.txtAmountToHeal.Location = new System.Drawing.Point(108, 30);
            this.txtAmountToHeal.Name = "txtAmountToHeal";
            this.txtAmountToHeal.Size = new System.Drawing.Size(100, 20);
            this.txtAmountToHeal.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Amount To Heal";
            // 
            // gpIsWeapon
            // 
            this.gpIsWeapon.Controls.Add(this.label4);
            this.gpIsWeapon.Controls.Add(this.txtMinimumDamage);
            this.gpIsWeapon.Controls.Add(this.label6);
            this.gpIsWeapon.Controls.Add(this.txtMaximumDamage);
            this.gpIsWeapon.Location = new System.Drawing.Point(15, 142);
            this.gpIsWeapon.Name = "gpIsWeapon";
            this.gpIsWeapon.Size = new System.Drawing.Size(237, 100);
            this.gpIsWeapon.TabIndex = 17;
            this.gpIsWeapon.TabStop = false;
            this.gpIsWeapon.Text = "Is Weapon";
            // 
            // gpIsHealingPotion
            // 
            this.gpIsHealingPotion.Controls.Add(this.txtAmountToHeal);
            this.gpIsHealingPotion.Controls.Add(this.label7);
            this.gpIsHealingPotion.Location = new System.Drawing.Point(15, 148);
            this.gpIsHealingPotion.Name = "gpIsHealingPotion";
            this.gpIsHealingPotion.Size = new System.Drawing.Size(237, 100);
            this.gpIsHealingPotion.TabIndex = 18;
            this.gpIsHealingPotion.TabStop = false;
            this.gpIsHealingPotion.Text = "Is Healing Potion";
            // 
            // frmItemDetailed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 261);
            this.Controls.Add(this.gpIsHealingPotion);
            this.Controls.Add(this.gpIsWeapon);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNamePlural);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmItemDetailed";
            this.Text = "Item: ";
            this.gpIsWeapon.ResumeLayout(false);
            this.gpIsWeapon.PerformLayout();
            this.gpIsHealingPotion.ResumeLayout(false);
            this.gpIsHealingPotion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private System.Windows.Forms.TextBox txtMaximumDamage;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAmountToHeal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox gpIsWeapon;
        private System.Windows.Forms.GroupBox gpIsHealingPotion;
    }
}