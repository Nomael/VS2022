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
                // Die aufgaben sind mit den Nummern der Cases Verknüpft
                Console.Clear();
                Console.WriteLine("Schleifen Übungen (by Noel Malchow)");
                Console.WriteLine("---------------------");
                Console.WriteLine("Bitte gebe die Nummer der jeweiligen Aufgabe ein\n");
                Console.WriteLine("(3) Ungerade Zahlen Rechner");
                Console.WriteLine("(4) Umgekehrte * Dreieck");
                Console.WriteLine("(4.1) * Dreieck");
                Console.WriteLine("(5) n Fakultät");
                Console.WriteLine("(6) ");
                Console.WriteLine("(9) ");
                Console.WriteLine("(13) ");
                Console.WriteLine("---------------------");
                Console.WriteLine("(end) Ende");

                eingabe = Convert.ToString(Console.ReadLine());

                switch (eingabe)
                {
                    case "3": // Aufgabe 3: Ungerade Zahlen Rechner
                        int zaehler = 0;
                        int speicher = 0;
                        int formax = 10;

                        Console.Clear();
                        Console.Write("Bitte gebe bis zu ");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(formax);
                        Console.ResetColor();
                        Console.WriteLine(" mal eine Zahle ein");

                        for (int i = 1; i <= formax; i += 1)
                        {
                            Console.Write("Zahl " + i + ": ");
                            zaehler = Convert.ToInt32(Console.ReadLine());
                            if (zaehler % 2 == 1)
                            {
                                speicher += zaehler;
                                //Console.WriteLine("Ungerade");
                            }
                            //else
                            //{
                            //    Console.WriteLine("Gerade");
                            //}
                        }
                        Console.WriteLine("Die Summe aller Ungeraden Zahlen ist: " + speicher);
                        break;

                    case "4": // Aufgabe 4: Umgekehrtes * Dreieck
                        int zeile, spalte;

                        Console.Clear();
                        Console.WriteLine("Dies ist ein Ungedrehtes * Dreieck");

                        for (zeile = 20; zeile >= 1; zeile = zeile - 1)
                        {
                            for (spalte = 1; spalte <= zeile; spalte = spalte + 1)
                            {
                                Console.Write("*");
                            }
                            Console.WriteLine(" ");
                        }
                        break;

                    case "4.1": // Aufgabe 4: Umgekehrtes * Dreieck

                        Console.Clear();
                        Console.WriteLine("Dies ist ein * Dreieck");

                        for (zeile = 1; zeile <= 20; zeile ++)
                        {
                            for (spalte = 1; spalte <= zeile; spalte ++)
                            {
                                Console.Write("*");
                            }
                            Console.WriteLine(" ");
                        }
                        break;

                    case "5": // Aufgabe 5: n Fakultät
                        int n = 0;
                        int sum5 = 1;

                        Console.Clear();
                        Console.WriteLine("Bitte gib die menge der Fakultät ein");
                        Console.Write("Anzahl: ");
                        n = Convert.ToInt32(Console.ReadLine());

                        int[] zahl = new int[n];

                        for (int i = 1; i <= zahl.Length; i++)
                        {
                            zahl[i - 1] = i;
                            sum5 *= i;
                        }
                        Console.WriteLine("\nDas ergebnis der Fakultät ist:\n");
                        Console.Write(n + "! = ");
                        for (int i = 0; i < zahl.Length; i++) {

                            if (i == zahl.Length - 1)
                            {
                                Console.Write(zahl[i] + " = " + sum5);
                            }
                            if (i < zahl.Length - 2)
                            {
                                Console.Write(zahl[i] + " * ");
                            }
                        }
                        break;

                    case "6":
                        break;

                    case "end":
                        break;

                    default:
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("ERROR\t\tERROR\t\tERROR");
                        Console.ResetColor();
                        Console.WriteLine("Fehler 404 Programm Not Found");
                        break;
                }

                Console.ReadKey();

            } while (eingabe != "end");
        }
    }
}
