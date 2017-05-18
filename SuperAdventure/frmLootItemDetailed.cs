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
    public partial class frmLootItemDetailed : Form
    {
        private LootItem lootItem;

        public frmLootItemDetailed()
        {
            InitializeComponent();

            this.Text = "New Loot Item";
        }

        public frmLootItemDetailed(LootItem lootItem )
        {
            this.lootItem = lootItem;
            InitializeComponent();

            this.Text = "Loot Item : "+this.lootItem.Details.ID;

            txtDropPercentage.Text = this.lootItem.DropPercentage.ToString();

            chIsDefaultItem.Checked = this.lootItem.IsDefaultItem;
        }

        private void btnViewItem_Click(object sender, EventArgs e)
        {
            frmItemDetailed fItemDetailed = new frmItemDetailed(this.lootItem.Details.ID);

            fItemDetailed.ShowDialog();
        }

    }
}
