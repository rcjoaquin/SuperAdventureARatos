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
        private Common.Mode mode;

        public frmLocation()
        {
            InitializeComponent();
            mode = Common.Mode.New;
        }

        public frmLocation(int IdLocation)
        {
            InitializeComponent();
            mode = Common.Mode.Edit;
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

            txtDescription.Text = this.location.Description;
            //this.location.HasItemRequiredToEnter
            //this.location.HasAMonster
            //this.location.HasAQuest            
        }
    }
}
