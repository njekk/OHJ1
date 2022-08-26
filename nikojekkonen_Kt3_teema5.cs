using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kotitehtävät
{
    class Program
    {      
        const double KR_PISTE = 90;
        static void KysyHypynPituus(out double olength)
        {
            Console.WriteLine("Mitenkäs pitkälle sitä hypättiin? ");
            olength = double.Parse(Console.ReadLine());
        }
        static void KysyTuomareidenPisteet(double[] score)
        {
            int i;
            for (i = 0; i < score.Length; i++)
            {
                Console.Write("{0}. tuomarin pisteet: ", i+1);
                score[i] = double.Parse(Console.ReadLine());
            }
        }
        static void LaskeHypynPisteet(double[] score, double length, out double total)
        {
            Array.Sort(score);
            total = (length - KR_PISTE) * 1.8 + (score[1] + score[2] + score[3]) + 60;
        }
        static void Tulosta(double total)
        {
            Console.WriteLine("Kokonaispisteet ovat: {0:f1}", total);
        }
        static void Main(string[] args)
        {
            double length, total;
            double[] score = new double[5];
            KysyHypynPituus(out length);
            KysyTuomareidenPisteet(score);
            LaskeHypynPisteet(score, length, out total);
            Tulosta(total);
        }
    }
}
