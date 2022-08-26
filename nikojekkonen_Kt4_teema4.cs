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
            int[] igrid = new int[8];
            Random rnd = new Random();
            int i, irandom;

            for(i = 0; i < igrid.Length; i++)
            {
                irandom = rnd.Next(1, 41);

                if (igrid.Contains(irandom) == true)
                {
                    i--;
                }
                else
                {
                    igrid[i] = irandom;
                }
            }
            for (i = 0; i < 7; i++)
            {
                Array.Sort(igrid, 0, 7);
                Console.Write("{0} ",igrid[i]);
            }
            Console.Write("+ {0}", igrid[7]);
            Console.WriteLine();

        }
    }
}
