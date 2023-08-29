using System;
using System.Windows.Forms;

namespace Calculator
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            // Set the high DPI mode to be system aware.
            Application.SetHighDpiMode(HighDpiMode.SystemAware);

            // Enable visual styles for the application.
            Application.EnableVisualStyles();

            // Set compatible text rendering default to false.
            Application.SetCompatibleTextRenderingDefault(false);

            // Run the application with the HomePage form as the starting point.
            Application.Run(new HomePage());
        }
    }
}