using Engine;
using Engine.Items;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperAdventure
{
    public partial class frmQuestDetailed : Form
    {
        private int QuestId;

        public frmQuestDetailed()
        {
            InitializeComponent();

            this.Text = "New Quest";
        }

        public frmQuestDetailed(int Id)
        {
            this.QuestId = Id;
            InitializeComponent();

            this.Text = "Quest Id : " + this.QuestId.ToString();

            Quest quest = World.QuestByID(this.QuestId);

            txtName.Text = quest.Name;

            txtDescription.Text = quest.Description;

            //quest.RewardItem
            
            txtRewardExperiencePoints.Text = quest.RewardExperiencePoints.ToString();

            txtRewardGold.Text = quest.RewardGold.ToString();


            lbQuestCompletionItems.DataSource = quest.QuestCompletionItems.Select(s => new Item(s.Details.ID, s.Details.Name, "", 0)).ToList();
            lbQuestCompletionItems.DisplayMember = "Name";
            lbQuestCompletionItems.ValueMember = "ID";

            this.lbQuestCompletionItems.SelectedIndexChanged += new System.EventHandler(this.lbQuestCompletionItems_SelectedIndexChanged);
        }

        private void lbQuestCompletionItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            Quest quest = World.QuestByID(this.QuestId);

            if (lbQuestCompletionItems.Items.Count > 0)
            {
                int ItemId = int.Parse(lbQuestCompletionItems.SelectedValue.ToString());

                foreach (QuestCompletionItem qcItem in quest.QuestCompletionItems)
                {
                    if (qcItem.Details.ID == ItemId)
                    {   
                        frmQuestCompletionItemDetailed fQuestCompletionItemDetailed = new frmQuestCompletionItemDetailed(qcItem);
                        fQuestCompletionItemDetailed.ShowDialog();
                    }
                }
            }
        }
            
    }
}
