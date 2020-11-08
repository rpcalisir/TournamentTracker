using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackerLibrary.Enum;
using TrackerLibrary.Helper;

namespace TrackerUI
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

            //Initialize the database connections.
            //GlobalConfigHelper.InitializeConnections(true, true);
            GlobalConfigHelper.InitializeConnections(DatabaseType.Sql);

            Application.Run(new CreatePrize());
        }
    }
}
