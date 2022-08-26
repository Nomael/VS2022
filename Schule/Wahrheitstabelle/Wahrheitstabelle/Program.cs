using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wahrheitstabelle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool a, b;

            Console.WriteLine("{0}\t\t{1}\t\t{2}", "a", "b", "a && b");

            a = false; b = false;
            Console.WriteLine("{0}\t\t{1}\t\t{2}", a, b, a && b);
            a = false; b = true;
            Console.WriteLine("{0}\t\t{1}\t\t{2}", a, b, a && b);
            a = true; b = false;
            Console.WriteLine("{0}\t\t{1}\t\t{2}", a, b, a && b);
            a = true; b = true;
            Console.WriteLine("{0}\t\t{1}\t\t{2}", a, b, a && b);


            Console.WriteLine("Ende");

            Console.ReadLine();
        }
    }
}
