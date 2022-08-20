using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace test1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double ps;
            float ps2;
            float kmh2;
            double kmh;

            double laenge;
            double breite;
            string maeinheit;
            double flaeche;

            Console.WriteLine("Tippe die Nummer ein!");
            Console.WriteLine("PS nach KMH Tippe 1 | Flächeninhalt eines Dreieckes Tippe 2 | ...");


            int Eingabe;
            Eingabe = Convert.ToInt32(Console.ReadLine());
            if (Eingabe == 1)
            {
                Console.WriteLine("Bitte gib die PS anzahl ein");
                ps2 = Convert.ToInt32(Console.ReadLine());
                ps = Convert.ToDouble(ps2);
                kmh = ps / 1.36;
                kmh2 = ps2 / 1.36f;
                Console.WriteLine(ps + " PS sind " + kmh + " KMH (double)");
                Console.WriteLine(ps2 + " PS sind " + kmh2 + " KMH (float)");
                Console.ReadLine();
            }

            if (Eingabe == 2)
            {
                Console.WriteLine("Gib Bitte die Länge und Breite ein");
                Console.Write("Länge: ");
                laenge = Convert.ToInt32(Console.ReadLine());
                Console.Write("Breite: ");
                breite = Convert.ToInt32(Console.ReadLine());
                Console.Write("Maßeinheit (optional): ");
                maeinheit = Convert.ToString(Console.ReadLine());
                flaeche = laenge * breite;

                if(maeinheit != "")
                {
                    Console.WriteLine("Der flächeninhalt des Rechteckes ist: " + flaeche + maeinheit + "²");
                }
                else
                {
                    Console.WriteLine("Der flächeninhalt des Rechteckes ist: " + flaeche);
                }

                Console.ReadLine();
            }

            if (Eingabe == 2)
            {
                Console.WriteLine("Gib Bitte die Länge und Breite ein");
                Console.Write("Länge: ");
                laenge = Convert.ToInt32(Console.ReadLine());
                Console.Write("Breite: ");
                breite = Convert.ToInt32(Console.ReadLine());
                Console.Write("Maßeinheit (optional): ");
                maeinheit = Convert.ToString(Console.ReadLine());
                flaeche = laenge * breite;

                if (maeinheit != "")
                {
                    Console.WriteLine("Der flächeninhalt des Rechteckes ist: " + flaeche + maeinheit + "²");
                }
                else
                {
                    Console.WriteLine("Der flächeninhalt des Rechteckes ist: " + flaeche);
                }

                Console.ReadLine();
            }
            Console.ReadKey();
        }
    }
}
