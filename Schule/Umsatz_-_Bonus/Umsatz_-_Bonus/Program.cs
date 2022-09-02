using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Umsatz___Bonus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double umsatz = 0;
            double bonus = 0;
            double eingabe;

            Console.WriteLine("Bitte git deinen Umsatz ein");
            Console.Write("Umsatz: ");
            eingabe = Convert.ToDouble(Console.ReadLine());
            umsatz = eingabe;

            if (umsatz > 2000)
            {
                if (umsatz >= 3000)
                {
                    if (umsatz >= 10000)
                    {
                        bonus = 1000;
                    }
                    else
                    {
                        bonus = 500;
                    }
                }
                else
                {
                    bonus = 100;
                }
            }
            else
            {
                bonus = 0;
            }

            Console.WriteLine("Du hast einen Bonus von: " + bonus);

            Console.ReadKey();
        }
    }
}
