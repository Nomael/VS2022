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
            dateinamen(args);

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
            string dateiname = "TestProg.exe";
            Console.Write("Programm: ");
            dateiname = Convert.ToString(Console.ReadLine());
            string[] neudateiname = dateiname.Split('.');

            Console.WriteLine("Die Datei Heißt nun " + neudateiname[0] + ".bak");
        }
    }
}
