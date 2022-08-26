using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kotitehtävät
{
    class Program 
        /* tee ohjelma, joka tulostaa ensin tiedon siitä, kuinka monta parametria Main-funktioon tuli. 
           Lisäksi jos ensimmäisen parametri oli "opettaja" niin tulosta "Koita saada oppilaat oppimaan", jos se taas oli "opiskelija", niin tulosta "koita opiskella ahkerasti".
           Jos se oli jotain muuta, niin tulosta "en ymmärrä" */
    {      
        static void Main(string[] args)
        {
            Console.WriteLine("Parametrejä löytyy {0} kappaletta", args.Length);
            Console.WriteLine();
            if (args[0] == "opettaja")
            {
                Console.WriteLine("Koita saada oppilaat oppimaan");
            }
            else if (args[0] == "opiskelija")
            {
                Console.WriteLine("koita opiskella ahkerasti");
            }
            else
            {
                Console.WriteLine("En ymmärrä");
            }
        }
    }
}
