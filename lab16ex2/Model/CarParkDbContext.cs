using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab16ex2.Model
{
    internal class CarParkDbContext : DbContext
    {
        public DbSet<Car>Cars { get; set; }
        public DbSet<Manufacturer> Manufacturers { get; set; }

        public CarParkDbContext()
        {
            this.Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\sandu\Desktop\C#\Proiecte C#\lab16ex1\lab16ex2\AutovehiculeDb.mdf"";Integrated Security=True")
                          .LogTo(Console.Write);
        }
    }
    
  
}
