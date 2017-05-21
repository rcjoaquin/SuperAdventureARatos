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
    public partial class frmVendor : Form
    {
        public frmVendor()
        {
            InitializeComponent();
            lbVendors.DataSource = Game.Instance.world.ListVendors();
            lbVendors.DisplayMember = "Name";
            lbVendors.ValueMember = "ID";

            this.lbVendors.SelectedIndexChanged += new System.EventHandler(this.lbVendors_SelectedIndexChanged);
        }

        private void lbVendors_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbVendors.Items.Count > 0)
            {

                int VendorId = int.Parse(lbVendors.SelectedValue.ToString());

                frmVendorDetailed fVendorDetailed = new frmVendorDetailed(VendorId);

                fVendorDetailed.ShowDialog();
            }
        }
    }
}
