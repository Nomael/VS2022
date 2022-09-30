using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Stringverarbeitung
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //umgedrehte_zeichenkette();
            //namen_einlesen();
            //dateinamen(args);
            toplvldomain();


            Console.ReadKey();
        }

        static void umgedrehte_zeichenkette()
        {
            string textuz = "Hello World";
            for (int i = textuz.Length - 1; i >= 0; i--)
            {
                Console.Write(textuz[i]);
            }
        }

        static void namen_einlesen()
        {
            string ganzername = "Noel,Malchow";
            string vorname;
            string nachname;
            string[] zerlegung = ganzername.Split(',');

            vorname = zerlegung[0];
            nachname = zerlegung[1];
            Console.WriteLine("Vorname: " + vorname + " Nachname: " + nachname);
        }

        static void dateinamen(string[] args)
        {
            string dateiname;
            Console.Write("Programm: ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            dateiname = Convert.ToString(Console.ReadLine());
            Console.ResetColor();
            string[] neudateiname = dateiname.Split('.');
            neudateiname[0] = neudateiname[0] + ".bak";

            Console.Write("Die Datei Heißt nun ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(neudateiname[0]);
            Console.ResetColor();

            if (args.Length > 0)
            {
                Console.WriteLine(" mit diesen Parametern:\n");
                Console.ForegroundColor = ConsoleColor.Green;
                for (int i = 0; i < args.Length; i++)
                {
                    Console.WriteLine("Parameter " + i + ": " + args[i]);
                }
                Console.ResetColor();
            }
        }

        static void toplvldomain()
        {
            string domain;
            Console.WriteLine("Bitte gib eine Domain ein");
            Console.Write("URL: ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            domain = Convert.ToString(Console.ReadLine());
            Console.ResetColor();
            string[] toplvldomain = domain.Split('/');

            if (toplvldomain[0] == "http:")
            {
                Console.WriteLine(toplvldomain[0] + "//" + toplvldomain[2]);
            }
            if (toplvldomain[0] == "https:")
            {
                Console.WriteLine(toplvldomain[0] + "//" + toplvldomain[2]);
            }
            
        }
    }
}
