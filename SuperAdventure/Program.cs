using System;
using System.Windows.Forms;
using Engine;

namespace SuperAdventure
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            while(Game.NewWorld)
            {
                frmLoadingPlayer fLoadingPlayer = new frmLoadingPlayer();

                Application.Run(fLoadingPlayer);
                if (fLoadingPlayer.WorldLoaded)
                {
                    Application.Run(new frmWorld());
                }
                else
                {
                    Game.NewWorld = false;
                }
            }


            //Application.Run(new SuperAdventure());


        }
    }
}
