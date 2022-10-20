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
                        ipaddress = ipinput();
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
        static string ipinput()
        {
            string ipeingabe;

            Console.Clear();
            Console.WriteLine("Bitte gib eine IP ein");

            Console.Write("IP: ");
            ipeingabe = Convert.ToString(Console.ReadLine());


            return ipeingabe;
        }

        static void ipcheck(string peingabe)
        {
            bool erlaubt0 = false;
            bool erlaubt1 = false;
            bool erlaubt2 = false;
            bool erlaubt3 = false;

            string[] oktett = peingabe.Split('.');
            int[] ipoktett = new int[oktett.Length];
            
            Console.Clear();

            for (int i = 0; i < oktett.Length; i++)
            {
                ipoktett[i] = Convert.ToInt32(oktett[i]);
            }

            if (ipoktett[0] == 192)
            {
                erlaubt0 = true;
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
                erlaubt1 = true;
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
                erlaubt2 = true;
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
                erlaubt3 = true;
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

            if (erlaubt0 == true && erlaubt1 == true && erlaubt2 == true && erlaubt3 == true)
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
