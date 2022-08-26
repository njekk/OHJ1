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
            double input;
            double quantity=0;
            double overall = 0;
            double average;
            Console.WriteLine("Anna lukuja, syötä -1 lopettaaksesi: ");
            input = double.Parse(Console.ReadLine());
            overall = input;

            while (input != -1)
            {
                input = double.Parse(Console.ReadLine());
                overall = overall + input;
                ++quantity;
            }

            average = (overall+1) / quantity;
            Console.WriteLine("antamiesi lukujen keskiarvo on {0}", average);


        }
    }
}
