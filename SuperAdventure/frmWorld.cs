using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Net;
using System.Windows.Forms;
using Engine;

namespace SuperAdventure
{
    public partial class frmWorld : Form
    {
        public frmWorld()
        {
            InitializeComponent();

            DataGridViewImageColumn iconColumn = new DataGridViewImageColumn();

            WebClient client = new WebClient();
            Stream stream = client.OpenRead("http://img1.wikia.nocookie.net/__cb20101219155130/uncyclopedia/images/7/70/Facebooklogin.png");
            Bitmap bitmap;
            bitmap = new Bitmap(stream);

            iconColumn.Image = bitmap;
            iconColumn.Name = "Tree";
            iconColumn.HeaderText = "Nice tree";
            

            DataTable dataTablePlace = World.GetDataTablePlace();

            dgvWorld.DataSource = dataTablePlace;

            dgvWorld.Columns.Insert(6, iconColumn);

            dgvWorld.RowTemplate.Height = 100;
        }

        private void itemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmItem fITem = new frmItem();
            fITem.ShowDialog();
        }
    }
}
