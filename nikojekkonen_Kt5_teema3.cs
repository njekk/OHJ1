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
            char mark;

            Console.Write("anna merkkejä, paina enter lopettaaksesi: ");
            do
            {
                mark = Console.ReadKey(true).KeyChar;

                if (char.IsUpper(mark) == true)
                {
                    mark = char.ToLower(mark);
                    Console.Write(mark);
                }
                else if (char.IsLower(mark) == true)
                {
                    mark = char.ToUpper(mark);
                    Console.Write(mark);
                }

            } while (mark != '\r');
            Console.WriteLine();

        }
    }
}
