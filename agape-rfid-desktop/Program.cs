using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

using it.mintlab.desktopnet.mercframework;

namespace agape_rfid_desktop
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>

         [STAThread]
        static void Main()
        {
            Application.ThreadException += new System.Threading.ThreadExceptionEventHandler(onThreadException);
            AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(onCurrentDomain_UnhandledException);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        static void onThreadException(Object sender, System.Threading.ThreadExceptionEventArgs e)
        {
            MessageBox.Show("Unhandled exception " + e.Exception.ToString());
        }

        static void onCurrentDomain_UnhandledException(Object sender, UnhandledExceptionEventArgs e)
        {
            MessageBox.Show("Unhandled exception " + e.ToString());
        }
    }

}
