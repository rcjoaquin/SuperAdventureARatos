using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using Engine;

namespace SuperAdventure
{
    public partial class frmWorld : Form
    {
        public frmWorld()
        {
            InitializeComponent();
            
            DataTable dataTablePlace = World.GetDataTablePlace();

            dgvWorld.DataSource = dataTablePlace;

            //dgvWorld.Rows[0]. = "First Column";

            dgvWorld.RowTemplate.Height = 100;
        }

        
    }
}
