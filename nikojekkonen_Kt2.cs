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
            string sEtunimi;
            string sSukunimi;
            string sKokonimi;
            Console.Write("Etunimi: ");
            sEtunimi = Console.ReadLine();
            Console.Write("Sukunimi: ");
            sSukunimi = Console.ReadLine();
            sKokonimi = (sEtunimi + " " + sSukunimi);
            Console.WriteLine("Hyvää iltaa {0}", sKokonimi);
        }
    }
}
