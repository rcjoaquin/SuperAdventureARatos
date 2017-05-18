using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Net;
using System.Windows.Forms;
using Engine;
using SuperAdventure.Controls;

namespace SuperAdventure
{
    public partial class frmWorld : Form
    {
        public frmWorld()
        {
            InitializeComponent();

            List<Location> place = World.GetPlace();

            tblpWorld.ColumnCount = World.maxX - World.minX +1;
            tblpWorld.RowCount = World.maxY - World.minY +1;

            for (int row = World.minY; row <= World.maxY; row++)
            {
                for (int col = World.minX; col <= World.maxX; col++)
                {
                    if (place.Find(l => l.x == col && l.y == row) != null)
                    {

                        Location loc = place.Find(l => l.x == col && l.y == row);

                        tblpWorld.Controls.Add((string.IsNullOrEmpty(loc.Picture)) ? new ctrlLocation(loc.ID, loc.Name) : new ctrlLocation(loc.ID, loc.Name, loc.Picture), col - World.minX, row - World.minY);

                    }

                }

            }

            tblpWorld.AutoSize = true;
            
        }

        private void itemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmItem fITem = new frmItem();
            fITem.ShowDialog();
        }

        private void monstersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMonster fMonster = new frmMonster();
            fMonster.ShowDialog();
        }

        private void questsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQuest fQuest = new frmQuest();
            fQuest.ShowDialog();
        }

        private void vendorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVendor fVendor = new frmVendor();
            fVendor.ShowDialog();
        }
    }
}
