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
            double testnumber;

            Console.Write("Anna koenumero 4-10: ");
            testnumber = double.Parse(Console.ReadLine());
            
            if (testnumber > 10) 
            {
                Console.WriteLine("Et antanut arvosanaa annetulta väliltä");
            }
            if (testnumber < 4) 
            {
                Console.WriteLine("Et antanut arvosanaa annetulta väliltä");
            }
            if (testnumber is 10) 
            {
                Console.WriteLine("Hyvä!");
            }
            if (testnumber is 9)
            {
                Console.WriteLine("Hyvä!");
            }
            if (testnumber is 8)
            {
                Console.WriteLine("Kelpo");
            }
            if (testnumber is 7)
            { 
                Console.WriteLine("Kelpo"); 
            }
            if (testnumber is 6)
            {
                Console.WriteLine("Tyydyttävä");
            }

            if (testnumber is 5)
            {
                Console.WriteLine("Tyydyttävä");
            }
            if (testnumber is 4)
            {
                Console.WriteLine("Heikko");
            }



        }
    }
}
