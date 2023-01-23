using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pesel.Model
{
    class Pesel
    {
        #region Metody
        private string numerPesel;
        private string miesiacSlowo;
        public string NumerPesel
        {
            get
            {
                numerPesel.ToString();
                return numerPesel;
            }
        }

        public string Plec
        {
            get
            {
                char cyfraPlec = numerPesel[9];
                int liczbaPlec = int.Parse(cyfraPlec.ToString());
                if (liczbaPlec % 2 == 0)
                    return "Kobieta";
                else
                    return "Mężczyzna";
            }
        }

        public string Data
        {
            get
            {
                string dzien = numerPesel[4].ToString() + numerPesel[5].ToString();

                string rokKoncowka = numerPesel[0].ToString() + numerPesel[1].ToString();
                string rok = "";
                string miesiacString = numerPesel[2].ToString() + numerPesel[3].ToString();
                int miesiac = int.Parse(miesiacString);

                #region Rok
                if (miesiac >= 81 && miesiac <= 92)
                    rok = "18" + rokKoncowka.ToString();
                else if (miesiac >= 1 && miesiac <= 12)
                    rok = "19" + rokKoncowka.ToString();
                else if (miesiac >= 21 && miesiac <= 32)
                    rok = "20" + rokKoncowka.ToString();
                else if (miesiac >= 41 && miesiac <= 52)
                    rok = "21" + rokKoncowka.ToString();
                else if (miesiac >= 41 && miesiac <= 52)
                    rok = "21" + rokKoncowka.ToString();
                else if (miesiac >= 61 && miesiac <= 72)
                    rok = "22" + rokKoncowka.ToString();
                #endregion

                #region Miesiąc
                if (miesiac == 81 | miesiac == 1 | miesiac == 21 | miesiac == 41 | miesiac == 61)
                    miesiacSlowo = "Styczeń";
                else if (miesiac == 82 | miesiac == 2 | miesiac == 22 | miesiac == 42 | miesiac == 62)
                    miesiacSlowo = "Luty";
                else if (miesiac == 83 | miesiac == 3 | miesiac == 23 | miesiac == 43 | miesiac == 63)
                    miesiacSlowo = "Marzec";
                else if (miesiac == 84 | miesiac == 4 | miesiac == 24 | miesiac == 44 | miesiac == 64)
                    miesiacSlowo = "Kwiecień";
                else if (miesiac == 85 | miesiac == 5 | miesiac == 25 | miesiac == 45 | miesiac == 65)
                    miesiacSlowo = "Maj";
                else if (miesiac == 86 | miesiac == 6 | miesiac == 26 | miesiac == 46 | miesiac == 66)
                    miesiacSlowo = "Czerwiec";
                else if (miesiac == 87 | miesiac == 7 | miesiac == 27 | miesiac == 47 | miesiac == 67)
                    miesiacSlowo = "Lipiec";
                else if (miesiac == 88 | miesiac == 8 | miesiac == 28 | miesiac == 48 | miesiac == 68)
                    miesiacSlowo = "Sierpień";
                else if (miesiac == 89 | miesiac == 9 | miesiac == 29 | miesiac == 49 | miesiac == 69)
                    miesiacSlowo = "Wrzesień";
                else if (miesiac == 90 | miesiac == 10 | miesiac == 30 | miesiac == 50 | miesiac == 70)
                    miesiacSlowo = "Październik";
                else if (miesiac == 91 | miesiac == 11 | miesiac == 31 | miesiac == 51 | miesiac == 71)
                    miesiacSlowo = "Listopad";
                else if (miesiac == 92 | miesiac == 12 | miesiac == 32 | miesiac == 52 | miesiac == 72)
                    miesiacSlowo = "Grudzień";
                #endregion

                string data = dzien.ToString() + " " + miesiacSlowo.ToString() + " " + rok.ToString();
                return data;
            }
        }
        /*
        public string CyfraKontolna
        {
            get
            {
                int[] pesel = new int[10];
                for(int i = 0; i < 10; i++)
                {
                    pesel[i] = int.Parse(numerPesel[i].ToString()); 
                }

                int[] wagaCyfr = { 1, 3, 7, 9, 1, 3, 7, 9, 1, 3 };
                int wynik;
                int suma = 0;
                string wynikString;
                int ostatniaCyfra;
                string sumaString;
                int s;
                int m;

                for(int j = 0; j < 10; j++)
                {
                    wynik = pesel[j] * wagaCyfr[j];
                    if(wynik >= 10)
                    {
                        wynikString = wynik.ToString();
                        ostatniaCyfra = int.Parse(wynikString[1].ToString());
                        suma = suma + ostatniaCyfra;
                    }
                    else
                    {
                        suma = suma + wynik;
                    }
                }
                sumaString = suma.ToString();
                s = int.Parse(sumaString[1].ToString());

                if(s == 0)
                {
                    m = 0;
                }
                else
                {
                    m = 10 - s;
                }
                return m.ToString();
            }
        }*/
        #endregion
        
        public Pesel(string numer)
        {
            numerPesel = numer;
            WalidacjaNumeruPesel();
        }

        private void WalidacjaNumeruPesel()
        {
            WalidacjaIloscZnakow();
            WalidacjaPoprawnosciZnakow();
            WalidacjaDzien();
            WalidacjaMiesiac();
            WalidacjaCyfryKontrolnej();
        }

        #region Walidacje
        private void Komunikat(string słowo, int typ)
        {
            if(typ == 1)
                throw new Exception("Nieodpowiedni " + słowo + "!");
            else if(typ == 2)
                throw new Exception("Nieodpowiednia " + słowo + "!");
            else if(typ == 3)
                throw new Exception("Nieodpowiednie " + słowo + "!");

        }

        private void WalidacjaIloscZnakow()
        {
            if (numerPesel.Length < 11)
            {
                Komunikat("ilość znaków (za mało)", 2);
            }
            else if(numerPesel.Length > 11)
            {
                Komunikat("ilość znaków (za dużo)", 2);
            }
        }

        private void WalidacjaPoprawnosciZnakow()
        {
            for (int i = 0; i < numerPesel.Length; i++)
            {
                if(numerPesel[i] < '0' || numerPesel[i] > '9')
                {
                    Komunikat("znaki", 3);
                }

            }
        }

        private void WalidacjaDzien()
        {
            string dzienString = numerPesel[4].ToString() + numerPesel[5].ToString();
            int dzien = int.Parse(dzienString);

            string miesiacString = numerPesel[2].ToString() + numerPesel[3].ToString();
            int miesiac = int.Parse(miesiacString);

            string rokKoncowka = numerPesel[0].ToString() + numerPesel[1].ToString();
            int rok = int.Parse(rokKoncowka);
                        
            if (miesiac == 2 || miesiac == 22 || miesiac == 42 || miesiac == 62 || miesiac == 82)
            {
                if (rok % 4 == 0 && rok % 100 != 0 || rok % 400 == 0)
                {
                    if (dzien > 29 || dzien < 1)
                        Komunikat("dzień", 1);
                }
                else
                {
                    if (dzien > 28 || dzien < 1)
                        Komunikat("dzień", 1);
                }
            }
            else if (miesiac % 2 != 0 || miesiac == 8 || miesiac == 28 || miesiac == 48 || miesiac == 68 || miesiac == 88)
            { 
                if (dzien > 31 || dzien < 1)
                    Komunikat("dzień", 1);
            }
            else if(miesiac % 2 == 0)
            {
                if(dzien > 30 || dzien < 1)
                    Komunikat("dzień", 1);
            }
        }

        private void WalidacjaMiesiac()
        {
            string miesiacString = numerPesel[2].ToString() + numerPesel[3].ToString();
            int miesiac = int.Parse(miesiacString);
            int wynik=0;

            if(miesiac > 92 || miesiac < 1)
            {
                Komunikat("miesiąc", 1);
            }
            else if(miesiac >= 1 && miesiac <= 20)
            {
                wynik = 12 - miesiac;
            }
            else if (miesiac >= 21 && miesiac <= 40)
            {
                wynik = 32 - miesiac;
            }
            else if (miesiac >= 41 && miesiac <= 60)
            {
                wynik = 52 - miesiac;
            }
            else if (miesiac >= 61 && miesiac <= 80)
            {
                wynik = 72 - miesiac;
            }
            else if (miesiac >= 81 && miesiac <= 100)
            {
                wynik = 92 - miesiac;
            }


            if (wynik < 0)
            {
                Komunikat("miesiąc", 1);
            }
        }

        private void WalidacjaCyfryKontrolnej()
        {
            int cyfraKontrolna = int.Parse(numerPesel[10].ToString());
            int[] pesel = new int[10];
            for (int i = 0; i < 10; i++)
            {
                pesel[i] = int.Parse(numerPesel[i].ToString());
            }

            int[] wagaCyfr = { 1, 3, 7, 9, 1, 3, 7, 9, 1, 3 };
            int wynik;
            int suma = 0;
            string wynikString;
            int ostatniaCyfra;
            string sumaString;
            int s;
            int m;

            for (int j = 0; j < 10; j++)
            {
                wynik = pesel[j] * wagaCyfr[j];
                if (wynik >= 10)
                {
                    wynikString = wynik.ToString();
                    ostatniaCyfra = int.Parse(wynikString[1].ToString());
                    suma = suma + ostatniaCyfra;
                }
                else
                {
                    suma = suma + wynik;
                }
            }
            sumaString = suma.ToString();
            s = int.Parse(sumaString[1].ToString());

            if (s == 0)
            {
                m = 0;
            }
            else
            {
                m = 10 - s;
            }
            
            if(cyfraKontrolna != m)
            {
                Komunikat("cyfra kontrolna", 2);
            }
        }
        #endregion
    }
}
