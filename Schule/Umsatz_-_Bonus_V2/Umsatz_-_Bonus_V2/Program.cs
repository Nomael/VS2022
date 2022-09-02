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
            String eingabe;

            do
            {
                Console.Clear();
                Console.WriteLine("Umsatz und Bonus");
                Console.WriteLine("---------------------");
                Console.WriteLine("Bitte geben Sie A,B oder C ein:");
                Console.WriteLine("(A) Umsatz eingeben");
                Console.WriteLine("(B) Rechnung => Bonus");
                Console.WriteLine("---------------");
                Console.WriteLine("(X) Ende");

                eingabe = Convert.ToString(Console.ReadLine());

                switch (eingabe)
                {
                    case "A":
                        Console.WriteLine("Bitte Gib deinen Umsatz ein!");
                        Console.Write("Umsatz: ");
                        umsatz = Convert.ToDouble(Console.ReadLine());
                        break;

                    case "B":
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
                        break;

                    case "X":
                        Console.WriteLine("Exit");
                        break;

                    default:
                        Console.WriteLine("Fehler");
                        break;
                }

                Console.ReadLine();

            } while (eingabe != "X");
        }
    }
}
