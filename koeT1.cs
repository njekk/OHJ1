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
        static void LueArvot(out int num1, out int num2)
        {
            Console.WriteLine("Lasketaan kahden luvun osamäärä");
            Console.Write("anna ensimmäinen luku: ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("anna toinen luku: ");
            num2 = int.Parse(Console.ReadLine());
            while (num2 == 0)
            {
                Console.Write("ja ei sitten jaeta nollalla, anna jokin toinen luku: ");
                num2 = int.Parse(Console.ReadLine());
            }

        }
        static void Tulosta(int num1, int num2)
        {
            Console.WriteLine("Antamiesi lukujen osamäärä on {0:f2}", (double)num1 / num2);
        }
        static void Main(string[] args)
        {
            int num1, num2;
            LueArvot(out num1, out num2);
            Tulosta(num1, num2);
        }
    }
}
