using Calendar;
using Calendar.Models;
using System.Collections.Generic;
using System.Linq;
using System;

namespace Calendar.Controllers
{
    public class tab_userCotroler
    {
        private Context context;
        public void Add(tab_user user)
        {

            using (context = new Context())
            {
                context.Users.Add(user);
                context.SaveChanges();
            }
        }
        /*public void Delete(string Name)
        {
            using (context = new Context())
            {
                var item = context.Users.ToList().Find(x => x.name == Name);
                if (item != null)
                {
                    context.Users.Remove(item);
                    context.SaveChanges();
                }
            }
        }
        public tab_user Get(string Name)
        {
            using (context = new Context())
            {
                return context.Users.ToList().Find(x => x.name == Name);
            }
        }*/
        public tab_user Get(int id)
        {
            using (context = new Context())
            {
                return context.Users.Find(id);
            }
        }
        public List<tab_user> GetAll()
        {
            using (context = new Context())
            {
                return context.Users.ToList();
            }
        }
        public void Update(tab_user user)
        {
            using (context = new Context())
            {
                var item = context.Users.Find(user.id);
                if (item != null)
                {
                    context.Entry(item).CurrentValues.SetValues(user);
                    context.SaveChanges();
                }
            }
        }
    }
}
