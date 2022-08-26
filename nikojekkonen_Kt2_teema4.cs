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
            int[] chart = new int[10];
            Random rnd = new Random();
            int i;

            for (i = 0; i < chart.Length; i++)
            {
                chart[i] =rnd.Next(11);
                if (chart[i] % 2 !=0)
                {
                    chart[i] = rnd.Next(0,11);
                    i--;
                }
            }

            foreach (int inum in chart)
            {
                Console.Write("{0}\t", chart[inum]);
            }
            Console.WriteLine();

        }
    }
}
