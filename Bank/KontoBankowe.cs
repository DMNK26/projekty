using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class KontoBankowe
    {
        private string imie, nazwisko;
        private string numerKonta;
        private string haslo;
        private float saldo;

        private bool czyZalogowano;

        public KontoBankowe(string i, string n, string nK, string h)
        {
            imie = i;
            nazwisko = n;
            numerKonta = nK;
            haslo = h;
            saldo = 0;
            czyZalogowano = false;
        }

        public void Loguj(string h)
        {
            //czyZalogowano = (haslo == h);
            if (haslo == h)
                czyZalogowano = true;
        }

        public void Info()
        {
            if (czyZalogowano)
            {
                Console.WriteLine("------------------------------");
                Console.WriteLine("Wlasciciel " + imie + " " + nazwisko );
                Console.WriteLine("Numer konta " + numerKonta);
                Console.WriteLine("Saldo " + saldo);
                Console.WriteLine("------------------------------");
            }
            else
                Console.WriteLine("Nie zalogowano do konta");
        }

        public void Wplata(float kwota)
        {
            if (kwota > 0)
                saldo += kwota;
        }

        public bool Wyplata(float kwota)
        {
            if (kwota > 0 && saldo >= kwota && czyZalogowano)
            {
                saldo -= kwota;
                return true;
            }
            return false;
        }

        public void Przelew(float kwota, KontoBankowe kontoDocelowe)
        {
            if (Wyplata(kwota))
            {
                kontoDocelowe.Wplata(kwota);
                //kontoDocelowe.saldo += kwota;
            }
        }

    };
}
