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
            int month;
            Console.Write("Kerro kuukauden numero: ");
            month = int.Parse(Console.ReadLine());

            switch (month)
            {
                case 12:
                case 1:
                case 2:
                    Console.WriteLine("Nyt on talvi");
                    break;

                case 3:
                case 4:
                case 5:
                    Console.WriteLine("Nyt on kevät");
                    break;
                case 6:
                case 7:
                case 8:
                    Console.WriteLine("Nyt on kesä");
                    break;
                case 9:
                case 10:
                case 11:
                    Console.WriteLine("Nyt on syksy");
                    break;
            }
        }
    }
}
