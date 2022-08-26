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
            int eingabe;

            double ps;
            float ps2;
            float kw2;
            double kw;

            double laenge;
            double breite;
            string maeinheit;
            double flaeche;

            double hoehe;
            double volumen;

            double radius;
            double umfang;
            double mantelflaeche;
            double oberflaeche;


            Console.WriteLine("Tippe die Nummer ein!");
            Console.WriteLine("PS nach KW Tippe 1 | Flächeninhalt eines Dreieckes Tippe 2 | Volumen einer Pyramide Tippe 3 | Oberfläche eines Zylinders Tippe 4");

            eingabe = Convert.ToInt32(Console.ReadLine());

            if (eingabe == 1)
            {
                Console.WriteLine("Bitte gib die PS anzahl ein");
                Console.Write("PS: ");
                ps2 = Convert.ToInt32(Console.ReadLine());
                ps = Convert.ToDouble(ps2);

                kw = ps / 1.36;
                kw2 = ps2 / 1.36f;

                Console.WriteLine(ps + " PS sind " + kw + " KW (double)");
                Console.WriteLine(ps2 + " PS sind " + kw2 + " KW (float)");
            }

            if (eingabe == 2)
            {
                Console.WriteLine("Gib Bitte die Länge und Breite ein");
                Console.Write("Länge: ");
                laenge = Convert.ToInt32(Console.ReadLine());

                Console.Write("Breite: ");
                breite = Convert.ToInt32(Console.ReadLine());

                Console.Write("Maßeinheit (optional): ");
                maeinheit = Convert.ToString(Console.ReadLine());

                flaeche = laenge * breite;

                if (laenge == breite)
                {
                    Console.WriteLine("Der Flächeninhalt des Quadrates ist: " + flaeche + maeinheit + "²");
                }
                else
                {
                    Console.WriteLine("Der Flächeninhalt des Rechteckes ist: " + flaeche + maeinheit + "²");
                }
            }

            if (eingabe == 3)
            {
                Console.WriteLine("Gib Bitte die Länge und Höhe ein");
                Console.Write("Länge: ");
                laenge = Convert.ToInt32(Console.ReadLine());

                Console.Write("Breite: ");
                breite = Convert.ToInt32(Console.ReadLine());

                Console.Write("Höhe: ");
                hoehe = Convert.ToInt32(Console.ReadLine());

                Console.Write("Maßeinheit (optional): ");
                maeinheit = Convert.ToString(Console.ReadLine());

                flaeche = laenge * breite;
                volumen = 1.0 / 3.0 * flaeche * hoehe;

                Console.WriteLine("Das Volumen der Pyramide ist: " + volumen + maeinheit + "³");
                Console.WriteLine("Die Grundfläche der Pyramide ist: " + flaeche + maeinheit + "²");
            }

            if (eingabe == 4)
            {
                Console.WriteLine("Gib Bitte den Radius, die Höhe");
                Console.Write("Radius: ");
                radius = Convert.ToInt32(Console.ReadLine());

                Console.Write("Höhe: ");
                hoehe = Convert.ToInt32(Console.ReadLine());

                Console.Write("Maßeinheit (optional): ");
                maeinheit = Convert.ToString(Console.ReadLine());

                flaeche = Math.PI * radius * radius;
                umfang = 2 * Math.PI * radius;
                mantelflaeche = umfang * hoehe;
                oberflaeche = 2 * flaeche + mantelflaeche;

                Console.WriteLine("Die Grundfläche des Zylinders ist: " + flaeche + maeinheit + "²");
                Console.WriteLine("Der Umfang des Zylinders ist: " + umfang + maeinheit);
                Console.WriteLine("Die Mantelfläche des Zylinders ist: " + mantelflaeche + maeinheit + "²");
                Console.WriteLine("Die Oberfläche des Zylinders ist: " + oberflaeche + maeinheit + "²");
            }

            //Console.ReadLine();
            Console.ReadKey();
        }
    }
}
