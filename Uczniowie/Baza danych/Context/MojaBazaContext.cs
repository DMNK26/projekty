using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Uczniowie.Baza_danych.Model;

namespace Uczniowie.Baza_danych.Context
{
    class MojaBazaContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Filename=uczniowieBazaDanych.db");

            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<Uczen> Uczniowie { get; set; }
        public DbSet<Klasa> Klasy { get; set; }
    }
}
