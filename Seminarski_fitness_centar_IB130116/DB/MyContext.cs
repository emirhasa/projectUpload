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
            optionsBuilder.UseSqlServer("Izbrisano for discretion");
        }
    }
}
