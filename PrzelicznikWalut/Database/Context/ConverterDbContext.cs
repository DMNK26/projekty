using Microsoft.EntityFrameworkCore;
using Przelicznik.Database.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Przelicznik.Database.Context
{
    internal class ConverterDbContext : DbContext
    {
        //add-migration CreateDatabaseFirstMigration -outputdir Database/Migrations
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Filename = converterDb.db");
            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<UnitType> UnitTypes { get; set; }
        public DbSet<Unit> Units { get; set; }
        public DbSet<UnitConverter> UnitCoverters { get; set;}
    }
}
