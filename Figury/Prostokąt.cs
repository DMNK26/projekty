using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figury
{
    class Prostokat : Czworokat
    {
        public Prostokat(string nazwa, float bokA, float bokB) : base(nazwa, bokA, bokB, bokA, bokB)
        {

        }

        public void ObliczPole()
        {
            pole = bokA * bokB;
        }

    }
}
