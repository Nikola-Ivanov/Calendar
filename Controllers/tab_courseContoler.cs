using Calendar;
using Calendar.Models;
using System.Collections.Generic;
using System.Linq;
using System;

namespace Calendar.Controllers
{
    public class tab_courseCotroler
    {
        private Context context;
        public void Add(tab_course course)
        {

            using (context = new Context())
            {
                context.Courses.Add(course);
                context.SaveChanges();
            }
        }
        public void Delete(string Name)
        {
            using (context = new Context())
            {
                var item = context.Courses.ToList().Find(x => x.name == Name);
                if (item != null)
                {
                    context.Courses.Remove(item);
                    context.SaveChanges();
                }
            }
        }
        public tab_course Get(string Name)
        {
            using (context = new Context())
            {
                return context.Courses.ToList().Find(x => x.name == Name);
            }
        }
        public tab_course Get(int id)
        {
            using (context = new Context())
            {
                return context.Courses.Find(id);
            }
        }
        public List<tab_course> GetAll()
        {
            using (context = new Context())
            {
                return context.Courses.ToList();
            }
        }
        public void Update(tab_course course)
        {
            using (context = new Context())
            {
                var item = context.Courses.Find(course.id);
                if (item != null)
                {
                    context.Entry(item).CurrentValues.SetValues(course);
                    context.SaveChanges();
                }
            }
        }
    }
}
