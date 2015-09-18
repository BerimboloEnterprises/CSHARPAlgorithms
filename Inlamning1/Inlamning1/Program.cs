using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inlamning1
{
    //Code by Marcus Lindstedt

    class Program
    {
        /// <summary>
        /// Initiates the application
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Uppgift1A A = new Uppgift1A();

            Console.WriteLine("Press a key to proceed");
            Console.ReadKey();

            Uppgift1B B = new Uppgift1B();
        }
    }
}
