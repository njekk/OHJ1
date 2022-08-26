using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Tuntihommia
{
    class Program
    {
       
        static void Main(string[] args)
        {
            int ichild, iwork;
            double pay, over, extra, result;
            char living, again='k';
            Console.WriteLine("Tämä ohjelma laskee työmarkkinatuen määrän");
            while(again == 'k')
            {
                over = 0;
                extra = 0;
                result = 32.68;
                Console.Write("Kuinka monta lasta sinulla on: ");
                ichild = int.Parse(Console.ReadLine());
                if (ichild == 1)
                {
                    result+=5.27;
                }
                else if (ichild == 2)
                {
                    result += 7.74;
                }
                else if (ichild >= 3)
                {
                    result += 9.98;
                }
                Console.Write("Kuinka monena päivänä olet osallistunut työllistymistä edistävään palveluun: ");
                iwork = int.Parse(Console.ReadLine());
                if (iwork > 0)
                {
                    extra = iwork * 4.78;
                }
                Console.Write("Kuinka paljon olet saanut palkkaa: ");
                pay = double.Parse(Console.ReadLine());
                if (pay > 300)
                {
                    over = (pay - 300)/2;
                    
                }
                Console.Write("Asutko vanhempiesi luona (k/e): ");
                living = char.Parse(Console.ReadLine());
                
                result = result * 20 + extra - over;
                if (living == 'k')
                {
                    result = result / 2;
                }
                Console.WriteLine("Saat työmarkkinatukea {0:f2} euroa kuukaudessa", result);
                Console.WriteLine("Haluatko laskea työmarkkinatuen uusilla tiedoilla (k/e): ");
                again = char.Parse(Console.ReadLine());
                Console.Clear();

            }
            


            
        }
    }
}
