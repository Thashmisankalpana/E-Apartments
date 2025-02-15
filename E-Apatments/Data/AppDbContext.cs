using E_Apatments.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Apatments.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<ApartmentDetai> ApartmentDetais { get; set; }

        public DbSet<CustomRegi> CustomRegis { get; set; }

        public DbSet<ApartmentAllDeta> ApartmentAllDetas { get; set; }
        public DbSet<ExtendDetail> ExtendDetails { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
