using System;

namespace ConsoleApp1
{
    class Osoba
    {
        public string imie;

        public static int ileUtworzonoObiektow = 0;
        public Osoba()
        {
            ileUtworzonoObiektow++;
        }

        public static void Info()
        {
            Console.WriteLine("Utworzono: " + ileUtworzonoObiektow);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Osoba os = new Osoba();
            os = new Osoba();
            os = new Osoba();
            os = new Osoba();
            os = new Osoba();

            Osoba.Info();

            Console.ReadLine();
        }
    }
}
