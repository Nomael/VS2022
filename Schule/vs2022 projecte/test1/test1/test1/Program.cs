using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double ps;
            double kmh;

            Console.WriteLine("PS nach KMH Tippe 1 | ...");


            int Eingabe;
            Console.WriteLine("Tippe die Nummer ein!");
            Eingabe = Convert.ToInt32(Console.ReadLine());
            if(Eingabe == 0)
            {
                Console.WriteLine("1 eingegeben");
                Console.ReadLine();
            }
        }
    }
}
