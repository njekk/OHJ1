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
            int saction;
            float fliukuluku;
            double fPiiri;
            double fPinta;
            double saction2;

            Console.Write("Anna ympyrän säde liukulukuna: ");
            fliukuluku = float.Parse(Console.ReadLine());
            
            Console.WriteLine("Paina 1, jos haluat laskea ympyrän piirin");
            Console.WriteLine("Paina 2 jos haluat laskea ympyrän pinta-alan");
            saction = int.Parse(Console.ReadLine());
            fPinta = (Math.PI * (fliukuluku * fliukuluku));
            fPiiri = 2 * (Math.PI) * fliukuluku;

            if (saction == 1)
            {
                Console.WriteLine(fPiiri);
            }
            else if (saction == 2)
            {
                Console.WriteLine(fPinta);
            }
            saction2 = (saction == 1) ? fPiiri : fPinta;
            Console.WriteLine(saction2);

        }
    }
}
