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
            string words;
            int i;

            Console.Write("Kirjoita minulle lause: ");
            words = Console.ReadLine();
            Console.WriteLine("{0}", words.ToUpper());
            Console.WriteLine("{0}", words.Replace('A', '!'));
            words = words.Replace(" ", "");
            Console.WriteLine("{0}", words);
            for (i = words.Length - 1; i >= 0; i--)
            {
                Console.Write("{0} ",words[i]);
            }
            Console.WriteLine();
        }
    }
}
