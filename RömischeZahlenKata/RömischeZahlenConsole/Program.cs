using RömischeZahlen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RömischeZahlenConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            RömischeZahlenConverter converter = new RömischeZahlenConverter();
            var zahl = converter.ParseRömischeZahlInDezimal("MDCLXXIX");
            Console.WriteLine(zahl);

            Console.ReadKey();
        }
    }
}
