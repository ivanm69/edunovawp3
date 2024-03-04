using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace UcenjeCS
{
    internal class CiklicnaMatrica
    {
        public static void Izvedi()
        {
            bool dev = true;
            Console.WriteLine("Unesi broj redova: ");
            int red = dev ? 5 : int.Parse(Console.ReadLine());
            Console.WriteLine("Unesi broj stupaca: ");
            int stupac = dev ? 5 : int.Parse(Console.ReadLine());

            int[,] matrica = new int[red, stupac];

            int b = 1;
            int maxB = red * stupac;

            int redova = red - 1;
            int stupci = stupac - 1;
            int a = 0;
            int c = 0;

            while (b <= maxB)
            {
                for (int i = stupci; i >= c; i--)
                {
                    matrica[redova, i] = b++;
                }

                if (b > maxB) { break; }

                redova--;


                for (int i = redova; i >= a; i--)
                {
                    matrica[i, c] = b++;
                }

                if (b > maxB) { break; }

                c++;


                for (int i = c; i <= stupci; i++)
                {
                    matrica[a, i] = b++;
                }

                if (b > maxB) { break; }

                a++;


                for (int i = a; i <= redova; i++)
                {
                    matrica[i, stupci] = b++;
                }
                stupci--;
            }

            for (int i = 0; i < red; i++)
            {
                for (int j = 0; j < stupac; j++)
                {
                    Console.Write(matrica[i, j] + "\t");

                }
                Console.WriteLine();
                Console.WriteLine(new string('*', stupac * 10));



            }
        }
    }
}