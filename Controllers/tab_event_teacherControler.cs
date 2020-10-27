using Calendar;
using Calendar.Models;
using System.Collections.Generic;
using System.Linq;
using System;

namespace Calendar.Controllers
{
    public class tab_event_teacherControler
    {
        private Context context;
        public void Add(tab_event_teacher event_teacher)
        {

            using (context = new Context())
            {
                context.Event_teachers.Add(event_teacher);
                context.SaveChanges();
            }
        }
        /*public void Delete(string Name)
        {
            using (context = new Context())
            {
                var item = context.Event_teachers.ToList().Find(x => x.name == Name);
                if (item != null)
                {
                    context.Event_teachers.Remove(item);
                    context.SaveChanges();
                }
            }
        }*/
        /*public tab_event_teacher Get(string Name)
        {
            using (context = new Context())
            {
                return context.Event_teachers.ToList().Find(x => x.name == Name);
            }
        }*/
        public tab_event_teacher Get(int id)
        {
            using (context = new Context())
            {
                return context.Event_teachers.Find(id);
            }
        }
        public List<tab_event_teacher> GetAll()
        {
            using (context = new Context())
            {
                return context.Event_teachers.ToList();
            }
        }
        public void Update(tab_event_teacher event_teacher)
        {
            using (context = new Context())
            {
                var item = context.Event_teachers.Find(event_teacher.id);
                if (item != null)
                {
                    context.Entry(item).CurrentValues.SetValues(event_teacher);
                    context.SaveChanges();
                }
            }
        }
    }
}
