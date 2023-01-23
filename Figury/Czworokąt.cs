using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figury
{
    class Czworokat
    {
        protected string nazwa;
        protected float bokA, bokB, bokC, bokD;
        protected float obwod, pole;

        public Czworokat(string nazwa, float bokA, float bokB, float bokC, float bokD)
        {
            this.nazwa = nazwa;
            this.bokA = bokA;
            this.bokB = bokB;
            this.bokC = bokC;
            this.bokD = bokD;
        }

        public void ObliczObwod()
        {
            obwod = bokA + bokB + bokC + bokD;
        }

        public void Informacje()
        {
            Console.WriteLine("Obiekt o nazwie " + nazwa);
            Console.WriteLine("BokA wynosi " + bokA);
            Console.WriteLine("BokB wynosi " + bokB);
            Console.WriteLine("BokC wynosi " + bokC);
            Console.WriteLine("BokD wynosi " + bokD);
            Console.WriteLine("Pole wynosi " + pole);
            Console.WriteLine("Obwod wynosi " + obwod);
        }
    }
}
