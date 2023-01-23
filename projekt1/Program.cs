using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt1
{
    class Program
    {
        static void Main(string[] args)

        {
            /*
            string imie = "Smoa";
            string nazwisko = "Mirecki ";
            Console.WriteLine("MY NAME IS " + imie + nazwisko);
            Console.WriteLine("MY NAME IS {0} {1} ", imie, nazwisko);
            Console.WriteLine($"MY NAME IS {imie} {nazwisko}!");
            Console.WriteLine(@"km\h");


            int a;
            a = 5;
            Console.WriteLine("a = " + a);
            */

            Osoba osoba1 = new Osoba();

            osoba1.imie = "Masny";
            osoba1.nazwisko = "Ben";
            osoba1.wiek = 26;

           

            Osoba osoba2 = new Osoba();

            osoba2.imie = "Michal";
            osoba2.nazwisko = "Baron";
            osoba2.wiek = 26;

            Osoba osoba3 = osoba2;

            Osoba osoba4 = osoba1;

            osoba4.imie = "Potezny";

            /*
            Console.WriteLine("Osoba 1: " + osoba1.imie + " " + osoba1.nazwisko + " " + osoba1.wiek);
            Console.WriteLine("Osoba 2: " + osoba2.imie + " " + osoba2.nazwisko + " " + osoba2.wiek);
            Console.WriteLine("Osoba 3: " + osoba3.imie + " " + osoba3.nazwisko + " " + osoba3.wiek);
            Console.WriteLine("Osoba 4: " + osoba4.imie + " " + osoba4.nazwisko + " " + osoba4.wiek);
            */

            Console.WriteLine("--------------------------------");

            int x;
            // x = 5;
            // Console.WriteLine("X = " + x);
            // Metoda1(x);
            // Console.WriteLine("X = " + x);         
            // Metoda1_1(ref x);
            // Console.WriteLine("X = " + x);
            // x = Metoda1_2(x);
            Metoda1_3(out x);

            Console.WriteLine("--------------------------------");

            Osoba o = new Osoba();
            o.imie = "Przemek";
            Console.WriteLine("o.imie = " + o.imie);
            Metoda2(o);
            Console.WriteLine("o.imie = " + o.imie);



            Console.ReadLine();
        }

        static void Metoda1(int a)
        {
            Console.WriteLine("Metoda a = " + a);
            a++;
            Console.WriteLine("Metoda a = " + a);
        }
        static void Metoda1_1(ref int a)
        {
            Console.WriteLine("Metoda a = " + a);
            a++;
            Console.WriteLine("Metoda a = " + a);
        }
        static int Metoda1_2(int a)
        {
            Console.WriteLine("Metoda a = " + a);
            a++;
            Console.WriteLine("Metoda a = " + a);

            return a;
        }

        static void Metoda1_3(out int x)
        {
            Console.WriteLine("Podaj liczbe: ");
            string liczbaString = Console.ReadLine();
            x = int.Parse(liczbaString);
            Console.WriteLine("Podana liczba to: " + x);
        }

        static void Metoda2(Osoba oo)
        {
            Console.WriteLine("Metoda2 oo.imie = " + oo.imie);
            oo.imie = "Paweł";
            Console.WriteLine("Metoda2 oo.imie = " + oo.imie);
        }

    }
}