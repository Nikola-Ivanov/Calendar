using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calendar.Models
{
    public class tab_event
    {
        public int id { get; set; }
        public int children_age { get; set; }
        public string course { get; set; }
        public int level { get; set; }
        public List<tab_teacher> teacher { get; set; }
        public string location { get; set; }
        public int another_lesson { get; set; }
        public int children_nr { get; set; }
        public string zoom_Link { get; set; }
        public float fee { get; set; }
    }
}
