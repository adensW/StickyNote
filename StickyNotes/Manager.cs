using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StickyNotes.Controller;
using StickyNotes.View;
using System.Runtime.InteropServices;
namespace StickyNotes
{
    public partial class Manager : Form
    {
        [DllImport("user32.dll")]//*********************拖动无窗体的控件
        public static extern bool ReleaseCapture();
        [DllImport("user32.dll")]
        public static extern bool SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);
        public const int WM_SYSCOMMAND = 0x0112;
        public const int SC_MOVE = 0xF010;
        public const int HTCAPTION = 0x0002;
        private Manager()
        {
            InitializeComponent();
        }
        //单例模型

        private static Manager _manager = null;
        public static Manager GetManager()
        {
            if (_manager == null)
            {
                _manager = new Manager();
            }
            return _manager;
        }
        private void Manager_FormClosing(object sender, FormClosingEventArgs e)
        {
            //当你关闭窗体的时候 让窗体的资源不被释放
            _manager = new Manager();
        }
        private void Manager_Load(object sender, EventArgs e)
        {
            List<NotesData> list = new List<NotesData>();
            list = new Json().GetAllNotes();
            int x = 16;
            int y = this.panel1.Height+4;
            if (list.Count == 0||list==null)
            {
                Label te = new Label();
                te.Text = "您没有便签需要管理。";
                te.Width = this.Width-32;
                y +=te.Height + 10;
                te.Left = x;
                te.Top = y;
                te.BorderStyle = BorderStyle.None;
                this.Controls.Add(te);
                return;
            }
           
            foreach (NotesData n in list)
            {
                Panel panel = new Panel();
                panel.Left = 0;
                panel.Top = y;
                panel.Width = 280;
                panel.Height = 48;
                panel.BackColor = Color.Transparent;
                this.Controls.Add(panel);
               

                PictureBox pic = new PictureBox();
                pic.Name = "mod_" + n.ID;
                pic.Image = StickyNotes.Properties.Resources.ic_edit_black_24dp_1x;
                pic.Left = 16;
                pic.Top = 12;
                pic.Width = 24;
                pic.Height = 24;
                pic.Click += new EventHandler(modify_Click);
                panel.Controls.Add(pic);


                TextBox t = new TextBox();
                t.Name = "text_" + n.ID;
                t.Text = n.Title;
                t.Width = 152;
                t.Height = 35;
                t.Font = new System.Drawing.Font("宋体", 14);
                t.BackColor = Color.FromArgb( 250, 250, 250);
               
                t.Left = 72;
                t.Top = 12;
                t.BorderStyle = BorderStyle.None;
                panel.Controls.Add(t);

                PictureBox pic2 = new PictureBox();
                pic2.Name = "del_" + n.ID;
                pic2.Image = StickyNotes.Properties.Resources.ic_delete_black_24dp_1x;
                pic2.Left = 242;
                pic2.Top = 12;
                pic2.Width = 24;
                pic2.Height = 24;
                pic2.Click += new EventHandler(b_Click);
                panel.Controls.Add(pic2);

                y += panel.Height;
                //Button b = new Button();
                //b.Click +=new  EventHandler(b_Click);
                //b.Name = "del_" + n.ID;
                //b.Text = "删除";
                //b.Left = x + t.Width+10;
                //b.Top = y;
                //b.BackColor = Color.FromArgb(236, 240, 241);
                //this.Controls.Add(b);
                //Button modifyBtn = new Button();
                //modifyBtn.Name = "mod_" + n.ID;
                //modifyBtn.Text = "修改";
                //modifyBtn.Left = x + t.Width + b.Width + 10;
                //modifyBtn.Top = y;
                //modifyBtn.BackColor = Color.FromArgb(236, 240, 241);
                //modifyBtn.Click += new EventHandler(modify_Click);
                //this.Controls.Add(modifyBtn);
            }
        }
        private void b_Click(object sender, EventArgs e)
        {
            PictureBox b = sender as PictureBox;
            string ID = b.Name.Split('_')[1];
            bool isDelete = new Json().DeleteNote(ID);
            if (isDelete)
            {
                new NotesManager().LoadNotes();
            }
            
        }
        private void modify_Click(object sender,EventArgs e)
        {
            Modify d = Modify.GetModify();
            
            PictureBox b = sender as PictureBox ;
            Json j = new Json();
            string ID = b.Name.Split('_')[1];
            NotesData n = j.getNote(ID);
            try
            {
                TextBox Title = d.Controls.Find("Title", true)[0] as TextBox;
                Title.Text = n.Title;
                TextBox Note = d.Controls.Find("Note", true)[0] as TextBox;
                Note.Text = n.Note;
                Label label = d.Controls.Find("label1", true)[0] as Label;
                label.Text = n.ID.ToString();
            }
            catch
            {
                throw new Exception();
            }
            
            d.Show();
            this.Close();
            this.Dispose();
            //else
            //{
            //    DialogResult result = MessageBox.Show("修改失败", "操作提示", MessageBoxButtons.OKCancel);
            //}
            
        }

        private void Manager_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_SYSCOMMAND, SC_MOVE + HTCAPTION, 0);//*********************调用移动无窗体控件函数
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
