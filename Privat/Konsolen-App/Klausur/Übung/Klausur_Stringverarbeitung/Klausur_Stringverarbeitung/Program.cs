using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klausur_Stringverarbeitung
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] numberArray = new string[] { "Hallo","werr", "Hallo", "werr", "Hallo", "werr", "Hallo", "werr" };

            foreach (char nummer in numberArray)
            {
                Console.WriteLine(nummer);
            }

            Console.ReadKey();
        }
    }
}
