using System;
using System.Windows.Forms;

namespace SectSystem
{
    internal static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            if (!DbManager.Connect("sectsystem", "127.0.0.1", 3306, "root", "root"))
            {
                //MessageBox.Show("数据库连接失败", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Application.Exit();
                return;
            }
            NetManager.Connect("127.0.0.1", 8888);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());

        }
    }
}
