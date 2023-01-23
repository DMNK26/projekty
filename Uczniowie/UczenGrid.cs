using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uczniowie.Baza_danych.Model;

namespace Uczniowie
{
    class UczenGrid
    {
        public int Id { get; set; }
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public int RokUrodzenia { get; set; }
        public string NazwaKlasy { get; set; }
        public Klasa Klasa { get; set; }
    }
}
