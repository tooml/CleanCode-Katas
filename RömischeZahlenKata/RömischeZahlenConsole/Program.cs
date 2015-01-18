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
            DezimalzahlenWandler test = new DezimalzahlenWandler();
            var zahl = test.ParseRömischeZahlInDezimal("MDCLXXIX");
            Console.WriteLine(zahl);

            Console.ReadKey();
        }
    }
}
