using System;
using System.Windows.Forms;

namespace Pansiyon_Uygulaması
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new giris_form());
        }
    }
}
