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
    public partial class frmMonster : Form
    {
        public frmMonster()
        {
            InitializeComponent();

            lbMonsters.DataSource = World.ListMonsters();
            lbMonsters.DisplayMember = "Name";
            lbMonsters.ValueMember = "ID";

            this.lbMonsters.SelectedIndexChanged += new System.EventHandler(this.lbMonsters_SelectedIndexChanged);
        }

        private void lbMonsters_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbMonsters.Items.Count > 0)
            {

                int MonsterId = int.Parse(lbMonsters.SelectedValue.ToString());

                frmMonsterDetailed fMonsterDetailed = new frmMonsterDetailed(MonsterId);

                fMonsterDetailed.ShowDialog();
            }
        }
    }
}
