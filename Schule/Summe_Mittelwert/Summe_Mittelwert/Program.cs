using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Summe_Mittelwert
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int eingabe = 0;
            int summe = 0;
            int mittelwert = 0;
            int nummer = 0;
            int min_zahl = 0;
            int max_zahl = 0;

            Console.WriteLine("Bitte gib eine Zahl ein (Negative Zahl = Ende/Ausrechnung)");

            while (eingabe >= 0)
            {
                Console.Write("Zahl: ");
                eingabe = Convert.ToInt32(Console.ReadLine());

                if (eingabe > 0)
                {
                    summe += eingabe;
                    nummer += 1;
                    mittelwert = summe / nummer;

                    if (eingabe > max_zahl)
                    {
                        max_zahl = eingabe;
                    }

                    if (nummer <= 1)
                    {
                        min_zahl = eingabe;
                    }
                    else if (eingabe < min_zahl)
                    {
                        min_zahl = eingabe;
                    }
                }
            }
            Console.WriteLine("\nSumme: " + summe + "\nMittelwert: " + mittelwert + "\nAnzahl der Zahlen: " + nummer);
            Console.WriteLine("Max Zahl: " + max_zahl + "\nMin Zahl: " + min_zahl);
            Console.ReadLine();
        }
    }
}
