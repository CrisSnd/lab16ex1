using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab16ex1.Model
{
    internal class StudentDBContext:DbContext
    {

        public DbSet<Student> Students{ get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) 
        {
            optionsBuilder.UseSqlServer(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\sandu\Desktop\C#\Proiecte C#\lab16ex1\lab16ex1\Students.mdf; Integrated Security = True").LogTo(Console.Write);
        }
    }
}
