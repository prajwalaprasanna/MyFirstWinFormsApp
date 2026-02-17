using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstWinFormsApp
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


            //Application.Run(new Form1());
            //Application.Run(new Calculator
            //Application.Run(new Country());
            //Application.Run(new GrammarCheck());
            //Application.Run(new MenuTypes());
            Application.Run(new ContactInfo());
        }
    }
}
