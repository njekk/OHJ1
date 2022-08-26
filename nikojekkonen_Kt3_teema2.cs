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
            int temp;
            Console.WriteLine("Kerro lämpötila ");
            temp = int.Parse(Console.ReadLine());

            if (39 <= temp)
            {
                Console.WriteLine("Liian kuuma");
            }
            if (temp >= 11 && temp <=39)
            {
                Console.WriteLine("Lämmintä");
            }
            if (temp >= 0 && temp <= 11)
            {
                Console.WriteLine("Haalea");
            }
            if (temp <= -1 && temp >= -30)
            {
                Console.WriteLine("Pakkasta");
            }
            if (temp <= -30)
            {
                Console.WriteLine("Liian kylmä");
            }
        }
    }
}
