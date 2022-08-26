using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kotitehtävät
{
    class Program
    {       /*Kysy käyttäjältä kuinka iso taulukko luodaan. Luo taulukko ja arvo siihen arvosanoja väliltä 0-5. Tutki kuinka moni sai hylätyn arvosanan eli arvosanan 0. 
                Tulosta määrä näytölle.
                Käytä ohjelmassa seuraavia funktioita:

                KysyKoko
                LuoTaulukko
                ArvoArvosanat
                TutkiHylatyt
                Tulosta
            */
        static void KysyKoko(out int oisize)
        {
            Console.Write("Kuinka iso taulukko luodaan? ");
            oisize= int.Parse(Console.ReadLine());
        }
        static int[] LuoTaulukko(int aisize)
        {
            return new int[aisize];
        }
        static void ArvoArvosanat(int[] igrid)
        {
            int i;
            Random rnd = new Random();
            for (i = 0; i < igrid.Length; i++)
            {
                igrid[i] = rnd.Next(6);
            }
        }
        static void Tutkihylatyt(int []igrid, out int f)
        {
            f = 0;
            int i;
            for (i = 0; i < igrid.Length; i++)
            {
                if (igrid[i]==0)
                {
                    f++;
                }
            }

        }
        static void Tulosta(int f)
        {
            Console.WriteLine(f);
        }
        static void Main(string[] args)
        {
            int f;
            int isize;
            int[] igrid;

            KysyKoko(out isize);
            igrid= LuoTaulukko(isize);
            ArvoArvosanat(igrid);
            Tutkihylatyt(igrid, out f);
            Tulosta(f);
        }
    }
}
