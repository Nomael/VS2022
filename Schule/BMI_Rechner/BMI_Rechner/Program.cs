using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BMI_Rechner
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int eingabe;

            double BMI;
            double kg;
            double m;


            Console.WriteLine("Bitte gebe die daten in den BMI Rechner ein");
            Console.Write("Gewicht: ");
            kg = Convert.ToDouble(Console.ReadLine());

            Console.Write("Größe: ");
            m = Convert.ToDouble(Console.ReadLine());

            BMI = kg / (m * m);

            Console.WriteLine(BMI);

            Console.WriteLine("Gebe nun 0 - 2 für die aufgaben A - C ein");

            eingabe = Convert.ToInt32(Console.ReadLine());

            switch (eingabe)
            {
                case 0:
                    if (BMI > 25)
                    {
                        Console.WriteLine("Sie sind zu schwer.");
                    }
                    else
                    {
                        if (BMI < 18)
                        {
                            Console.WriteLine("Sie sind zu leicht.");
                        }
                    }
                    break;

                case 1:
                    if (BMI > 25)
                    {
                        Console.WriteLine("Sie sind zu schwer.");
                    }
                    else
                    {
                        if (BMI < 18)
                        {
                            Console.WriteLine("Sie sind zu leicht.");
                        }
                        else
                        {
                            Console.WriteLine("Normalgewicht");
                        }
                    }

                    Console.WriteLine("Ende und Tschüss");
                    break;

                case 2:
                    if (BMI > 25)
                    {
                        Console.WriteLine("Sie sind zu schwer.");
                    }
                    else
                    {
                        if (BMI < 18)
                        {
                            Console.WriteLine("Sie sind zu leicht.");
                        }
                        else
                        {
                            Console.WriteLine("Normalgewicht");
                        }
                    }

                    Console.WriteLine("Ende und Tschüss");
                    Console.ReadLine();
                    break;
            }
            Console.ReadKey();
        }
    }
}
