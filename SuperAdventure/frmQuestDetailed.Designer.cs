namespace SuperAdventure
{
    partial class frmQuestDetailed
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
            this.lbQuestCompletionItems = new System.Windows.Forms.ListBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRewardGold = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRewardExperiencePoints = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbQuestCompletionItems
            // 
            this.lbQuestCompletionItems.FormattingEnabled = true;
            this.lbQuestCompletionItems.Location = new System.Drawing.Point(12, 172);
            this.lbQuestCompletionItems.Name = "lbQuestCompletionItems";
            this.lbQuestCompletionItems.Size = new System.Drawing.Size(132, 95);
            this.lbQuestCompletionItems.TabIndex = 1;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(150, 42);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(128, 75);
            this.txtDescription.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Description";
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
            // frmQuestDetailed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 279);
            this.Controls.Add(this.txtRewardGold);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtRewardExperiencePoints);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbQuestCompletionItems);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmQuestDetailed";
            this.Text = "Monsters";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbQuestCompletionItems;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRewardGold;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtRewardExperiencePoints;
        private System.Windows.Forms.Label label6;
    }
}