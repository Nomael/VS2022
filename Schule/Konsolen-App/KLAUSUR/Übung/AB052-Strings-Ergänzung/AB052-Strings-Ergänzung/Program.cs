using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace AB052_Strings_Ergänzung
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string eingabe;
            string ipaddress = "";

            do
            {
                Console.Clear();
                Console.WriteLine("AB052-Strings-Ergänzung by Noel Malchow");
                Console.WriteLine("-----------------------------");
                Console.WriteLine("Bitte gebe eine Aufgabe an\n");
                Console.WriteLine("(a) IP eingeben");
                Console.WriteLine("(b) IP überprüfen");
                Console.WriteLine("(c) Programmende");

                Console.Write("\nAufgabe: ");

                Console.ForegroundColor = ConsoleColor.Cyan;
                eingabe = Convert.ToString(Console.ReadLine());
                Console.ResetColor();

                switch (eingabe)
                {
                    case "a":
                        ipaddress = ipinput(ipaddress);
                        Console.WriteLine(ipaddress);
                        break;

                    case "b":
                        ipcheck(ipaddress);
                        break;

                    case "c":
                        break;

                    default:
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("Error non valid input detectet");
                        Console.ResetColor();
                        break;

                }

                if (eingabe != "c")
                {
                    Console.ReadKey();
                }

            } while (eingabe != "c");
        }
        static string ipinput(string pipaddr)
        {
            string ipeingabe;

            Console.Clear();
            Console.WriteLine("Bitte gib eine IP ein | Aktuell: " + pipaddr);

            Console.Write("IP: ");
            ipeingabe = Convert.ToString(Console.ReadLine());


            return ipeingabe;
        }

        static void ipcheck(string peingabe)
        {
            //string[] oktett = peingabe.Split('.');

            int[] ipoktett = Array.ConvertAll<string, int>(peingabe.Split('.'), int.Parse);
            bool[] error = new bool[ipoktett.Length];

            Console.Clear();

            //Console.WriteLine(ipoktett[0] + " | " + ipoktett[1] + " | " + ipoktett[2] + " | " + ipoktett[3]);

            if (ipoktett[0] == 192)
            {
                error[0] = true;
                Console.Write("1. Oktett ist im erlaubten bereich: ");

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("192");
                Console.ResetColor();
            }
            else
            {
                Console.Write("1. Oktett ist nicht im erlaubten bereich: ");

                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("192");
                Console.ResetColor();
            }

            if (ipoktett[1] == 168 || ipoktett[1] == 169)
            {
                error[1] = true;
                Console.Write("2. Oktett ist im erlaubten bereich: ");

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("168 oder 169");
                Console.ResetColor();
            }
            else
            {
                Console.Write("2. Oktett ist nicht im erlaubten bereich: ");

                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("168 oder 169");
                Console.ResetColor();
            }

            if (ipoktett[2] >= 0 && ipoktett[2] <= 255)
            {
                error[2] = true;
                Console.Write("3. Oktett ist im erlaubten bereich: ");

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("0 - 255");
                Console.ResetColor();
            }
            else
            {
                Console.Write("3. Oktett ist nicht im erlaubten bereich: ");

                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("0 - 255");
                Console.ResetColor();
            }

            if (ipoktett[3] >= 100 && ipoktett[3] <= 200)
            {
                error[3] = true;
                Console.Write("4. Oktett ist im erlaubten bereich: ");

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("100 - 200");
                Console.ResetColor();
            }
            else
            {
                Console.Write("4. Oktett ist nicht im erlaubten bereich: ");

                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("100 - 200");
                Console.ResetColor();
            }

            if (error[0] == true && error[1] == true && error[2] == true && error[3] == true)
            {
                Console.Write("\n\nIP Adresse: ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(peingabe);
                Console.ResetColor();
                Console.WriteLine(" OK");
            }
            else
            {
                Console.Write("\n\nIP Adresse: ");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write(peingabe);
                Console.ResetColor();
                Console.WriteLine(" Fehler");
            }

        }
    }
}
