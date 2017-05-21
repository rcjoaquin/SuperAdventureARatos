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
            
            string WorldChoose = fChooseWorld.WorldChoose;

            Game.Instance.world = new World(File.ReadAllText(Path.Combine(Environment.CurrentDirectory, "Worlds", WorldChoose)));

            Game.Instance.world.OnMessage += DisplayMessage;

            if (Game.Instance.world.LoadWorld())
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
