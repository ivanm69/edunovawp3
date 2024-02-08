using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E05Nizovi
    {

        public static void Izvedi()
        {
            int[] Temperature = new int[6];

            Temperature[0] = 1;
            Temperature[Temperature.Length-1] = 2;

            Console.WriteLine(Temperature);
            Console.WriteLine(string.Join(",",Temperature));


            string[]gradovi = new string[3];
            gradovi[0] = "Osijek";
            gradovi[1] = "Zagreb";
            gradovi[2] = "Donji Miholjac";

            Console.WriteLine(string.Join(" ",gradovi));

            int[] brojevi = { 2, 3, 3, 4, 7, 5, 5, 4 };

            Console.WriteLine(brojevi[4]);

            Console.WriteLine(brojevi[0]);

            Console.WriteLine(brojevi[brojevi.Length-1]);


            int[,] tablica =
            {
                {1,2,3 },
                {4,5,6 },
                {7,8,9 },
            };

            Console.WriteLine(tablica[1,2]);

            int[,,] kocka = new int[10, 10, 10];

            int[,,,,,] zvjezdaneStaze;

            string grad = "Osijek";
            Console.WriteLine(grad[3]);

            char znak='j';
            Console.WriteLine(znak);
            Console.WriteLine((int)znak);

            int[] niz = { 1, 2, 3, 4, 5 };

            Console.WriteLine(niz[0]);
            Console.WriteLine(niz[1]);
            Console.WriteLine(niz[2]);
            Console.WriteLine(niz[3]);
            Console.WriteLine(niz[4]);


            int i = 0;
            i = i + 1;
            i += 1;
            i++;



            


        }
    }
}
