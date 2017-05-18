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
    public partial class frmItemDetailed : Form
    {
        private int ItemId;

        public frmItemDetailed()
        {
            InitializeComponent();

            this.Text = "New Item";
        }

        public frmItemDetailed(int Id)
        {
            this.ItemId = Id;
            InitializeComponent();
            this.Text = "Item Id : "+ this.ItemId.ToString();

            Item item = World.ItemByID(this.ItemId);

            txtName.Text = item.Name;
            txtNamePlural.Text = item.NamePlural;
            txtID.Text = item.ID.ToString();
            txtPrice.Text = item.Price.ToString();

            gpIsWeapon.Visible = item.IsWeapon();
            gpIsHealingPotion.Visible = item.IsHealingPotion();


            if (item.IsWeapon())
            {
                Weapon weapon = (Weapon)World.ItemByID(this.ItemId);

                txtMinimumDamage.Text = weapon.MinimumDamage.ToString();
                txtMaximumDamage.Text = weapon.MaximumDamage.ToString();
            }

            txtAmountToHeal.Visible = item.IsHealingPotion();

            if (item.IsHealingPotion())
            {
                HealingPotion healingPotion = (HealingPotion)World.ItemByID(this.ItemId);

                txtAmountToHeal.Text = healingPotion.AmountToHeal.ToString();

            }
        }
        
    }
}
