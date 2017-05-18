using Engine;
using Engine.Characters;
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
    public partial class frmVendorDetailed : Form
    {
        private int VendorId;

        public frmVendorDetailed()
        {
            InitializeComponent();

            this.Text = "New Vendor";
        }

        public frmVendorDetailed(int Id)
        {
            this.VendorId = Id;
            InitializeComponent();

            this.Text = "Vendor : " + this.VendorId;

            Vendor vendor = World.VendorByID(this.VendorId);

            txtName.Text = vendor.Name;


            lbInventoryItem.DataSource = vendor.Inventory.Select(s => new Item(s.Details.ID, s.Details.Name, "", 0)).ToList();
            lbInventoryItem.DisplayMember = "Name";
            lbInventoryItem.ValueMember = "ID";

            this.lbInventoryItem.SelectedIndexChanged += new System.EventHandler(this.lbInventoryItem_SelectedIndexChanged);
        }

        private void lbInventoryItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            Vendor vendor = World.VendorByID(this.VendorId);

            if (lbInventoryItem.Items.Count > 0)
            {
                int ItemId = int.Parse(lbInventoryItem.SelectedValue.ToString());

                foreach (InventoryItem iItem in vendor.Inventory)
                {
                    if (iItem.Details.ID == ItemId)
                    {
                        frmInventoryItemDetailed fInventoryItemDetailed = new frmInventoryItemDetailed(iItem);
                        fInventoryItemDetailed.ShowDialog();
                    }
                }
            }
        }

    }
}
