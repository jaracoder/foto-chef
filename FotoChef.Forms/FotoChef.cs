using System;
using System.Windows.Forms;

namespace FotoChef.Forms
{
    static class FotoChef
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmMain());
        }
    }
}
