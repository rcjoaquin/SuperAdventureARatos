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
        public bool WorldGenerate { get; set; }

        public int Cols { get; set; }
        public int Rows { get; set; }


        public frmChooseWorld()
        {
            WorldGenerate = false;
            Cols = 0;
            Rows = 0;
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

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cols = int.Parse(txtCols.Text);

                this.Rows = int.Parse(txtRows.Text);
                WorldGenerate = true;
                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("No ha introducido numeros enteros en las filas y columnas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }
    }
}
