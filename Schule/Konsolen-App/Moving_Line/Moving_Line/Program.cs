using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Moving_Line
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int xpos = 0;
            int ypos = 0;
            int laenge = 0;

            ypos = Convert.ToInt32(Console.ReadLine());
            xpos = Convert.ToInt32(Console.ReadLine());
            laenge = Convert.ToInt32(Console.ReadLine());

            int laengemin = 100;

            //moving_loader(ypos, laenge, laengemin);
            moving_line(ypos, xpos, laenge);


            Console.ReadKey();
        }

        static void moving_loader(int pypos, int plaenge, int plaengeminus)
        {
            do
            {
                Console.Clear();
                for (int i = 0; i < pypos; i++)
                {
                    Console.Write("\n");
                }

                Console.Write("Downloading[");
                for (int i = 0; i < plaenge; i++)
                {
                    Console.Write("=");
                }

                Console.Write(">]" + plaenge);

                Thread.Sleep(500);
                if (plaengeminus != 0)
                {
                    plaengeminus--;
                    plaenge++;
                }

            } while (plaengeminus != 0);
        }

        static void moving_line(int pypos, int pxpos, int plaenge)
        {
            do
            {
                Console.Clear();
                for (int i = 0; i < pypos; i++)
                {
                    Console.Write("\n");
                }

                for (int i = 0; i < pxpos; i++)
                {
                    Console.Write(" ");
                }

                for (int i = 0; i < plaenge; i++)
                {
                    Console.Write("#");
                }

                Thread.Sleep(500);
                pxpos++;

            } while (true);
        }
    }
}
