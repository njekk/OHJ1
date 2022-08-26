using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Kotitehtävät
{
    class Program
    /* Jos Main-funktioon ei tullut yhtään parameteriä (0 kpl), niin silloin ohjelma päättyy ja tulostuu joku virheilmoitus.
     * Jos Main-funktioon tuli parametreja niin kirjoita tulleet parametrit ”parametrit.txt” tiedostoon allekkain. 
     * Sen jälkeen lue tiedostosta sinne kirjoitetut tiedot rivi kerrallaan ja tulosta näytölle. Käytä funktioita:

    
        Tallenna

        LueJaTulosta
    */
    {
        static void Tallenna(string[] args, string filename)
        {
            int i;
            DirectoryInfo drinfo = new DirectoryInfo("C:\\temp\\");
            if (drinfo.Exists == false)
            {
                drinfo.Create();
            }
            using(StreamWriter sw = new StreamWriter(filename))
            {
                for (i = 0; i < args.Length; i++)
                {
                    sw.WriteLine(args[i]);
                }
            }

        }
        static void LueJaTulosta(string filename)
        {

            using (StreamReader sr = new StreamReader(filename))
            {
                    Console.WriteLine(sr.ReadToEnd());
            }

        }
        static void Main(string[] args)
        {
            string filename = "C:\\Temp\\parametrit.txt";
            if (args.Length > 0)
            {
                Tallenna(args, filename);
                LueJaTulosta(filename);
            }
            else
            {
                Console.WriteLine("error, parameter(s) not found");
            }
       
        }
    }
}
