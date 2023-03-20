using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examination_System
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //TODO: UNCOMMENT BELOW LINE
            //Application.Run(new LoginForm());

            // TODO: REMOVE LINE BELOW
            Application.Run(new InstructorDashboard(/*REPLACE 100 WITH LOGGED IN INSTURCTOR ID*/100));
            // TODO: SHOW INSTURCTORDASHBOARD FORM FROM LOGINFORM WHEN IT IS READY
        }
    }
}
