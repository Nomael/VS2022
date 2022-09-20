using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For_While_Schleifen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            for (i = 1; i <= 10; i += (1))
            {
                Console.Write("For Schleife: "); Console.WriteLine(i);
            }
            Console.WriteLine("------------------------");
            i = 0;
            while (i < 10)
            {
                i += 1;
                Console.Write("While Schleife: "); Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
