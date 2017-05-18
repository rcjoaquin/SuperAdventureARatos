using Engine;
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
    public partial class frmQuest : Form
    {
        public frmQuest()
        {
            InitializeComponent();
            lbQuests.DataSource = World.ListQuests();
            lbQuests.DisplayMember = "Name";
            lbQuests.ValueMember = "ID";

            this.lbQuests.SelectedIndexChanged += new System.EventHandler(this.lbQuests_SelectedIndexChanged);
        }

        private void lbQuests_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbQuests.Items.Count > 0)
            {

                int QuestId = int.Parse(lbQuests.SelectedValue.ToString());

                frmQuestDetailed fQuestDetailed = new frmQuestDetailed(QuestId);

                fQuestDetailed.ShowDialog();
            }
        }
    }
}
