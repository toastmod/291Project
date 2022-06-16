using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _291Project
{
    static class Program
    {

        public static String context_branchid = null;
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            DBridge.init();

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Application.Run(new CSignUpForm());
            Application.Run(new LoginSplash());
        }

        public static bool UCBack(dynamic uc)
        {
            if(uc == null)
            {
                return false;
            }
            else
            {
                return true;                
            }
        }

        public static void println(String s)
        {
            System.Diagnostics.Debug.WriteLine(s);
        }

    }
}
