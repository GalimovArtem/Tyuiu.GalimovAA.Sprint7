using System;
using System.Windows.Forms;

namespace Tyuiu.GalimovAA.Sprint7.Project.V7
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormMain_GAA());
        }
    }
}