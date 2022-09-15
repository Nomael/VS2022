using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Schleifen_Uebungen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Menu
            string eingabe;

            do
            {
                Console.Clear();
                Console.WriteLine("Schleifen Übungen (by Noel Malchow)");
                Console.WriteLine("---------------------");
                Console.WriteLine("Bitte gebe die Nummer der jeweiligen Aufgabe ein");
                Console.WriteLine("(3) Ungerade Zahlen Rechner");
                Console.WriteLine("---------------------");
                Console.WriteLine("(X) Ende");

                eingabe = Convert.ToString(Console.ReadLine());

                switch (eingabe)
                {
                    //Aufgabe 3
                    case "3":
                        int zaehler = 0;
                        int speicher = 0;
                        int formax = 10;

                        Console.Clear();
                        Console.Write("Bitte gebe bis zu " + formax + " Zahlen ein");

                        for (int i = 0; i <= formax; i += (1))
                        {
                            zaehler = Convert.ToInt32(Console.ReadLine());
                            if (zaehler % 2 == 0)
                            {
                                speicher += zaehler;
                            }
                        }
                        Console.WriteLine("Die Summe aller Ungeraden Zahlen ist: " + speicher);

                        break;

                    case "X":
                        Console.WriteLine("Exit");
                        break;

                    default:
                        Console.Clear();
                        Console.WriteLine("ERROR\t\tERROR\t\tERROR");
                        Console.WriteLine("Fehler 404 Programm Not Found");
                        Console.WriteLine("Programm Reloating . . .");
                        break;
                }

                Console.ReadKey();

            } while (eingabe != "ENDE");
        }
    }
}
