using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
namespace countrycity.data

{
    public class context:DbContext
    {

        public DbSet<Country> Countries { get; set; }
        public DbSet<City> Cities { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer("data source=localhost; initial catalog =countrycity;   integrated security=true");
            base.OnConfiguring(optionsBuilder);

        }
    }
   

}
