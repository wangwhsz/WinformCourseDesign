using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WndProc
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            FrmLogin frmlog = new FrmLogin();
            frmlog.ShowDialog();
            if (frmlog.DialogResult == DialogResult.OK)
            {
                //program.cs
                Application.Run(new FrmMain());
            }







            //Application.Run(new FrmLogin());
        }
    }
}
