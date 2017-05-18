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
    public partial class frmQuestCompletionItemDetailed : Form
    {
        private QuestCompletionItem questCompletionItem;

        public frmQuestCompletionItemDetailed()
        {
            InitializeComponent();

            this.Text = "New Loot Item";
        }

        public frmQuestCompletionItemDetailed(QuestCompletionItem questCompletionItem)
        {
            this.questCompletionItem = questCompletionItem;
            InitializeComponent();

            this.Text = "Quest Completion Item : " + this.questCompletionItem.Details.ID;

            txtQuantity.Text = this.questCompletionItem.Quantity.ToString();
        }

        private void btnViewItem_Click(object sender, EventArgs e)
        {
            frmItemDetailed fItemDetailed = new frmItemDetailed(this.questCompletionItem.Details.ID);

            fItemDetailed.ShowDialog();
        }

    }
}
