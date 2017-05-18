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
    public partial class frmMonsterDetailed : Form
    {
        private int MonsterId;

        public frmMonsterDetailed()
        {
            InitializeComponent();

            this.Text = "New Monster";
        }

        public frmMonsterDetailed(int Id)
        {
            this.MonsterId = Id;
            InitializeComponent();

            this.Text = "Monster Id : "+ this.MonsterId.ToString();

            Monster monster = World.MonsterByID(this.MonsterId);

            txtName.Text = monster.Name.ToString();

            txtCurrentHitPoints.Text = monster.CurrentHitPoints.ToString();

            txtMaximumDamage.Text = monster.MaximumDamage.ToString();

            txtMaximumHitPoints.Text = monster.MaximumHitPoints.ToString();

            txtRewardExperiencePoints.Text = monster.RewardExperiencePoints.ToString();

            txtRewardGold.Text = monster.RewardGold.ToString();


            lbLootItems.DataSource = monster.LootTable.Select(s => new Item ( s.Details.ID,s.Details.Name,"",0)).ToList();
            lbLootItems.DisplayMember = "Name";
            lbLootItems.ValueMember = "ID";

            this.lbLootItems.SelectedIndexChanged += new System.EventHandler(this.lbLootItems_SelectedIndexChanged);
        }

        private void lbLootItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            Monster monster = World.MonsterByID(this.MonsterId);
            if (lbLootItems.Items.Count > 0)
            {
                int ItemId = int.Parse(lbLootItems.SelectedValue.ToString());

                foreach (LootItem lItem in monster.LootTable)
                {
                    if(lItem.Details.ID== ItemId)
                    {
                        frmLootItemDetailed fLootItemDetailed = new frmLootItemDetailed(lItem);
                        fLootItemDetailed.ShowDialog();
                    }
                }
            }
        }
            
    }
}
