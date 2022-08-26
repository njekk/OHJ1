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
            double[] chart = new double[3];

            Console.Write("Anna eka luku taulukkoon");
            chart[0] = double.Parse(Console.ReadLine());
            Console.Write("Anna toka luku taulukkoon");
            chart[1] = double.Parse(Console.ReadLine());
            Console.Write("Anna kolmas luku taulukkoon");
            chart[2] = double.Parse(Console.ReadLine());

            Console.WriteLine("lukujen summa on: {0}", chart.Sum());
            Console.WriteLine("lukujen keskiarvo on: {0}", chart.Average());

        }
    }
}
