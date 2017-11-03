using StickyNotes.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StickyNotes
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            bool createNew;
            using (Mutex mutex = new Mutex(true,Application.ProductName,out createNew))
            {
                if (createNew)
                {
                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);
                    //Application.Run(new Form1());
                    Application.Run(Start.GetStart());
                }
                // 程序已经运行的情况，则弹出消息提示并终止此次运行
                else
                {
                    MessageBox.Show("应用程序已经在运行中...");
                    System.Threading.Thread.Sleep(1000);
                    //  终止此进程并为基础操作系统提供指定的退出代码。
                    System.Environment.Exit(1);
                }
            }
         
            
        }
    }
}
