using System;
using System.Collections.Generic;
using System.Text;

namespace projekt2
{
    class Osoba
    {
        //private string imie; 

        public string Imie
        {
            get;
            set;
        }

        private string nazwisko;

        public string Nazwisko
        {
            get
            {
                return nazwisko;
            }
            set
            {
                nazwisko = value;
            }
        }

        private byte wiek;

        public byte Wiek
        {
            get
            {
                return wiek;
            }
            set
            {
                if (value < 130)
                    wiek = value;
            }
        }
        public void SetWiek(byte w)
        {
            if(w < 130)
                wiek = w;
        }

        public byte GetWiek()
        {
            return wiek;
        }
    }
}
