using Engine;
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
    public partial class frmLocation : Form
    {
        private Location location;

        public frmLocation()
        {
            InitializeComponent();
        }

        public frmLocation(int IdLocation)
        {
            InitializeComponent();
            this.location = World.LocationByID(IdLocation);

            lbLocation.Text = this.location.Name;
            if(!string.IsNullOrEmpty(location.Picture))
            {
                Bitmap bitmap;
                using (var ms = new MemoryStream(Convert.FromBase64String(location.Picture)))
                {   
                    bitmap = new Bitmap(ms);
                    this.Picture.Image = bitmap;
                }
            }
            //this.location.HasItemRequiredToEnter
            //this.location.HasAMonster
            //this.location.HasAQuest            
        }
    }
}
