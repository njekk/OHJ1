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
            double dPii = 3.1415926535897932384626433832795028841971693993751058209749445923078164062862089986280348253421170679;
            string sHtunnus = "260010C672E";
            string sNimenEkaKirjain = "N";
            double dLampotila = 9.2;
            Console.WriteLine(dPii);
            Console.Write(sHtunnus);
            Console.WriteLine(); //tässä halusin kokeilla, miten saan writen jälkeen tulevat rivit allekkain :) ilmeisesti näin
            Console.WriteLine(sNimenEkaKirjain);
            Console.WriteLine(dLampotila);
        }
    }
}
