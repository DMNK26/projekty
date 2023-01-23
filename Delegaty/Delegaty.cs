using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegaty
{
    class Delegaty
    {
        delegate int OperacjaDoWykonaniaDelegate(int a, int b);
        delegate void WyswietlWynikOperacjiDelegate(int w, char o);
        public void testDelegat()
        {
            Console.WriteLine("Podaj pierwszą liczbę: ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj drugą liczbę: ");
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj operacje do wykonania: ");
            char operacja = Console.ReadLine()[0];
            int wynik = 0;
            
            //wersja 1
            switch(operacja)
            {
                case '+':
                    wynik = Suma(x, y);
                    break;
                case '*':
                    wynik = Iloczyn(x, y);
                    break;
                default:
                    wynik = 0;
                    break;
            }
            WyswietlWynikOperacji(wynik, operacja);

            //wersja 2 delegaty
            OperacjaDoWykonaniaDelegate operacjaDoWykonaniaDelegate;
            switch (operacja)
            {
                case '+':
                    operacjaDoWykonaniaDelegate = Suma;
                    break;
                case '*':
                    operacjaDoWykonaniaDelegate = Iloczyn;
                    break;
                default:
                    operacjaDoWykonaniaDelegate = null;
                    break;
            }
            if (operacjaDoWykonaniaDelegate == null)
                wynik = 0;
            else
                wynik = operacjaDoWykonaniaDelegate(x, y);
            WyswietlWynikOperacjiDelegate wyswietlWynikOperacjiDelegate = WyswietlWynikOperacji;
            WyswietlWynikOperacji(wynik, operacja);

            //wersja 3 funkcje, akcje
            Func<int, int, int> doWykonaniaFunc;
            switch (operacja)
            {
                case '+':
                    doWykonaniaFunc = Suma;
                    break;
                case '*':
                    doWykonaniaFunc = Iloczyn;
                    break;
                default:
                    doWykonaniaFunc = null;
                    break;
            }
            if (doWykonaniaFunc == null)
                wynik = 0;
            else
                wynik = doWykonaniaFunc(x, y);
            Action<int, char> wyswietlWynikAct = WyswietlWynikOperacji;
            wyswietlWynikAct(wynik, operacja);

            //wersja 4 funckje anonimowe
            Func<int, int, int> operacjaDoWykonaniaAnonimowa;
            switch (operacja)
            {
                case '+':
                    operacjaDoWykonaniaAnonimowa = delegate (int xx, int yy) 
                                                                {
                                                                    return xx + yy;
                                                                };
                    break;
                case '*':
                    operacjaDoWykonaniaAnonimowa = delegate (int xx, int yy)
                                                                {
                                                                    return xx * yy;
                                                                };
                    break;
                default:
                    operacjaDoWykonaniaAnonimowa = null;
                    break;
            }
            if (operacjaDoWykonaniaAnonimowa == null)
                wynik = 0;
            else
                wynik = operacjaDoWykonaniaAnonimowa(x, y);
            Action<int, char> wyswietlWynikAnonimowa = delegate (int w, char o)
                                                                 {
                                                                     Console.WriteLine($"Wynik operacji {o} to {w}");
                                                                 };
            wyswietlWynikAnonimowa(wynik, operacja);

            //wersja 5 lambda

            Func<int, int, int> operacjaDoWykonaniaLambda;
            switch (operacja)
            {
                case '+':
                    operacjaDoWykonaniaLambda = (xx, yy) =>
                    {
                        return xx + yy;
                    };
                    break;
                case '*':
                    operacjaDoWykonaniaLambda = (xx, yy) => xx * yy;
                    break;
                default:
                    operacjaDoWykonaniaLambda = null;
                    break;
            }
            if (operacjaDoWykonaniaLambda == null)
                wynik = 0;
            else
                wynik = operacjaDoWykonaniaLambda(x, y);

            Action<int, char> wyswietlWynikLamda = (w, o) => Console.WriteLine($"Wynik operacji {o} to {w}");
            wyswietlWynikLamda(wynik, operacja);
        }

        private void WyswietlWynikOperacji(int wynik, char operacja)
        {
            Console.WriteLine($"Wynik operacji {operacja} to {wynik}");
        }

        private int Iloczyn(int x, int y)
        {
            return x * y;
        }

        private int Suma(int x, int y)
        {
            return x + y;
        }
    }
}
