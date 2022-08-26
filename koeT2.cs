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
            string stuff;
            int i;
            Console.Write("anna teksti, teen sille sitten taikoja: ");
            stuff = Console.ReadLine();
            stuff = stuff.ToLower();
            for(i=0; i<stuff.Length; i++)
            {
                Console.WriteLine(stuff[i]);
                i++;
            }
        }
    }
}
