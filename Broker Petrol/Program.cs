using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Broker_Petrol
{
    static class Program
    {

        
        /// <summary>
        /// The startup for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
    
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Instantiate Form1 to start the application
            Application.Run(new Form1()); 
        }
    }
}
