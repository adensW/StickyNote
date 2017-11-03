using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace StickyNotes.Controller
{
    public class NotesData
    {

        public int ID { get; set; }
        public string Title { get; set; }
        public string Note { get; set; }
        public int x { get; set; }
        public int y { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }

        public int ColorR { get; set; }
        public int ColorG { get; set; }
        public int ColorB { get; set; }

    }
}
