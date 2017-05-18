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
    public partial class frmInventoryItemDetailed : Form
    {
        private InventoryItem inventoryItem;

        public frmInventoryItemDetailed()
        {
            InitializeComponent();

            this.Text = "New Inventory Item";
        }

        public frmInventoryItemDetailed(InventoryItem inventoryItem)
        {
            this.inventoryItem = inventoryItem;
            InitializeComponent();

            this.Text = "InventoryItem Item : " + this.inventoryItem.Details.ID;

            txtQuantity.Text = this.inventoryItem.Quantity.ToString();
            txtPrice.Text = this.inventoryItem.Price.ToString();
            txtDescription.Text = this.inventoryItem.Description.ToString();
            
        }

        private void btnViewItem_Click(object sender, EventArgs e)
        {
            frmItemDetailed fItemDetailed = new frmItemDetailed(this.inventoryItem.Details.ID);

            fItemDetailed.ShowDialog();
        }

    }
}
