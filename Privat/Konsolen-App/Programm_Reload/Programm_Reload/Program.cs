using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Programm_Reload
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Programm Reload is active an it reloads after 2 Seconds
            progreload(true, 2000);
        }

        // (Code from https://stackoverflow.com/questions/5706497/how-restart-the-console-app)
        /// <summary>
        /// Small Programm to Reload the Console.
        /// </summary>
        /// <param name="pActive">Tests if the programm should be Reloaded</param>
        /// <param name="pTermWait">Time to Wait before the Reload initialize</param>
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
