using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Seminarski_fitness_centar_IB130116.Models;

namespace Seminarski_fitness_centar_IB130116.DB
{
    public class MyContext: DbContext
    {
        //DbSet<...>
        public DbSet<User> Users { get; set; }
        public DbSet<Zaposlenik> Zaposlenici { get; set; }
        public DbSet<Admin> Admini { get; set; }
        public DbSet<Obavjestenje> Obavjestenja { get; set; }
        public DbSet<DolazakOdlazak> DolasciOdlasci { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=tcp:p1849dbserver.database.windows.net,1433;Initial Catalog=p1849_db;Persist Security Info=False;User ID=emirhasa;Password=9uB4?o9y;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
        }
    }
}
