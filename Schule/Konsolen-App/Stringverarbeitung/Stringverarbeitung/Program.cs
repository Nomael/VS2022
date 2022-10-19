using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using static System.Net.WebRequestMethods;

namespace Stringverarbeitung
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string eingabe;

            do
            {
                Console.Clear();
                Console.WriteLine("Stringverarbeitung (by Noel Malchow)");
                Console.WriteLine("---------------------");
                Console.WriteLine("Bitte Wähle eine Aufgabe aus");
                Console.WriteLine("(1) Umgedrehte Zeichenkette");
                Console.WriteLine("(2) Namen einlesen");
                Console.WriteLine("(3) Dateinamen ändern und Parameter ausgeben");
                Console.WriteLine("(4) Toplevel Domain herausfinden");
                Console.WriteLine("(5) Quersumme berechnen");
                Console.WriteLine("---------------------");
                Console.WriteLine("(reload) Restart the Programm");
                Console.WriteLine("(end) Ende");

                Console.Write("\nAufgabe: ");
                eingabe = Convert.ToString(Console.ReadLine());

                switch (eingabe)
                {
                    case "1": // Aufgabe 1
                        umgedrehte_zeichenkette();
                        break;

                    case "2": // Aufgabe 2
                        namen_einlesen();
                        break;

                    case "3": // Aufgabe 3
                        dateinamen(args);
                        break;

                    case "4": // Aufgabe 4
                        toplvldomain();
                        break;

                    case "5": // Aufgabe 5
                        quersummen_rechner();
                        break;

                    case "end":
                        break;

                    case "reload":
                        Console.Clear();
                        txtcolor("Reloading the Programm ", "DarkYellow", "Write");
                        for (int i = 0; i < 3; i++)
                        {
                            txtcolor(". ", "Cyan", "Write");
                            Task.Delay(1000).Wait();
                        }
                        txtcolor("Reloading Now", "Green", "WriteLine");
                         

                        progreload(true, 1000);
                        break;

                    default:
                        Console.Clear();
                        txtcolor("ERROR\t\tERROR\t\tERROR", "DarkYellow", "WriteLine");
                        Console.WriteLine("\nFehler 404 Programm Not Found");

                        progreload(true, 2000);
                        break;
                }

                if (eingabe != "end")
                {
                    Console.ReadKey();
                }

            } while (eingabe != "end");
        }

        // Aufgabe 1
        /// <summary>
        /// Ein Programm welches eine Zeichenkette einliest und in umgedrehter Zeichenfolge wieder ausgibt.
        /// </summary>
        static void umgedrehte_zeichenkette()
        {
            string textuz = "Hello World";

            Console.Clear();
            Console.WriteLine("Bitte gib ein word ein das rückwärts wieder ausgegeben werden soll");
            Console.Write("Wort: ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            textuz = Console.ReadLine();
            Console.ResetColor();

            for (int i = textuz.Length - 1; i >= 0; i--)
            {
                Console.Write(textuz[i]);
            }
        }

        // Aufgabe 2
        /// <summary>
        /// Ein Programm welches einen durch ein Komma gretrenten Vor und Nachnamen einließt und in getrente String Variablen abspieichert.
        /// </summary>
        static void namen_einlesen()
        {
            string ganzername = "Noel,Malchow";
            string vorname;
            string nachname;

            Console.Clear();
            Console.WriteLine("Bitte gebe einen Vor und Nachnamen ein. Diese sollten mit einem Komma getrennt sein (Max,Mustermann)");
            Console.Write("Vor,Nachname: ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            ganzername = Convert.ToString(Console.ReadLine());
            Console.ResetColor();

            string[] zerlegung = ganzername.Split(',');
            vorname = zerlegung[0];
            nachname = zerlegung[1];

            Console.Write("Vorname: ");
            txtcolor(vorname, "Green", "Write");
            Console.Write(" Nachname: ");
            txtcolor(nachname, "Green", "Write");
        }

        // Aufgabe 3
        /// <summary>
        /// Ein Programm welches einen Dateinamen als Parameter erhält und mit einer geänderten Dateierweiterung .bak wieder zurückgibt.
        /// </summary>
        /// <param name="args"></param>
        static void dateinamen(string[] args)
        {
            string dateiname;

            Console.Clear();
            Console.Write("Programm: ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            dateiname = Convert.ToString(Console.ReadLine());
            Console.ResetColor();

            string[] neudateiname = dateiname.Split('.');
            neudateiname[0] = neudateiname[0] + ".bak";

            Console.Write("Die Datei Heißt nun ");
            txtcolor(Convert.ToString(neudateiname[0]), "Yellow", "Write");

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
            else
            {
                txtcolor("Bitte in der Console über den Debug ordner die CMD ausführen um Argumente mit auszugeben", "DarkYellow", "Write");
            }
        }

        // Aufgabe 4
        /// <summary>
        /// Ein Programm welches nach Einlesen einer beliebigen URL die Toplevel Domain davon ausgibt
        /// mit dem zusatz einer automatischen http:// Ergänzung, falls dies vergessen wurde.
        /// </summary>
        static void toplvldomain()
        {
            string domain;

            Console.Clear();
            Console.WriteLine("Bitte gib eine Domain ein");
            Console.Write("URL: ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            domain = Convert.ToString(Console.ReadLine());
            Console.ResetColor();

            string[] toplvldomain = domain.Split('/');

            //if (toplvldomain.Length < 2)
            //{
            //    Console.Clear();
            //    txtcolor("ERROR No valid Domain or just Toplevel Domain Detectet\n\n Reloading The Programm now", "DarkYellow", "Write");

            //    progreload(true, 4000);
            //}

            if (toplvldomain[0] == "http:")
            {
                Console.Write("\nToplevel Domain: ");
                txtcolor(toplvldomain[0] + "//" + toplvldomain[2], "Green", "Write");
            }
            if (toplvldomain[0] == "https:")
            {
                Console.Write("\nToplevel Domain: ");
                txtcolor(toplvldomain[0] + "//" + toplvldomain[2], "Green", "Write");
            }
            else if (toplvldomain[0] != "http:") //&& toplvldomain.Length > 1
            {
                Console.Write("\nToplevel Domain: ");
                txtcolor("http://" + toplvldomain[0], "Green", "Write");
            }

        }

        // Aufgabe 5
        /// <summary>
        /// Ein Programm welches die Quersumme einer eingegebenen, ganzen Zahl bestimmt und ausgibt.
        /// </summary>
        static void quersummen_rechner()
        {
            string zahlen;
            int zahlenresult = 0;

            Console.Clear();
            Console.WriteLine("Bitte gib eine Zahl ein");
            Console.Write("Zahl: ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            zahlen = Convert.ToString(Console.ReadLine());
            Console.ResetColor();

            Console.Write("\n\nDie Quersumme von ");
            txtcolor(zahlen, "Green", "Write");
            Console.Write(" = ");
            Console.ForegroundColor = ConsoleColor.Green;
            for (int i = 0; i < zahlen.Length; i++)
            {
                zahlenresult += Convert.ToInt32(zahlen.Substring(i, 1));

                Console.Write(zahlen.Substring(i, 1));

                if (i != zahlen.Length - 1)
                {
                    Console.Write(" + ");
                }
                if (i == zahlen.Length - 1)
                {
                    Console.ResetColor();
                    Console.Write(" = ");
                    txtcolor(Convert.ToString(zahlenresult), "Green", "Write");
                }
            }
        }




        // (Code from https://stackoverflow.com/questions/19275947/c-sharp-how-can-i-append-a-string-variable-on-to-the-end-of-consolecolor)
        /// <summary>
        /// A Little Programm to Color the Input.
        /// </summary>
        /// <param name="pText">The Text that should be displayed</param>
        /// <param name="pColor">The Color that is changing the Text</param>
        /// <param name="pMode">This changes if it should be a WriteLine or just a Write in the Console</param>
        static void txtcolor(string pText, string pColor, string pMode)
        {
            Console.ForegroundColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), pColor);
            if (pMode == "Write")
            {
                Console.Write(pText);
            }
            else if (pMode == "WriteLine")
            {
                Console.WriteLine(pText);
            }
            Console.ResetColor();
        }

        // (Code from https://stackoverflow.com/questions/5706497/how-restart-the-console-app)
        /// <summary>
        /// Small Programm to Reload the Console.
        /// </summary>
        /// <param name="pActive">Tests if the programm should be Reloaded</param>
        /// <param name="pTermWait">Time to Wait before the Reload initialize in ms (2000ms = 2sec)</param>
        static void progreload(bool pActive, int pTermWait)
        {
            if (pActive)
            {
                Task.Delay(pTermWait).Wait();
                var fileName = Assembly.GetExecutingAssembly().Location;
                System.Diagnostics.Process.Start(fileName);
                Environment.Exit(0);
            }
        }
    }
}
