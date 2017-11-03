using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using StickyNotes.Controller;
namespace StickyNotes.View
{
    class NotesManager
    {
        private List<Form> notes;
        public NotesManager()
        {
            notes = new List<Form>();
        }
        public void CheckState()
        {
            FormCollection f = Application.OpenForms;
            int i = f.Count;
            for (int j = 0; j < i; j++)
            {
                if (f[j].Name == "Start" || f[j].Name == "DataIO")
                {
                    
                }
                else
                {
                    notes.Add(f[j]);
                }
            }
        }
        public void LoadNotes()
        {
            CheckState();
            if (notes != null)
            {
                foreach (Form f in notes)
                {
                    f.Close();
                }
            }
            List<NotesData> list = new List<NotesData>();
            list = new Json().GetAllNotes();
            if (list.Count != 0)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    NoteModel n = new NoteModel();
                    n.Location = new System.Drawing.Point(list[i].x,list[i].y);
                    n.Name = "Note"+list[i].ID;
                    n.Text = list[i].Title;
                    n.Size = new Size(list[i].Width, list[i].Height);
                    try
                    {
                        Color color = Color.FromArgb(list[i].ColorR, list[i].ColorG, list[i].ColorB);
                        n.BackColor = color;
                        TextBox title = n.Controls.Find("Title", true)[0] as TextBox;
                        title.Text = list[i].Title;
                        title.BackColor = color;
                        TextBox t = n.Controls.Find("DataNote", true)[0] as TextBox;
                        t.Text = list[i].Note;
                        t.BackColor = color;
                        Label l = n.Controls.Find("label1", true)[0] as Label;
                        l.Text = list[i].ID.ToString();
                        Button b = n.Controls.Find("ColorPickerBtn", true)[0] as Button;
                        b.BackColor = color;
                    }
                    catch
                    {
                        //
                    }
                   
                    n.Show();
                }
               
            }
            
            
        }
    }
}
