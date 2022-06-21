using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace _291Project
{
    static class Program
    {

        public static bool context_customer = false;
        public static String context_userid = null;
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
            if (uc == null)
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

        public static void debug(String s)
        {
            MessageBox.Show(s);
        }

        public static string ExtractLeadingNumbers(String s)
        {
            string result = "";

            for (int i = 0; i < s.Length; i++) // loop over the complete input
            {
                if (char.IsDigit(s[i])) //check if the current char is digit
                    result += s[i];
                else
                    break; //Stop the loop after the first character
            }
            return result;
        }

        public static string SanitizeTextInput(String s)
        {
            return Regex.Replace(s, "[^a-zA-Z\x20]", String.Empty);
        }
    }
}
