using SbsSW.SwiPlCs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NLIDB
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Environment.SetEnvironmentVariable("SWI_HOME_DIR", @"swipl");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (!PlEngine.IsInitialized)
            {
                String[] empty_param = { "" };
                PlEngine.Initialize(empty_param);
                Application.Run(new Form1());
                PlEngine.PlCleanup();
            }
           
            
        }
    }
}
