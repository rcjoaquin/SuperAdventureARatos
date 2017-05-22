namespace SuperAdventure
{
    partial class frmMonsterDetailed
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
            this.lbLootItems = new System.Windows.Forms.ListBox();
            this.txtMaximumHitPoints = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCurrentHitPoints = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaximumDamage = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRewardGold = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRewardExperiencePoints = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbLootItems
            // 
            this.lbLootItems.FormattingEnabled = true;
            this.lbLootItems.Location = new System.Drawing.Point(12, 175);
            this.lbLootItems.Name = "lbLootItems";
            this.lbLootItems.Size = new System.Drawing.Size(132, 95);
            this.lbLootItems.TabIndex = 1;
            // 
            // txtMaximumHitPoints
            // 
            this.txtMaximumHitPoints.Location = new System.Drawing.Point(150, 97);
            this.txtMaximumHitPoints.Name = "txtMaximumHitPoints";
            this.txtMaximumHitPoints.Size = new System.Drawing.Size(128, 20);
            this.txtMaximumHitPoints.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Maximum Hit Points";
            // 
            // txtCurrentHitPoints
            // 
            this.txtCurrentHitPoints.Location = new System.Drawing.Point(150, 38);
            this.txtCurrentHitPoints.Name = "txtCurrentHitPoints";
            this.txtCurrentHitPoints.Size = new System.Drawing.Size(128, 20);
            this.txtCurrentHitPoints.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Current Hit Points";
            // 
            // txtMaximumDamage
            // 
            this.txtMaximumDamage.Location = new System.Drawing.Point(150, 71);
            this.txtMaximumDamage.Name = "txtMaximumDamage";
            this.txtMaximumDamage.Size = new System.Drawing.Size(128, 20);
            this.txtMaximumDamage.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Maximum Damage";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(150, 12);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(128, 20);
            this.txtName.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Name";
            // 
            // txtRewardGold
            // 
            this.txtRewardGold.Location = new System.Drawing.Point(150, 149);
            this.txtRewardGold.Name = "txtRewardGold";
            this.txtRewardGold.Size = new System.Drawing.Size(128, 20);
            this.txtRewardGold.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Reward Gold";
            // 
            // txtRewardExperiencePoints
            // 
            this.txtRewardExperiencePoints.Location = new System.Drawing.Point(150, 123);
            this.txtRewardExperiencePoints.Name = "txtRewardExperiencePoints";
            this.txtRewardExperiencePoints.Size = new System.Drawing.Size(128, 20);
            this.txtRewardExperiencePoints.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Reward Experience Points";
            // 
            // frmMonsterDetailed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 279);
            this.Controls.Add(this.txtRewardGold);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtRewardExperiencePoints);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtMaximumHitPoints);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCurrentHitPoints);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMaximumDamage);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbLootItems);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmMonsterDetailed";
            this.Text = "Monsters";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbLootItems;
        private System.Windows.Forms.TextBox txtMaximumHitPoints;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCurrentHitPoints;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaximumDamage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRewardGold;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtRewardExperiencePoints;
        private System.Windows.Forms.Label label6;
    }
}