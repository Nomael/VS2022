﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
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
                Console.WriteLine("(6) Potenz Rechner");
                Console.WriteLine("(9) 6er Zähler (Eine Schleife und 2 Schleifen)");
                Console.WriteLine("(13) Polynom – Wertetabelle");
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

                        for (zeile = 20; zeile >= 1; zeile--)
                        {
                            for (spalte = 1; spalte <= zeile; spalte++)
                            {
                                Console.Write("*");
                            }
                            Console.WriteLine(" ");
                        }
                        break;

                    case "4.1": // Aufgabe 4: * Dreieck

                        Console.Clear();
                        Console.WriteLine("Dies ist ein * Dreieck");

                        for (zeile = 1; zeile <= 20; zeile++)
                        {
                            for (spalte = 1; spalte <= zeile; spalte++)
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
                        for (int i = 0; i < zahl.Length; i++)
                        {

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

                    case "6": // Aufgabe 6: Potenz Rechner
                        int zahl6;
                        int sum6 = 1;
                        int potenz6;

                        Console.Clear();
                        Console.WriteLine("Bitte gib eine Zahl und dessen Potzenz ein");
                        Console.Write("Zahl: ");
                        zahl6 = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Potenz: ");
                        potenz6 = Convert.ToInt32(Console.ReadLine());

                        for (int i = 0; i < potenz6; i++)
                        {
                            sum6 *= zahl6;
                        }

                        Console.WriteLine("Die Zahl " + zahl6 + " mit der Potenz hoch " + potenz6 + " ergibt: " + sum6);
                        break;

                    case "9": // Aufgabe 9: 6er Zähler
                        int interface9 = 0;
                        int interface9num = 24;
                        int intzeile9 = 4;
                        int intspalte9 = 6;
                        string choose9 = "";
                        Console.Clear();
                        Console.WriteLine("Das Programm wird eine Reihe an Zahlen anzeigen die in 6er schritten einen umbruch machen");
                        //Console.WriteLine("Beispiel: \n");
                        //Console.WriteLine(" 1  2  3  4  5  6\n 7  8  9 10 11 12\n13 14 15 16 17 18\n19 20 21 22 23 24\n...\n");
                        Console.WriteLine("Zum Starten bitte (1loop) oder (2loop) schreiben");
                        Console.Write("Eingabe: ");
                        choose9 = Convert.ToString(Console.ReadLine());

                        if (choose9 == "1loop")
                        {
                            for (int i = 1; i <= interface9num; i++)
                            {
                                interface9 += 1;
                                if (interface9 % 6 == 1)
                                {
                                    Console.Write("\n" + i + " ");
                                }
                                else
                                {
                                    Console.Write(i + " ");
                                }
                            }
                            Console.Write("\n...");

                        }
                        else if (choose9 == "2loop")
                        {
                            int j9;
                            for (int i = 0; i < intzeile9; i++)
                            {
                                for (j9 = 0; j9 < intspalte9; j9++)
                                {
                                    interface9 += 1;
                                    Console.Write(interface9 + " ");
                                    
                                }
                                Console.Write("\n");
                                j9 = 0;
                            }
                            Console.Write("...");
                        }
                        break;

                    case "13": // Aufgabe 13: Polynom – Wertetabelle

                        Console.Clear();

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

                //Task.Delay(2000).Wait(); //Funktion um automatisches weiterlaufen des Codes zu garantieren (Nur zu Testen da)
                Console.ReadKey();

            } while (eingabe != "end");
        }
    }
}
