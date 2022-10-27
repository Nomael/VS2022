using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Malchow_K1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //------------------------------------------------------------
            // Name:			ZeichenProgramm
            // 
            // Funktion:    Zeichnet verschiedene Formen auf die Konsole
            // -----------------------------------------------------------
            // Parameter: keine
            // ------------------------------------------------------------
            // 21.10.2022  1.Version
            // ------------------------------------------------------------


            string eingabe;

			do
			{
				Console.Clear();
				Console.WriteLine("Zeichenprogramm (by Noel Malchow)");
				Console.WriteLine("---------------------");
				Console.WriteLine("Bitte gebe eine Aufgabe ein");
				Console.WriteLine("(a) Zeichne ein Quadrat");
				Console.WriteLine("(b) Zeichne ein Rechteck");
				Console.WriteLine("(c) Zeichne ein Dreieck");
                Console.WriteLine("(d) Zeichne eine Linie");
                Console.WriteLine("---------------------");
				Console.WriteLine("(end) Ende");

				Console.Write("\nAufgabe: ");
				eingabe = Console.ReadLine();

				switch (eingabe)
				{
					case "a":
						ZeichneQuadrat();
                        break;
					case "b":
						int zrbreite;
						int zrhöhe;

						zrbreite = Convert.ToInt32(Console.ReadLine());
                        zrhöhe = Convert.ToInt32(Console.ReadLine());

                        ZeichneRechteck(zrbreite,zrhöhe);
						break;

					case "c":
						int zdbreite;

                        zdbreite = Convert.ToInt32(Console.ReadLine());

                        ZeichneDreieck(zdbreite);
						break;

                }

				if (eingabe != "end")
				{
					Console.ReadKey();
				}

			} while (eingabe != "end");
		}

		static void ZeichneQuadrat()
		{
			int zqgröße = 9;

			for (int i = 0; i < zqgröße; i++)
			{
				for (int j = 0; j < zqgröße; j++)
				{
					Console.Write("##");
				}
				Console.Write("\n");
			}
		}

		static void ZeichneRechteck(int pbreite, int phöhe)
		{
            for (int i = 0; i < phöhe; i++)
            {
                for (int j = 0; j < pbreite; j++)
                {
                    Console.Write("#");
                }
                Console.Write("\n");
            }
        }

		static void ZeichneDreieck(int pbreite)
		{
            for (int zdzeile = 1; zdzeile <= pbreite; zdzeile++)
            {
                for (int zdspalte = 1; zdspalte <= zdzeile; zdspalte++)
                {
                    Console.Write("#");
                }
                Console.WriteLine(" ");
            }
        }
    }
}
