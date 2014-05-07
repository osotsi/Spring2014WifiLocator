using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace WifiServerProgram
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Test #1
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Test #4
            WifiLocator wiTest = new WifiLocator();
            //wiTest.userIdText.Text = "testing...";
            //wiTest.firstNameText.Text = "testing...";
            //wiTest.emailText.Text = "testing...";
            //wiTest.macAddressText.Text = "testing...";
            //wiTest.lastNameText.Text = "testing...";
            //wiTest.passwordText.Text = "testing...";
            
            Application.Run(wiTest);

        }
    }
}
