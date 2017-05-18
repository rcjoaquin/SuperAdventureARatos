using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Engine;
using Engine.Items;

namespace SuperAdventure
{
    public partial class frmItem : Form
    {
        public frmItem()
        {
            InitializeComponent();

            lbItems.DataSource = World.ListItems();
            lbItems.DisplayMember = "Name";
            lbItems.ValueMember = "ID";

            this.lbItems.SelectedIndexChanged += new System.EventHandler(this.lbItems_SelectedIndexChanged);
        }
        
        private void lbItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbItems.Items.Count > 0)
            {
                int ItemId = int.Parse(lbItems.SelectedValue.ToString());

                frmItemDetailed fItemDetailed = new frmItemDetailed(ItemId);

                fItemDetailed.ShowDialog();
            }
        }
    }
}
