using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kotitehtävät
{
    class Program
    {
        static void Main(string[] args)
        {
            double dPii = 3.141593;
            double dhalk;
            double ds;
            double dPiiri;
            double dPinta;
            Console.Write("Kirjoita ympyrän halkaisija: ");
            dhalk = double.Parse(Console.ReadLine());
            ds = (dhalk / 2);
            dPiiri = (2 * dPii * ds);
            dPinta = (dPii * (ds * ds));
            Console.WriteLine("Ympyrän piiri on {0:n6} ja pinta-ala on {1:n6}", dPiiri, dPinta);


        }
    }
}
