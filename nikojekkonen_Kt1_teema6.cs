using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Kotitehtävät
{
    class Program
    /* Luo C:\temp hakemiston alle for-silmukassa hakemistot

        hakemisto1
        hakemisto2
        ....
        hakemisto10
        sen jälkeen hae string-taulukkoon kaikki c:\temp:ssä olevat hakemistot ja jossakin silmukassa tuhoa ne.*/
    {
        static void Main(string[] args)
        {
            int i;
            string[] all;
            DirectoryInfo Temp = new DirectoryInfo("C:\\Temp\\");
            if(Temp.Exists == false)
            {
                Temp.Create();
            }
            for(i=1; i <= 10; i++)
            {
                Temp.CreateSubdirectory("hakemisto" + i);
            }
            all = Directory.GetDirectories("C:\\Temp\\");
            for (i=0; i < all.Length; i++)
            {
                Directory.Delete(all[i]);
            }
        }
    }
}
