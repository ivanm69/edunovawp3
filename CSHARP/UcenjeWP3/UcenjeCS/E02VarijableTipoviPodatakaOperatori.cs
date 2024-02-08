using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E02VarijableTipoviPodatakaOperatori
    {
        public static void Izvedi()
        {
            int cijelibroj;

            cijelibroj = 7;

            Console.WriteLine(cijelibroj);


            Console.WriteLine("unesi cijeli broj");
            int broj = int.Parse(Console.ReadLine());

            Console.WriteLine (cijelibroj + broj);

            string v1 = "osijek";
            var v2 = "edunova";

            Console.WriteLine (v1 + v2);

            float db = 3.14f;

            double vdb = 0.4827348236474623745234234;

            Console.WriteLine("uneso visinu u metrima");
            float visina = float.Parse(Console.ReadLine());


            Console.WriteLine(visina);

            int najvecibroj = int.MaxValue;

            Console.WriteLine(najvecibroj + 1);



            int i = 2, j = 3;

            Console.WriteLine(i - j);
            Console.WriteLine(i * j);
            Console.WriteLine(i / (float)j);



            Console.WriteLine("unesi dvoznamenkasti broj: ");

            int dbroj = int.Parse(Console.ReadLine());


            Console.WriteLine(dbroj / 10);


            Console.WriteLine(dbroj % 10);


            bool uvijet = true;


            int k = 2, l = 2;

            Console.WriteLine(k==l);


            Console.WriteLine(k!=l);

            Console.WriteLine("{0} {1} {2} {3}",k>l,k>=l,k<l,k<=l);




            int v = 1;

            Console.WriteLine(v);


            v = v + 1;

            Console.WriteLine(v);


            v += 1;

            Console.WriteLine(v);


            v = 1;

            Console.WriteLine(v++);

            Console.WriteLine(++v);





            int x = 2, y = 1;
            x = x + ++y;
            y = --x;
            Console.WriteLine(x+y);








        }
    }
}
