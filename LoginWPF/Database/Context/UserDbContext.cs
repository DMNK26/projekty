using LoginWPF.Model.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginWPF.Database.Context
{
    public class UserDbContext: DbContext
    {
            //add-migration CreateDatabaseFirstMigration -outputdir Database/Migrations
            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                optionsBuilder.UseSqlite("Filename = usersDb.db");
                base.OnConfiguring(optionsBuilder);
            }

            public DbSet<User> Users { get; set; }
        
    }
}
