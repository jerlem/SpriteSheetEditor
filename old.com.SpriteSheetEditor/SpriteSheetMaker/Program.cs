using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpriteSheetMaker
{
    static class Program
    {


        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Application.Run(new TestLoadImage());
            Application.Run(new SelectProgram());


            // Application.Run(new TestConversion());
        }
    }
}
