using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kotitehtävät
{
    class Program
    /*  Luo 7 alkioinen float-taulukko ja lue siihen käyttäjältä arvoja. Kun käyttäjä syöttää arvoa taulukkoon, niin ohjelma ei saa kaatua vaan väärä arvo on kysyttävä uudestaan.
     *  Lajittele taulukko ja tulosta taulukon minimi- ja maksimiarvot. Käytä funktioita:
     *  
        LuoTaulukko
        KysyArvotTaulukkoon
        LajitteleTaulukko
        TulostaTiedot 
    */
    {
        static void LuoTaulukko(out float[] fgrid)
        {
            fgrid = new float[7];
        }
        static void KysyArvotTaulukkoon(float[] fgrid)
        {
            int i;
            bool bsuccess;
            for (i=0; i<fgrid.Length; i++)
            {
                Console.Write("Anna {0}. numeron arvo: ", i + 1);
                bsuccess = float.TryParse(Console.ReadLine(), out fgrid[i]);
                while (bsuccess == false)
                {
                    Console.WriteLine("Tuo ei ollut numero");
                    Console.Write("kokeileppas uudellee: ");
                    bsuccess = float.TryParse(Console.ReadLine(), out fgrid[i]);
                }

            }
            Console.Clear();

        }
        static void LajitteleTaulukko(float[] fgrid)
        {
            Array.Sort(fgrid);
        }
        static void TulostaTiedot(float[] fgrid)
        {
            Console.WriteLine("pienin arvo oli {0}", fgrid.Min());
            Console.WriteLine("isoin arvo oli {0}", fgrid.Max());

        }
        static void Main(string[] args)
        {
            float[] fgrid;
            LuoTaulukko(out fgrid);
            KysyArvotTaulukkoon(fgrid);
            LajitteleTaulukko(fgrid);
            TulostaTiedot(fgrid);
        }
    }
}
