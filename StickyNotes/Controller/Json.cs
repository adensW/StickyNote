using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace StickyNotes.Controller
{
    class Json
    {
        static string defaultFileName = "data.json";
        static string defaultFoldName = "Data";
        
        public bool JsonCreate()
        {
            string path = Application.StartupPath + "\\" + defaultFoldName;
            string newpath = path+"\\" + defaultFileName;
            Directory.CreateDirectory(path);
            if (!System.IO.File.Exists(newpath))
            {
                System.IO.File.Create(newpath).Close();
                
            }
            return true;
        }
        public bool SaveMainPos(int x, int y)
        {
            string path = Application.StartupPath + "\\" + defaultFoldName;
            string newpath = path + "\\" + "mainpos.json";
            Directory.CreateDirectory(path);
            if(!JsonExist(newpath))
            {
                if (!System.IO.File.Exists(newpath))
                {
                    System.IO.File.Create(newpath).Close();

                }
            }
            int[] pos = new int[2];
            pos[0] = x;
            pos[1] = y;
            string mainpos = JsonConvert.SerializeObject(pos);
            System.IO.File.WriteAllText(newpath, mainpos);
            return true;
        }
        public int[] GetMainPos()
        {
            int[] pos ;
            string path = Application.StartupPath + "\\" + defaultFoldName + "\\" + "mainpos.json";
            if (!JsonExist(path))
            {
                System.IO.File.Create(path).Close();
            }
            string text = System.IO.File.ReadAllText(path);

            pos= JsonConvert.DeserializeObject<int[]>(text);
            return pos;
        }
        public bool JsonExist(string path)
        {
            if (System.IO.File.Exists(path))
            {
                return true;
            }
            return false;
        }
        public bool JsonWrite(string Title,string Note,int x,int y)
        {
            string path = Application.StartupPath + "\\" + defaultFoldName + "\\" + defaultFileName;
            if (!JsonExist(path))
            {
                JsonCreate();
            }

            string text = System.IO.File.ReadAllText(path);

            //List<NotesData> NoteList = JsonConvert.DeserializeObject<List<NotesData>>(text);
            //if (NoteList == null)
            //{
            //    NoteList = new List<NotesData>();
            //}
            List<NotesData> list = new List<NotesData>();
            NotesData[] node = JsonConvert.DeserializeObject<NotesData[]>(text);
            if (node != null)
            {
                foreach (NotesData i in node)
                {
                    list.Add(i);
                }
            }
            
            //List<NotesData> NoteList = new List<NotesData>();
            NotesData n = new NotesData();
            n.ID = GetNoteNum()+1;
            n.Title = Title;
            n.Note = Note;
            n.x = x;
            n.y = y;
            n.ColorR = 130;
            n.ColorG =177;
            n.ColorB = 255;
            //NoteList.Add(n);
            //node[node.Length + 1] = n;
            list.Add(n);
            string JsonData = JsonConvert.SerializeObject(list);

            System.IO.File.WriteAllText(path, JsonData);
            //System.IO.StreamWriter file;
            //file = File.AppendText(path);    
            //file.WriteLine(JsonData);
            //file.Close();
            return true;
        }
        public bool JsonWrite(List<NotesData> list)
        {
            string path = Application.StartupPath + "\\" + defaultFoldName + "\\" + defaultFileName;
            string JsonData = JsonConvert.SerializeObject(list);
            try
            {
                System.IO.File.WriteAllText(path, JsonData);
            }
            catch
            {
              
                return false;
            }

            return true;
        }
        public bool JsonModify(string Title, string Note,string ID)
        {
            List<NotesData> list = new List<NotesData>();
            list=GetAllNotes();
           
            int index = Convert.ToInt16(ID);
            NotesData n = new NotesData();
            n.ID = index;
            n.Title = Title;
            n.Note = Note;
            foreach (NotesData element in list)
            {
                if (element.ID == index)
                {
                    n.x = element.x;
                    n.y = element.y;
                    list.Remove(element);
                    break;
                }
            }
            
            list.Add(n);
            return JsonWrite(list);
            
        }
        public bool JsonModifyPos(string Title, string Note, string ID, int x, int y,int width,int height,int ColorR,int ColorG,int ColorB)
        {
            List<NotesData> list = new List<NotesData>();
            list = GetAllNotes();

            int index = Convert.ToInt16(ID);

            foreach (NotesData element in list)
            {
                if (element.ID == index)
                {
                    list.Remove(element);
                    break;
                }
            }
            NotesData n = new NotesData();
            n.ID = index;
            n.Title = Title;
            n.Note = Note;
            n.x = x;
            n.y = y;
            n.Width = width;
            n.Height = height;
            n.ColorR = ColorR;
            n.ColorG = ColorG;
            n.ColorB = ColorB;
            list.Add(n);
            return JsonWrite(list);
        }
        public int GetNoteNum()
        {
            string path = Application.StartupPath + "\\" + defaultFoldName + "\\" + defaultFileName;
            string text = System.IO.File.ReadAllText(path);

            List<NotesData> list = JsonConvert.DeserializeObject<List<NotesData>>(text);
            if(list==null)
            {
                return 0;
            }
            else
            {
                return list.Count;
            }
            
        }
        public List<NotesData> GetAllNotes()
        {
            string path = Application.StartupPath + "\\" + defaultFoldName + "\\" + defaultFileName;
            if (!JsonExist(path))
            {
                JsonCreate();
            }
            string text = System.IO.File.ReadAllText(path);

            List<NotesData> list = JsonConvert.DeserializeObject<List<NotesData>>(text);
            return list;
        }

        public bool DeleteNote(string ID)
        {
            List<NotesData> list = new List<NotesData>();

            list = GetAllNotes();
            int index = Convert.ToInt16(ID);
            NotesData n = new NotesData();
            foreach(NotesData element in list)
            {
                if (element.ID == index)
                {
                    n = element;
                }
            }
            list.Remove(n);
            
            if (JsonWrite(list))
            {
                return true;
            }
            else
            {
                return false;
            }
          
        }

        public NotesData getNote(string ID)
        {
            List<NotesData> list = new List<NotesData>();

            list = GetAllNotes();
            int index = Convert.ToInt16(ID);
            NotesData n = new NotesData();
            foreach (NotesData element in list)
            {
                if (element.ID == index)
                {
                    n = element;
                }
            }
            return n;
        }
       
    }
}
