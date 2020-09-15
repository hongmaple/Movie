using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Movie
{
    static class Program
    {

        public static string username;
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
           
            //修改入口函数的首出窗口
            Login f_login = new Login();
            if (f_login.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new MainWindow());
            }

        }
    }
}
