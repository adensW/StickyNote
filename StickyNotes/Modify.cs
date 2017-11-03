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
using Newtonsoft.Json;
using StickyNotes.View;
namespace StickyNotes
{
    public partial class Modify : Form
    {
        private Modify()
        {
            InitializeComponent();
        }
        private static Modify _modify = null;
        public static Modify GetModify()
        {
            if (_modify == null)
            {
                _modify = new Modify();
            }
            return _modify;
        }
        private void Modify_FormClosing(object sender, FormClosingEventArgs e)
        {
            //当你关闭窗体的时候 让窗体2的资源不被释放
            _modify = new Modify();
        }
        private void ConfirmBtn_Click(object sender, EventArgs e)
        {
            string Title = this.Title.Text;
            string Note = this.Note.Text;
            if (Title == "")
            {
                DialogResult result = MessageBox.Show("标题未填写,是否使用日期代替", "操作提示", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    Title = DateTime.Now.ToLocalTime().ToString();
                    this.Title.Text = Title;
                }
                else
                {
                    return;
                }
            }
            if (Note == "")
            {
                DialogResult result = MessageBox.Show("您还没有写便签内容呢。", "操作提示", MessageBoxButtons.OK);
                if(result==DialogResult.OK)
                {
                    return;
                }
            }
            Json j = new Json();
            j.JsonModify(Title, Note,label1.Text);
            new NotesManager().LoadNotes();
            this.Close();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            this.Title.Text = "";
            this.Note.Text = "";
        }

     

     
       
    }
}
