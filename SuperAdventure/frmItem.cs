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
            if(lbItems.Items.Count > 0)
            {

            
                Item item = World.ItemByID(int.Parse(lbItems.SelectedValue.ToString()));

                txtName.Text = item.Name;
                txtNamePlural.Text = item.NamePlural;
                txtID.Text = item.ID.ToString();
                txtPrice.Text = item.Price.ToString();


                chIsWeapon.Visible = item.IsWeapon();
                txtMinimumDamage.Visible = item.IsWeapon();
                txtMaximumDamage.Visible = item.IsWeapon();

                if (item.IsWeapon())
                {
                    Weapon weapon = (Weapon) World.ItemByID(int.Parse(lbItems.SelectedValue.ToString()));

                    txtMinimumDamage.Text = weapon.MinimumDamage.ToString();
                    txtMaximumDamage.Text = weapon.MaximumDamage.ToString();
                }


                chIsHealingPotion.Visible = item.IsHealingPotion();
                txtAmountToHeal.Visible = item.IsHealingPotion();

                if (item.IsHealingPotion())
                {
                    HealingPotion healingPotion = (HealingPotion)World.ItemByID(int.Parse(lbItems.SelectedValue.ToString()));

                    txtAmountToHeal.Text = healingPotion.AmountToHeal.ToString();
                
                }
            }
        }
    }
}
