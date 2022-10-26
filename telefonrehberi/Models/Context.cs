using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace telefonrehberi.Models
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-NPKTSP7;database=agarthapersonel;integrated security=true;");
        }
        public DbSet<departmanlar> departmanlars { get; set; }
        public DbSet<personel> personels { get; set; }
        public DbSet<Birim> birim { get; set; }
        public DbSet<Admin> admin { get; set; }
    }
}
