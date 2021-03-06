﻿using System;
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

            List<Location> place = Game.Instance.world.GetPlace();

            tblpWorld.ColumnCount = Game.Instance.world.maxX - Game.Instance.world.minX +3;
            tblpWorld.RowCount = Game.Instance.world.maxY - Game.Instance.world.minY +2;

           

            for (int col = Game.Instance.world.minX; col <= Game.Instance.world.maxX; col++)
            {
                tblpWorld.Controls.Add(new ctrlEmptyLocation(), col - Game.Instance.world.minX +1, 0);

                tblpWorld.Controls.Add(new ctrlEmptyLocation(), col - Game.Instance.world.minX+1, Game.Instance.world.maxY - Game.Instance.world.minY + 2);
            }

            for (int row = Game.Instance.world.minY; row <= Game.Instance.world.maxY; row++)
            {

                tblpWorld.Controls.Add(new ctrlEmptyLocation(), 0, row - Game.Instance.world.minY + 1);

                tblpWorld.Controls.Add(new ctrlEmptyLocation(), Game.Instance.world.maxX - Game.Instance.world.minX + 2, row - Game.Instance.world.minY + 1);

                for (int col = Game.Instance.world.minX; col <= Game.Instance.world.maxX; col++)
                {

                    if (place.Find(l => l.x == col && l.y == row) != null)
                    {

                        Location loc = place.Find(l => l.x == col && l.y == row);

                        tblpWorld.Controls.Add((string.IsNullOrEmpty(loc.Picture)) ? new ctrlLocation(loc.ID, loc.Name) : new ctrlLocation(loc.ID, loc.Name, loc.Picture), col - Game.Instance.world.minX +1 , row - Game.Instance.world.minY +1 );
                    }
                    else
                    {
                        tblpWorld.Controls.Add(new ctrlEmptyLocation(), col - Game.Instance.world.minX +1, row - Game.Instance.world.minY +1 );
                    }
                }

            }

            tblpWorld.AutoSize = true;
            
        }

        private void worldsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Game.NewWorld = true;
            this.Close();
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

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Game.NewWorld = false;
            this.Close();
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Xml World File (.xml)|*.xml|All Files (*.*)|*.*";
            sfd.ShowDialog();
            if(!string.IsNullOrEmpty(sfd.FileName))
            {
                File.WriteAllText(sfd.FileName, Game.Instance.world.ToXmlString());
            }
        }

        private void addRightColumnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //tblpWorld.
        }
    }
}
