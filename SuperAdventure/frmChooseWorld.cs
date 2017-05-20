using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperAdventure
{
    public partial class frmChooseWorld : Form
    {
        public string WorldChoose { get; set; }

        public frmChooseWorld()
        {
            InitializeComponent();

            DirectoryInfo directoryInfo = new DirectoryInfo(Path.Combine(Environment.CurrentDirectory, "Worlds"));

            lbWorlds.DataSource = directoryInfo.GetFiles();
            lbWorlds.DisplayMember = "Name";
            lbWorlds.ValueMember = "Name";
        }

        private void btnChoose_Click(object sender, EventArgs e)
        {
            if (lbWorlds.SelectedItems.Count > 0)
            {
                WorldChoose = lbWorlds.SelectedValue.ToString();

                this.Close();
            }

            
            
        }
    }
}
