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
using StickyNotes.Controller;
using StickyNotes.View;
namespace StickyNotes
{
    public partial class NoteModel : Form
    {
        [DllImport("user32.dll")]//*********************拖动无窗体的控件
        public static extern bool ReleaseCapture();
        [DllImport("user32.dll")]
        public static extern bool SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);
        public const int WM_SYSCOMMAND = 0x0112;
        public const int SC_MOVE = 0xF010;
        public const int HTCAPTION = 0x0002;
        public NoteModel()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None; // no borders
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.ResizeRedraw, true); // this is to avoid visual artifacts
            
        }

        private bool MouseDownFlag = false;
        private void NoteModel_MouseDown(object sender, MouseEventArgs e)
        {
            MouseDownFlag = true;
        }
        private void NoteModel_MouseMove(object sender, MouseEventArgs e)
        {
            if (MouseDownFlag)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_SYSCOMMAND, SC_MOVE + HTCAPTION, 0);//*********************调用移动无窗体控件函数
                UpdateNote();
            }
        }
        private void NoteModel_MouseUp(object sender, MouseEventArgs e)
        {
            MouseDownFlag = false;
        }
        private void NoteModel_MouseLeave(object sender, EventArgs e)
        {
            MouseDownFlag = false;
        }
        private void UpdateNote()
        {
            Point pos = this.Location;
            Json j = new Json();

            j.JsonModifyPos(this.Title.Text, this.DataNote.Text, this.label1.Text, pos.X, pos.Y, this.Size.Width,this.Size.Height, this.BackColor.R, this.BackColor.G, this.BackColor.B);

        }

        private void NoteModel_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            TextBox t = sender as TextBox;
            //t.SelectionLength=0;
            t.SelectionStart = t.TextLength;
            t.ReadOnly = false;
            //this.LostFocus += new EventHandler(NoteModel_LostFocus);
        }
        private void NoteModel_LostFocus(object sender, EventArgs e)
        {

            UpdateNote();
            TextBox t = sender as TextBox;
            t.ReadOnly = true;

        }
        //protected override void OnPaint(PaintEventArgs e) // you can safely omit this method if you want
        //{
        //    e.Graphics.FillRectangle(Brushes.Green, Top);
        //    e.Graphics.FillRectangle(Brushes.Green, Left);
        //    e.Graphics.FillRectangle(Brushes.Green, Right);
        //    e.Graphics.FillRectangle(Brushes.Green, Bottom);
        //}

        private const int
            HTLEFT = 10,
            HTRIGHT = 11,
            HTTOP = 12,
            HTTOPLEFT = 13,
            HTTOPRIGHT = 14,
            HTBOTTOM = 15,
            HTBOTTOMLEFT = 16,
            HTBOTTOMRIGHT = 17;

        const int Bound = 10; // you can rename this variable if you like

        Rectangle Top { get { return new Rectangle(0, 0, this.ClientSize.Width, Bound); } }
        Rectangle Left { get { return new Rectangle(0, 0, Bound, this.ClientSize.Height); } }
        Rectangle Bottom { get { return new Rectangle(0, this.ClientSize.Height - Bound, this.ClientSize.Width, Bound); } }
        Rectangle Right { get { return new Rectangle(this.ClientSize.Width - Bound, 0, Bound, this.ClientSize.Height); } }

        Rectangle TopLeft { get { return new Rectangle(0, 0, Bound, Bound); } }
        Rectangle TopRight { get { return new Rectangle(this.ClientSize.Width - Bound, 0, Bound, Bound); } }
        Rectangle BottomLeft { get { return new Rectangle(0, this.ClientSize.Height - Bound, Bound, Bound); } }
        Rectangle BottomRight { get { return new Rectangle(this.ClientSize.Width - Bound, this.ClientSize.Height - Bound, Bound, Bound); } }


        protected override void WndProc(ref Message message)
        {
            base.WndProc(ref message);

            if (message.Msg == 0x84) // WM_NCHITTEST
            {
                var cursor = this.PointToClient(Cursor.Position);

                if (TopLeft.Contains(cursor)) message.Result = (IntPtr)HTTOPLEFT;
                else if (TopRight.Contains(cursor)) message.Result = (IntPtr)HTTOPRIGHT;
                else if (BottomLeft.Contains(cursor)) message.Result = (IntPtr)HTBOTTOMLEFT;
                else if (BottomRight.Contains(cursor)) message.Result = (IntPtr)HTBOTTOMRIGHT;

                else if (Top.Contains(cursor)) message.Result = (IntPtr)HTTOP;
                else if (Left.Contains(cursor)) message.Result = (IntPtr)HTLEFT;
                else if (Right.Contains(cursor)) message.Result = (IntPtr)HTRIGHT;
                else if (Bottom.Contains(cursor)) message.Result = (IntPtr)HTBOTTOM;
            }
        }

        private void ResizeAll(object sender, EventArgs e)
        {
            for (int i = 0; i < this.Controls.Count; i++)
            {
                //int width = this.Controls[i].Size.Width;
                //int height = this.Controls[i].Size.Height;
                //width = this.Size.Width-(this.Size.Width - width);
                //height = this.Size.Height-(this.Size.Height - height);
                //this.Controls[i].Size = new Size(width, height);
            }
            //this.Title.Size = new Size(this.Size.Width - 10, this.Title.Height);
            //this.DataNote.Size = new Size(this.Size.Width - 10, this.Size.Height - this.Title.Height - 10);
        }

        private void ColorPickerBtn_Click(object sender, EventArgs e)
        {
            this.colorDialog1.ShowDialog();
            Color color = this.colorDialog1.Color;
            SetColor(color);
        }
        private void ColorPickerBtn_Show(object sender, EventArgs e)
        {
            this.ColorPickerBtn.BackColor = Color.FromArgb(255-this.BackColor.R, this.BackColor.G, this.BackColor.B);
        }
        private void ColorPickerBtn_Hide(object sender, EventArgs e)
        {
            this.ColorPickerBtn.BackColor = Color.FromArgb(this.BackColor.R, this.BackColor.G, this.BackColor.B);

        }
        private void SetColor(Color color){
            
            this.BackColor = color;
            this.DataNote.BackColor = color;
            
            this.Title.BackColor = color;
            this.ColorPickerBtn.BackColor = color;
            if (color.GetBrightness() > 0.5f)
            {
                this.Title.ForeColor = Color.Black;
                this.DataNote.ForeColor = Color.Black;
            }
            else
            {
                this.Title.ForeColor = Color.White;
                this.DataNote.ForeColor = Color.White;
            }
            UpdateNote();
        }

        
        
        
    }
}
