using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calendar.Models
{
    public class tab_teacher
    {
        public int id { get; set; }
        public string name { get; set; }
        public string e_mail { get; set; }
        public string phone_numbers { get; set; }
        public string free_hour { get; set; }
        public float fee { get; set; }
        public int worked_hours { get; set; }
    }
}
