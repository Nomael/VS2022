using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_einfacher_Rechner_int
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int zahl1;
            int zahl2;
            int ergebniss;

            Console.Write("Zahl 1: ");
            zahl1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Zahl 2: ");
            zahl2 = Convert.ToInt32(Console.ReadLine());


            ergebniss = zahl1 + zahl2;

            Console.WriteLine(zahl1 + " + " + zahl2 + " = " + ergebniss);

            Console.ReadKey();
        }
    }
}
