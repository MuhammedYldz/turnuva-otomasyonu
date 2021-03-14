using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using TracerLibrary;

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
            //initialize the database connection
            TracerLibrary.GlobalConfig.İnitializeConnection(DatabaseType.Sql);
            Application.Run(new CreatTournamentForm());
            
            //Application.Run(new TournamentDashboardForm());
        }
    }
}
