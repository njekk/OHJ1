using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Tuntihommia
{
    class Program
    {
        static void ArvoTaulukkoon(int[] inums)
        {
            Random rnd = new Random();
            int i;
            for (i = 0; i < inums.Length; i++)
            {
                inums[i] = rnd.Next(9, 30);
            }

        }
        static void TallennaTiedostoon(int[] inums)
        {
            DirectoryInfo drinf = new DirectoryInfo("c:\\temp");
            if (drinf.Exists != true)
            {
                drinf.Create();
            }
            int i;
            using (StreamWriter sw = new StreamWriter("c:\\temp\\numerot.txt"))
            {
                for (i = 0; i < inums.Length; i++)
                {
                    sw.WriteLine(inums[i]);
                }
            }

        }
        static void LueLuvutJaTulostaParittomat(int[] inums)
        {
            int i;
            using (StreamReader sr = new StreamReader("c:\\temp\\numerot.txt"))
            {
                for (i=0; i < inums.Length; i++)
                {
                    inums[i] = int.Parse(sr.ReadLine());
                    if(inums[i] % 2 != 0)
                    {
                        Console.WriteLine(inums[i]);
                    }
                }
            }


        }
        static void Main(string[] args)
        {
            int[] inums = new int[104];
            ArvoTaulukkoon(inums);
            TallennaTiedostoon(inums);
            LueLuvutJaTulostaParittomat(inums);
        }
    }
}
