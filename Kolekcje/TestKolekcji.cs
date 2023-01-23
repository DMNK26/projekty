using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolekcje
{
    class Osoba
    {
        public string imie, nazwisko;
        public byte wiek;
    }
    class TestKolekcji
    {
        public void SortujTablice(int[] tablica)
        {
            for(int i=0; i < tablica.Length; i++)
            {
                for(int j = 0; j < tablica.Length - 1; j++)
                {
                    if(tablica[j] > tablica[j+1])
                    {
                        int tmp = tablica[j];
                        tablica[j] = tablica[j + 1];
                        tablica[j + 1] = tmp;
                    }
                }
            }
        }
        public void TestTablic()
        {
            int[] tablicaCalkowitych = new int[5];
            tablicaCalkowitych[0] = 7;
            tablicaCalkowitych[1] = 3;
            tablicaCalkowitych[2] = 5;
            tablicaCalkowitych[3] = 1;
            tablicaCalkowitych[4] = 9;

            for(int i = 0; i < tablicaCalkowitych.Length; i++)
            {
                Console.WriteLine(tablicaCalkowitych[i] + ",");
            }
            Console.WriteLine();

            SortujTablice(tablicaCalkowitych);

            foreach(int elementTablicy in tablicaCalkowitych)
            {
                Console.WriteLine(elementTablicy + ",");
            }
            Console.WriteLine();
        }

        public void Test_tablic_z_obiektami()
        {

        }
    }
}
