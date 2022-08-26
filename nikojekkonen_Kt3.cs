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
            double dLuku1;
            double dLuku2;
            Console.Write("Anna ensimmäinen luku: ");
            dLuku1 = double.Parse(Console.ReadLine());
            Console.Write("Anna toinen luku: ");
            dLuku2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Summa:   {0}+{1}={2}", dLuku1,dLuku2,dLuku1+dLuku2);
            Console.WriteLine("Erotus:  {0}-{1}={2}", dLuku1,dLuku2,dLuku1-dLuku2);
            Console.WriteLine("Tulo:    {0}*{1}={2}", dLuku1,dLuku2,dLuku1*dLuku2);
        }
    }
}
