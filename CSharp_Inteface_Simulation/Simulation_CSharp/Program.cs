using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simulation_CSharp
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
            //Application.Run(new Door());
            // Application.Run(new Livingroom());
            // Application.Run(new Door());
            // Application.Run(new Bedroom());
            Application.Run(new Kitchen());
        }
    }
}
