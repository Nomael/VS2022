using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inhaltsverzeichnis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string eingabe;

            do
            {
                Console.Clear();
                Console.WriteLine("NAME (by Noel Malchow)");
                Console.WriteLine("---------------------");
                Console.WriteLine("ANWEISUNG");
                Console.WriteLine("PROGRAMM 1");
                Console.WriteLine("PROGRAMM 2");
                Console.WriteLine("PROGRAMM 3");
                Console.WriteLine("---------------------");
                Console.WriteLine("ENDE");

                eingabe = Convert.ToString(Console.ReadLine());

            } while (eingabe != "ENDE");

        }
    }
}
