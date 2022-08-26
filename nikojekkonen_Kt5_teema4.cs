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
            int i, j;
            double[,] chart = new double[5, 4];

            for (i = 0; i < chart.GetLength(0)-4; i++)
            {
                for (j = 0; j < chart.GetLength(1); j++)                     
                {
                    Console.Write("Anna maanantain {0}. mittaustulos: ", j + 1);
                    chart[i,j] = double.Parse(Console.ReadLine());
                }
                
            }
            Console.Clear();
            for (i = 1; i < chart.GetLength(0) - 3; i++)
            {
                for (j = 0; j < chart.GetLength(1); j++)            
                {
                    Console.Write("Anna tiistain {0}. mittaustulos: ", j + 1);
                    chart[i, j] = double.Parse(Console.ReadLine());
                }

            }
            Console.Clear();
            for (i = 2; i < chart.GetLength(0) - 2; i++)
            {
                for (j = 0; j < chart.GetLength(1); j++)            
                {
                    Console.Write("Anna keskiviikon {0}. mittaustulos: ", j + 1);
                    chart[i, j] = double.Parse(Console.ReadLine());
                }

            }
            Console.Clear();
            for (i = 3; i < chart.GetLength(0)-1; i++)
            {
                for (j = 0; j < chart.GetLength(1); j++)        
                {
                    Console.Write("Anna torstain {0}. mittaustulos: ", j + 1);
                    chart[i, j] = double.Parse(Console.ReadLine());
                }

            }
            Console.Clear();
            for (i = 4; i < chart.GetLength(0); i++)         
            {
                for (j = 0; j < chart.GetLength(1); j++)
                {
                    Console.Write("Anna perjantain {0}. mittaustulos: ", j + 1);
                    chart[i, j] = double.Parse(Console.ReadLine());
                }

            }
            Console.Clear();

            Console.WriteLine("Maanantai  : {0:f1}mm ",(chart[0,0] + chart[0, 1] + chart[0, 2] + chart[0, 3]) / 4);
            Console.WriteLine("Tiistai    : {0:f1} mm", (chart[1, 0] + chart[1, 1] + chart[1, 2] + chart[1, 3]) / 4);
            Console.WriteLine("Keskiviiko : {0:f1} mm", (chart[2, 0] + chart[2, 1] + chart[2, 2] + chart[2, 3]) / 4);
            Console.WriteLine("Torstai    : {0:f1} mm",(chart[3, 0] + chart[3, 1] + chart[3, 2] + chart[3, 3]) / 4);
            Console.WriteLine("Perjantai  : {0:f1} mm",(chart[4, 0] + chart[4, 1] + chart[4, 2] + chart[4, 3]) / 4);
        }   
    }
}
