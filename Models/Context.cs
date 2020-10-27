using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calendar.Models
{
    public class Context:DbContext
    {
        public Context() : base() { }   

        public DbSet<tab_course> Courses { get; set; }
        public DbSet<tab_event_teacher> Event_teachers { get; set; }
        public DbSet<tab_event> Events { get; set; }
        public DbSet<tab_teacher> Teachers { get; set; }
        public DbSet<tab_user> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS; Database=Calendar; Integrated Security=true;");
        }
    }
}
