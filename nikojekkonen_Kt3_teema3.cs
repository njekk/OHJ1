using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kotitehtävät
{
    class Program
    {
        const double ARVATTA_LUKU = 404;
        /* Laita vakioon ARVATTAVA_LUKU joku arvo väliltä 1-500. Tee ohjelma, joka pyytää arvaamaan lukua.Jos käyttäjä syötti isomman luvun kuin vakiossa, niin tulosta : ”Annoit liian ison luvun”.
        Jos taas käyttäjän syöttämä luku oli pienempi kuin vakion luku niin tulosta : ”Annoit liian pienen luvun”.
        Kun käyttäjä arvaa luvun oikein niin tulosta : ”Oikein, arvasit luvun 27 kerralla!”. Missä siis arvo 27 kertoo montako kierrosta meni ennen kuin käyttäjä arvasi oikein */
        static void Main(string[] args)
        {
            double i = 0;
            double quess=0;

            Console.WriteLine("arvaa luku 1-500 väliltä");

            do
            {
                quess = double.Parse(Console.ReadLine());
                if (quess < ARVATTA_LUKU)
                {
                    Console.WriteLine("Annoit liian pienen luvun");
                }
                else if ( quess > ARVATTA_LUKU)
                {
                    Console.WriteLine("Annoit liian ison luvun");
                }
                i++;
                

            } while (quess != ARVATTA_LUKU);

            Console.Clear();
            Console.WriteLine("Oikein! Sait luvun oikein {0} yrityksellä", i);
        }
    }
}
