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
                Application.Run(new frmLoadingPlayer());

                Application.Run(new frmWorld());
            }


            //Application.Run(new SuperAdventure());


        }
    }
}
