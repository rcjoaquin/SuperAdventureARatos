using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Engine;

namespace SuperAdventure.Controls
{
    public partial class ctrlLocation : UserControl
    {
        private Location location;

        public ctrlLocation()
        {
            InitializeComponent();
        }

        public ctrlLocation(int IdLocation,string Text)
        {
            InitializeComponent();

            this.LocationName.Text = Text;
            this.location = World.LocationByID(IdLocation);
        }

        public ctrlLocation(int IdLocation, string Text, string B64Image)
        {
            InitializeComponent();            

            Bitmap bitmap;
            using (var ms = new MemoryStream(Convert.FromBase64String(B64Image)))
            {   
                bitmap = new Bitmap(ms);
                this.LocationName.Text = Text;
                this.location = World.LocationByID(IdLocation);
                this.Picture.Image = bitmap;
            }

            
        }

        private void Picture_Click(object sender, EventArgs e)
        {
            frmLocation fLocation = new frmLocation(location.ID);
            fLocation.ShowDialog();
        }
    }
}
