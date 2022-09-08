using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alter_Erkennung
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int alter;
            Console.WriteLine("Bitte gib dein Alter ein!");
            Console.Write("Alter: ");
            alter = Convert.ToInt32(Console.ReadLine());

            if(alter >= 18)
            {
                Console.WriteLine("Volljährig");
            }
            else if (alter < 12) {
                Console.WriteLine("Kind");
            }
            else
            {
                Console.WriteLine("Jugendlich");
            }

            Console.ReadKey();
        }
    }
}
