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
            string slaskin;
            double dInp1, dInp2;

            Console.Write("Anna ensimmäinen luku: ");
            dInp1 = double.Parse(Console.ReadLine());
            Console.Write("Anna toinen luku: ");
            dInp2 = double.Parse(Console.ReadLine());


            Console.WriteLine("Summa: Paina 1");
            Console.WriteLine("Erotus: Paina 2");
            Console.WriteLine("Tulo: Paina 3");
            Console.WriteLine("Osamäärä: Paina 4");
            slaskin = Console.ReadLine();
            if (slaskin.All(char.IsLetter))
                Console.WriteLine("Ei kirjaimia");
            {
                switch (slaskin)
                {
                    case "1":
                        Console.WriteLine("{0}+{1}={2}", dInp1, dInp2, dInp1 + dInp2);
                        break;

                    case "2":
                        Console.WriteLine("{0}-{1}={2}", dInp1, dInp2, dInp1 - dInp2);
                        break;
                    case "3":
                        Console.WriteLine("{0}*{1}={2}", dInp1, dInp2, dInp1 * dInp2);
                        break;
                    case "4":
                        if(dInp2 == 0) 
                        {
                            Console.WriteLine("Ei nollalla jakoa :)");
                        }
                        else if (dInp2>=0)
                        {
                            Console.WriteLine("{0}/{1}={2}", dInp1, dInp2, dInp1 / dInp2);
                        }
                        break;
                }
            }

        }
    }
}
