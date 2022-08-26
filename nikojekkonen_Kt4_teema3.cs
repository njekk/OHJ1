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
            double start, spacing, end, total1, total2, total3;

            Console.Write("Anna luku, josta aloitetaan: ");
            start = double.Parse(Console.ReadLine());

            Console.Clear();

            do
            {
                Console.Write("Anna luku, johon lopetataan: ");
                end = double.Parse(Console.ReadLine());
                if (end < start)
                {
                    Console.WriteLine("lopetus luku täytyy olla suurempi kuin aloitus!");
                    Console.WriteLine("Yritä uudelleen");
                }
            } while (end < start);

            Console.Clear();

            do
            {
                Console.Write("Anna askellus luku: ");
                spacing = double.Parse(Console.ReadLine());
                if (spacing == 0)
                {
                    Console.WriteLine("Askellus ei voi olla 0!");
                    Console.WriteLine("Yritä uudelleen");
                }
            } while (spacing == 0);

            Console.Clear();

            Console.WriteLine("Aloitetaan luvusta {0}, edetään {1} askelella, lopetetaan lukuun {2}", start, spacing, end);

            total1 = start;
            total2 = start;

            while (total1 <= end)
            {
                Console.WriteLine(total1);
                total1 += spacing;
            }

            do
            {
                Console.WriteLine("\t{0}", total2);
                total2 += spacing;

            } while (total2 <= end);

            for (total3=start;total3 <= end ;total3+=spacing)
            {
                Console.WriteLine("\t\t{0}", total3);
            }

            

        }
    }
}
