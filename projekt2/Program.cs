using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt2
{
    class Program
    {
        static void Main(string[] args)
        {
            Osoba osoba = new Osoba();

            Console.WriteLine("Podaj wiek osoby: ");
            string wiekString = Console.ReadLine();

            int dl = wiekString.Length;
            //wiekString.Length = 99;

            //osoba.wiek = byte.Parse(wiekString);
            osoba.SetWiek(byte.Parse(wiekString));
            osoba.Wiek = byte.Parse(wiekString);
            
            //byte w = osoba.wiek;
            byte w = osoba.GetWiek();
            byte ww = osoba.Wiek;
        }
    }
}
