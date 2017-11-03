using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Microsoft.Win32;
using StickyNotes.Controller;
using StickyNotes.View;
namespace StickyNotes
{

    public partial class Start : Form
    {
        [DllImport("user32.dll")]//*********************拖动无窗体的控件
        public static extern bool ReleaseCapture();
        [DllImport("user32.dll")]
        public static extern bool SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);
        public const int WM_SYSCOMMAND = 0x0112;
        public const int SC_MOVE = 0xF010;
        public const int HTCAPTION = 0x0002;
      
        private Start()
        {
            InitializeComponent();
            try
            {
                Json j = new Json();
                int[] pos = j.GetMainPos();
                if (pos == null)
                {

                    pos[0] = 845;
                    pos[1] = 475;
                }
                this.Left = pos[0];
                this.Top = pos[1];
            }
            catch
            {

            }
            NotesManager manager = new NotesManager();
            manager.LoadNotes();
            string path = Application.ExecutablePath;
            RegistryKey key = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);//打开注册表子项 
            if (key == null) //如果该项不存在的话，则创建该子项 
            {
                key = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run");
            }

            key.SetValue("StickyNotes", path);//设置为开机启动 
            key.Close();
             
        }
        private static Start _start = null;
        public static Start GetStart()
        {
            if (_start == null)
            {
                _start = new Start();
            }
            return _start;
        }
        private void gPanelTitleBack_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_SYSCOMMAND, SC_MOVE + HTCAPTION, 0);//*********************调用移动无窗体控件函数
            Json j = new Json();
            j.SaveMainPos(this.Location.X, this.Location.Y);
        }
        private void Start_MouseUp(object sender, MouseEventArgs e)
        {
            
        }
        
        private void ManagerBtn_Click(object sender, EventArgs e)
        {
            //Manager m = new Manager();
            Manager m =Manager.GetManager();
            m.Show();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CreateBtn_Click(object sender, EventArgs e)
        {
            DataIO d = DataIO.GetDataIO();
            d.Show();
            //NoteModel n = new NoteModel();
            //n.Show();
        }

        private void CreateItem_Click(object sender, EventArgs e)
        {
            CreateBtn_Click(sender, e);
        }

        private void ManagerItem_Click(object sender, EventArgs e)
        {
            ManagerBtn_Click(sender, e);
        }

        private void ExitItem_Click(object sender, EventArgs e)
        {
            ExitBtn_Click(sender, e);
        }

        private  bool IsAutoRun=true;
        private void SettingsBtn_Click(object sender, EventArgs e)
        {
           
            string path = Application.ExecutablePath;
            RegistryKey key = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);//打开注册表子项 
            if (key == null) //如果该项不存在的话，则创建该子项 
            {
                key = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run");
            }
            if (!IsAutoRun)
            {
                try
                {
                    key.SetValue("StickyNotes", path);//设置为开机启动 
                    key.Close();
                    DialogResult result = MessageBox.Show("已设为开机自启动", "消息", MessageBoxButtons.OK);
                    IsAutoRun = !IsAutoRun;
                }catch
                {
                    DialogResult result = MessageBox.Show("开机自启动失败,请重试", "消息", MessageBoxButtons.OK);
                }
                
            }
            else if (IsAutoRun)
            {
                try{
                    key.DeleteValue("StickyNotes");//取消开机启动 
                    key.Close();
                    DialogResult result = MessageBox.Show("已取消开机自启动", "消息", MessageBoxButtons.OK);
                    IsAutoRun = !IsAutoRun;
                }catch
                {
                    DialogResult result = MessageBox.Show("取消开机自启动失败,请重试", "消息", MessageBoxButtons.OK);
                }
               
            }
          
        }

        private void SettingItem_Click(object sender, EventArgs e)
        {
            SettingsBtn_Click(sender, e);
        }

     
     
    }
}
