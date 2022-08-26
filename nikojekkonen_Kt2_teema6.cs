using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Kotitehtävät
{
    class Program
    /* Arvo 40 kpl liukulukuja väliltä 1.4 – 5.8 ja kirjoita ne datat.txt tiedostoon allekkain. Älä käytä taulukkoa tässä vaiheessa. Sen jälkeen luo 40 alkioinen double-taulukko ja lue arvot tiedostosta taulukkoon.
        Tämän jälkeen tulosta taulukon lukujen summa, keskiarvo, minimiarvo ja maksimiarvo.
        Käytä funktioita:


        ArvoJaTallennaTiedostoon

        LueTiedostosta

        TulostaTiedot
    */
    {
        static void ArvoJaTallennaTiedostoon(string filename)
        {
            Random rnd = new Random();
            int i;
            double num;
            using (StreamWriter Sw = new StreamWriter(filename))
            {
                for (i = 0; i < 40; i++)
                {
                    num = rnd.NextDouble() * 4.4 + 1.4;
                    Sw.WriteLine("{0:f1}", num);  
                }
            }
        }
        static void LueTiedostosta(out double[] all, string filename)
        {
            int i;
            all = new double [40];
            using (StreamReader Sr = new StreamReader(filename))
            {
                for (i = 0; i < all.Length; i++)
                {
                    all[i] = double.Parse(Sr.ReadLine());
                }
            }
        }
        static void TulostaTiedot(double[] all)
        {
            Console.WriteLine("{0}", all.Sum());
            Console.WriteLine("{0}", all.Average());
            Console.WriteLine("{0}", all.Min());
            Console.WriteLine("{0}", all.Max());

        }
        static void Main(string[] args)
        {
            DirectoryInfo Di = new DirectoryInfo("C:\\Temp\\");
            if (Di.Exists != true)
            {
                Di.Create();
            }
            string filename = "C:\\Temp\\datat.txt";
            double[] all;
            ArvoJaTallennaTiedostoon(filename);
            LueTiedostosta(out all, filename);
            TulostaTiedot(all);
        }
    }
}
