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
            double dPaino;
            double dPituus;
            string sNimi;
            double dBmi;
            Console.Write("Nimi: ");
            sNimi = Console.ReadLine();
            Console.Write("Kerro painosi kilon tarkkuudella: ");
            dPaino = double.Parse(Console.ReadLine());
            Console.Write("Kerro pituutesi metreissä: ");
            dPituus = double.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Nimesi on: {0}",sNimi);
            Console.WriteLine("Painosi on: {0}",dPaino);
            Console.WriteLine("Pituutesi on: {0}",dPituus);
            dBmi = dPaino/(dPituus*dPituus);
            Console.WriteLine("BMI:{0:N2}",dBmi);

        }
    }
}
