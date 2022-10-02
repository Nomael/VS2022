using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Textcolor_Changer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // It Changes the Color of the Text "Hello" to Green
            txtcolor("Hello", "Green");
        }

        // (Code from https://stackoverflow.com/questions/19275947/c-sharp-how-can-i-append-a-string-variable-on-to-the-end-of-consolecolor)
        /// <summary>
        /// A Little Programm to Color the Input.
        /// </summary>
        /// <param name="pText">The Text that should be displayed</param>
        /// <param name="pColor">The Color that is changing the Text</param>
        static void txtcolor(string pText, string pColor)
        {
            Console.ForegroundColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), pColor);
            Console.Write(pText);
            Console.ResetColor();
        }
    }
}
