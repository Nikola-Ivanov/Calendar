using Calendar;
using Calendar.Models;
using System.Collections.Generic;
using System.Linq;
using System;

namespace Calendar.Controllers
{
    public class tab_teacherCotroler
    {
        private Context context;
        public void Add(tab_teacher teacher)
        {

            using (context = new Context())
            {
                context.Teachers.Add(teacher);
                context.SaveChanges();
            }
        }
        public void Delete(string Name)
        {
            using (context = new Context())
            {
                var item = context.Teachers.ToList().Find(x => x.name == Name);
                if (item != null)
                {
                    context.Teachers.Remove(item);
                    context.SaveChanges();
                }
            }
        }
        public tab_teacher Get(string Name)
        {
            using (context = new Context())
            {
                return context.Teachers.ToList().Find(x => x.name == Name);
            }
        }
        public tab_teacher Get(int id)
        {
            using (context = new Context())
            {
                return context.Teachers.Find(id);
            }
        }
        public List<tab_teacher> GetAll()
        {
            using (context = new Context())
            {
                return context.Teachers.ToList();
            }
        }
        public void Update(tab_teacher teacher)
        {
            using (context = new Context())
            {
                var item = context.Teachers.Find(teacher.id);
                if (item != null)
                {
                    context.Entry(item).CurrentValues.SetValues(teacher);
                    context.SaveChanges();
                }
            }
        }
    }
}
