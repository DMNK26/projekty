using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figury
{
    class Trapez : Czworokat
    {
        private float wysokosc;
        public Trapez(string nazwa, float bokA, float bokB, float bokC, float bokD, float wysokosc) : base(nazwa, bokA, bokB, bokC, bokD)
        {
            this.wysokosc = wysokosc;
        }

        public void ObliczPole()
        {
            pole = (bokA + bokB) * wysokosc / 2;
        }
    }
}
