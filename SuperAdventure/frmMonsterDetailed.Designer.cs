namespace SuperAdventure
{
    partial class frmMonsterDetailed
    {
        private void InitializeComponent()
        {
            this.lbLootItems = new System.Windows.Forms.ListBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtMaximumDamage = new System.Windows.Forms.TextBox();
            this.txtCurrentHitPoints = new System.Windows.Forms.TextBox();
            this.txtRewardExperiencePoints = new System.Windows.Forms.TextBox();
            this.txtMaximumHitPoints = new System.Windows.Forms.TextBox();
            this.txtRewardGold = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbLootItems
            // 
            this.lbLootItems.FormattingEnabled = true;
            this.lbLootItems.Location = new System.Drawing.Point(12, 187);
            this.lbLootItems.Name = "lbLootItems";
            this.lbLootItems.Size = new System.Drawing.Size(143, 173);
            this.lbLootItems.TabIndex = 2;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(159, 12);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(161, 20);
            this.txtName.TabIndex = 3;
            // 
            // txtMaximumDamage
            // 
            this.txtMaximumDamage.Location = new System.Drawing.Point(159, 64);
            this.txtMaximumDamage.Name = "txtMaximumDamage";
            this.txtMaximumDamage.Size = new System.Drawing.Size(161, 20);
            this.txtMaximumDamage.TabIndex = 4;
            // 
            // txtCurrentHitPoints
            // 
            this.txtCurrentHitPoints.Location = new System.Drawing.Point(159, 38);
            this.txtCurrentHitPoints.Name = "txtCurrentHitPoints";
            this.txtCurrentHitPoints.Size = new System.Drawing.Size(161, 20);
            this.txtCurrentHitPoints.TabIndex = 5;
            // 
            // txtRewardExperiencePoints
            // 
            this.txtRewardExperiencePoints.Location = new System.Drawing.Point(159, 116);
            this.txtRewardExperiencePoints.Name = "txtRewardExperiencePoints";
            this.txtRewardExperiencePoints.Size = new System.Drawing.Size(161, 20);
            this.txtRewardExperiencePoints.TabIndex = 6;
            // 
            // txtMaximumHitPoints
            // 
            this.txtMaximumHitPoints.Location = new System.Drawing.Point(159, 90);
            this.txtMaximumHitPoints.Name = "txtMaximumHitPoints";
            this.txtMaximumHitPoints.Size = new System.Drawing.Size(161, 20);
            this.txtMaximumHitPoints.TabIndex = 7;
            // 
            // txtRewardGold
            // 
            this.txtRewardGold.Location = new System.Drawing.Point(159, 142);
            this.txtRewardGold.Name = "txtRewardGold";
            this.txtRewardGold.Size = new System.Drawing.Size(161, 20);
            this.txtRewardGold.TabIndex = 8;
            // 
            // frmMonsterDetailed
            // 
            this.ClientSize = new System.Drawing.Size(342, 372);
            this.Controls.Add(this.txtRewardGold);
            this.Controls.Add(this.txtMaximumHitPoints);
            this.Controls.Add(this.txtRewardExperiencePoints);
            this.Controls.Add(this.txtCurrentHitPoints);
            this.Controls.Add(this.txtMaximumDamage);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lbLootItems);
            this.Name = "frmMonsterDetailed";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.ListBox lbLootItems;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtMaximumDamage;
        private System.Windows.Forms.TextBox txtCurrentHitPoints;
        private System.Windows.Forms.TextBox txtRewardExperiencePoints;
        private System.Windows.Forms.TextBox txtMaximumHitPoints;
        private System.Windows.Forms.TextBox txtRewardGold;
    }
}
