using System;

namespace Typ_Generyczny
{
    class PrzechowywanieDanych
    {
        private int dana;
        public PrzechowywanieDanych(int d)
        {
            dana = d;
        }
        public int GetDana()
        {
            return dana;
        }
        public void SetDana(int d)
        {
            dana = d;
        }
    }

    class PrzechowywanieDanych<T>
    {
        private T dana;
        public PrzechowywanieDanych(T d)
        {
            dana = d;
        }
        public T GetDana()
        {
            return dana;
        }
        public void SetDana(T d)
        {
            dana = d;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            PrzechowywanieDanych przechowywanieDanych = new PrzechowywanieDanych(5);
            PrzechowywanieDanych<float> przechowywanieDanychFloat = new PrzechowywanieDanych<float>(5);
            PrzechowywanieDanych<bool> przechowywanieDanychBool = new PrzechowywanieDanych<bool>(true);

        }
    }
}
