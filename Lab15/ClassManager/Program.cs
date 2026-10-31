using System;
using System.Windows.Forms;
using ClassManager.Views;

namespace ClassManager
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new FrmLop());
        }
    }
}