using System;
using System.Windows.Forms;
using System.IO;

using Engine;
using Engine.Messages;

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
            frmChooseWorld fChooseWorld = new frmChooseWorld();
            fChooseWorld.ShowDialog();
            
            World.OnMessage += DisplayMessage;

            string WorldChoose = fChooseWorld.WorldChoose;

            if (World.LoadWorld(File.ReadAllText(Path.Combine(Environment.CurrentDirectory, "Worlds", WorldChoose))))
            {
                this.Close();
            }

        }

        private void DisplayMessage(object sender, MessageEventArgs messageEventArgs)
        {
            lblDescription.Text = messageEventArgs.Message;

            pbLoad.Value = messageEventArgs.Percentage;
        }
    }
}
