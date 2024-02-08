using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class Z05
    {
        public static void Izvedi()
        {

            Console.Write("Unesite cijeli broj: ");
            int b = int.Parse(Console.ReadLine());
            int zbroj = 0;

            for (int i = 1; i <= b; i++)
            {
                zbroj += i;
            }

            Console.WriteLine("Zbroj svih brojeva od 1 do {0} je {1}", b, zbroj);




            int najmanjiBroj = int.MaxValue;
            int uneseniBroj;


            Console.WriteLine("Unesite cijele brojeve. Unesite -1 za kraj.");

            for (; ; )
            {
                Console.Write("Unesite broj: ");
                uneseniBroj = int.Parse(Console.ReadLine());

                if (uneseniBroj == -1)
                {
                    break;
                }

                if (uneseniBroj < najmanjiBroj)
                {
                    najmanjiBroj = uneseniBroj;
                }
            }

            if (najmanjiBroj != int.MaxValue)
            {
                Console.WriteLine("Najmanji uneseni broj je {0}", najmanjiBroj);
            }
            else
            {
                Console.WriteLine("Niste unijeli niti jedan broj.");

            }

            Console.Write("Unesite cijeli broj: ");
            int broj = int.Parse(Console.ReadLine());
            bool prim = true;

            for (int i = 2; i < broj; i++)
            {
                if (broj % i == 0)
                {
                    prim = false;
                    break;
                }
            }

            if (prim && broj != 1)
            {
                Console.WriteLine("{0} je prim broj.", broj);
            }
            else
            {
                Console.WriteLine("{0} nije prim broj.", broj);




            }

        }
    }
}

    

    

