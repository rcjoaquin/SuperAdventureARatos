using System;
using System.Windows.Forms;
using System.IO;

using Engine;
using Engine.Messages;

namespace SuperAdventure
{
    public partial class frmLoadingPlayer : Form
    {
        public bool WorldLoaded { get; set; }

        public frmLoadingPlayer()
        {
            InitializeComponent();
            
        }

        private void frmLoadingPlayer_Load(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void DisplayMessage(object sender, MessageEventArgs messageEventArgs)
        {
            lblDescription.Text = messageEventArgs.Message;

            pbLoad.Value = messageEventArgs.Percentage;
        }

        private void frmLoadingPlayer_Shown(object sender, EventArgs e)
        {
            
            frmChooseWorld fChooseWorld = new frmChooseWorld();
            fChooseWorld.ShowDialog();
            this.Visible = true;

            string WorldChoose = fChooseWorld.WorldChoose;
            if (string.IsNullOrEmpty(WorldChoose))
            {
                if (fChooseWorld.WorldGenerate)
                {

                    Game.Instance.world = new World(fChooseWorld.Cols, fChooseWorld.Rows);
                    Game.Instance.world.OnMessage += DisplayMessage;
                    WorldLoaded = true;


                    this.Close();
                }
                else
                {
                    WorldLoaded = false;
                    this.Close();
                }
            }
            else
            {
                Game.Instance.world = new World(File.ReadAllText(Path.Combine(Environment.CurrentDirectory, "Worlds", WorldChoose)));
                WorldLoaded = true;
                Game.Instance.world.OnMessage += DisplayMessage;

                if (Game.Instance.world.LoadWorld())
                {
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Ha ocurrido un error al cargar este mundo [" + WorldChoose + "]", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
            }
        }

    }
}
