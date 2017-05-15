using System;
using System.Windows.Forms;
using System.IO;

using Engine;

namespace SuperAdventure
{
    public partial class frmLoadingPlayer : Form
    {
        public frmLoadingPlayer()
        {
            InitializeComponent();


            
        }

        private void frmLoadingPlayer_Load(object sender, EventArgs e)
        {
            if (World.LoadWorld(File.ReadAllText(Path.Combine(Environment.CurrentDirectory, "Worlds", "WorldData.xml"))))
                this.Close();
        }
    }
}
