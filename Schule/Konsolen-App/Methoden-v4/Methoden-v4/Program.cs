using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methoden_v4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Zahlenrechner(1,2,3));
            Console.ReadKey();
        }

        static int Zahlenrechner(int pZahl1, int pZahl2, int pZahl3)
        {
            int summe = pZahl1 + pZahl2 + pZahl3;

            return summe;
        }
    }
}
