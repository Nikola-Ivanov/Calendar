using Calendar;
using Calendar.Models;
using System.Collections.Generic;
using System.Linq;
using System;

namespace Calendar.Controllers
{
    public class tab_eventCotroler
    {
        private Context context;
        public void Add(tab_event events)
        {

            using (context = new Context())
            {
                context.Events.Add(events);
                context.SaveChanges();
            }
        }
        /*public void Delete(string Name)
        {
            using (context = new Context())
            {
                var item = context.Events.ToList().Find(x => x.name == Name);
                if (item != null)
                {
                    context.Events.Remove(item);
                    context.SaveChanges();
                }
            }
        }*/
        /*public tab_event Get(string Name)
        {
            using (context = new Context())
            {
                return context.Events.ToList().Find(x => x.name == Name);
            }
        }*/
        public tab_event Get(int id)
        {
            using (context = new Context())
            {
                return context.Events.Find(id);
            }
        }
        public List<tab_event> GetAll()
        {
            using (context = new Context())
            {
                return context.Events.ToList();
            }
        }
        public void Update(tab_event events)
        {
            using (context = new Context())
            {
                var item = context.Events.Find(events.id);
                if (item != null)
                {
                    context.Entry(item).CurrentValues.SetValues(events);
                    context.SaveChanges();
                }
            }
        }
    }
}
