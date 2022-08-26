using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Kotitehtävät
{
    class Program
    /* Kirjoita C#-kielinen ohjelma, joka kysyy käyttäjän nimeä,
     * kuitenkin enintään 18 merkkiä ja sitten tulostaa sen alla kuvatusti nousevana ja pituudesta riippumatta sivusuunnassa keskelle kuvaruutua.
     * Jotta teksti hahmottuisi riviksi, lisää kaksi välilyöntiä perättäisten merkkien väliin. 
     * Kirjoita tämä myös nimi.txt-tiedostoon

 

        Anna nimesi (max. 18 merkkiä):  Teemu Tekulainen
    */
    {
        static void Main(string[] args)
        {
            string name, reversed="";
            int i, j, pituus;
            Console.Write("Anna nimesi (max. 18 merkkiä): ");
            name = Console.ReadLine();
            while (name.Length > 18)
            {
                Console.Write("Nimesi on yli 18 merkkiä, lyhennä se: ");
                name = Console.ReadLine();
            }
            for (i=name.Length-1;i >= 0; i--)
            {
                reversed= reversed + name[i];
            }
            Console.Clear();
            pituus = name.Length;
            DirectoryInfo drinfo = new DirectoryInfo("C:\\Temp\\");
            if (drinfo.Exists == false)
            {
                drinfo.Create();
            }
            using (StreamWriter sw = new StreamWriter("C:\\Temp\\nimi.txt"))
            {
                for (i = 0; i < pituus; i++)
                {
                    for (j = 1; j <= Console.WindowWidth / 2 - i; j++)
                    {
                        Console.Write("  ");
                        sw.Write("  ");
                    }
                    Console.WriteLine(reversed[i]);
                    sw.Write(reversed[i]);
                }

            }

       
        }
    }
}
