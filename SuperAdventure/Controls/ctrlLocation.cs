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

namespace SuperAdventure.Controls
{
    public partial class ctrlLocation : UserControl
    {
        public ctrlLocation()
        {
            InitializeComponent();
        }

        public ctrlLocation(string Text)
        {
            InitializeComponent();

            this.LocationName.Text = Text;
        }

        public ctrlLocation(string Text, string B64Image)
        {
            InitializeComponent();

            

            Bitmap bitmap;
            using (var ms = new MemoryStream(Convert.FromBase64String(B64Image)))
            {   
                bitmap = new Bitmap(ms);
                this.LocationName.Text = Text;
                this.Picture.Image = bitmap;
            }

            
        }
    }
}
