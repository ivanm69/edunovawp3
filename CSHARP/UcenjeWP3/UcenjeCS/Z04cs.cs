using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class Z04cs
    {
        public static void Izvedi()
        {
            Console.Write("Unesite prvi broj: ");
            int prviBroj = int.Parse(Console.ReadLine());

            Console.Write("Unesite drugi broj: ");
            int drugiBroj = int.Parse(Console.ReadLine());

            Console.WriteLine("Neparni brojevi između {0} i {1} su:", prviBroj, drugiBroj);
           
            for (int i = prviBroj; i <= drugiBroj; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);

                }
            }
        }
    }
}
