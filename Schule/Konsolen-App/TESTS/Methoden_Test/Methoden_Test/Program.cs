using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methoden_Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //SchleifenLaenge(); // Ohne Rückgabe, Ohne Parameter
            //SchleifenIntLaenge(20); // Ohne Rückgabe, Mit Parameter
            //Console.WriteLine("Quadrat von 2 ist " + RechneQuadrat(2)); // Mit Rückgabe, Mit Parameter

            Console.WriteLine(ZeichenRate(4));

            Console.ReadKey();
        }

        // Ohne Rückgabe, Ohne Parameter
        static void SchleifenLaenge()
        {

        }

        // Ohne Rückgabe, Mit Parameter
        /// <summary> Länge des Quadrates </summary> <param name="plaenge"></param>
        static void SchleifenIntLaenge(int plaenge)
        {
            for (int i = 0; i < plaenge; i++)
            {
                Console.Write("\n");
                for (int j = 0; j < plaenge; j++)
                {
                    Console.Write("#");
                }
                Console.Write("#");
            }
        }

        // Mit Rückgabe, ohne Parameter
        static double RechneQuadrat()
        {

            double result = 1;
            return result;
        }

        // Mit Rückgabe, mit Parameter
        static string ZeichenRate(int pZeichenLaenge)
        {
            string result = "";

            for (int i = 0; i < pZeichenLaenge; i++)
            {
                result += "#";
            }

            return result;
        }
    }
}
