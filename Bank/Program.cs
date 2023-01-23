using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class Program
    {
        static void Main(string[] args)
        {
			KontoBankowe konto = new KontoBankowe("Jan", "Kowalski", "001", "1234");
			konto.Loguj("1234");
			//konto.Loguj("123");
			//konto.Info();
			konto.Wplata(100);
			konto.Info();

			KontoBankowe konto2 = new KontoBankowe("Paweł", "Nowak", "002", "4321");
			konto2.Loguj("4321");
			konto2.Info();

			konto.Przelew(250, konto2);
			konto.Info();
			konto2.Info();

			//konto.saldo = 15;
		}
	}
}
