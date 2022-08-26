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
            double laskuri1, laskuri2;
            for (laskuri1 = 11, laskuri2 = 10; laskuri1 <=20 && laskuri2 >=1; laskuri1++, laskuri2--)
            {
                    Console.WriteLine("{0}\t {1}", laskuri1, laskuri2);
            }


        }
    }
}
