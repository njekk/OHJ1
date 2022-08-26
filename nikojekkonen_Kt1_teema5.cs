using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kotitehtävät
{
    class Program
    {       
        static int KysyJaTestaaLuku()
        {
            int inum, ireturn=0;
            Console.Write("Anna kokonaisluku: ");
            inum = int.Parse(Console.ReadLine());
            if (inum > 0)
            {
                ireturn= 1;
            }
            else if (inum < 0)
            {
                ireturn =-1;
            }
            Console.Clear();
            return ireturn;
            
        }
        static void Main(string[] args)
        {
            
            switch (KysyJaTestaaLuku())
            {
                case 1:
                    Console.WriteLine("Luku oli positiivinen");
                    break;
                case -1:
                    Console.WriteLine("Luku oli negatiivinen");
                    break;
                case 0:
                    Console.WriteLine("Luku oli nolla");
                    break;

            }

        }   
    }
}
