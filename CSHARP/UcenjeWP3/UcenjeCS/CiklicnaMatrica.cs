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
                bool dev = false;
            Console.Write("Unesi broj redova: ");
            int redova = dev ? 5 : int.Parse(Console.ReadLine());
            Console.Write("Unesi broj stupaca: ");
            int stupci = dev ? 5 : int.Parse (Console.ReadLine());

                int[][] matrica = new int[redova][];

                for (int i = 0; i < redova; i++)
                {
                    matrica[i] = new int[stupci];
                }

                int b = 1;
                int red = redova - 1;
                int stupac = stupci - 1;
                int a = 0;

                while (b <= redova * stupci)
                {
                   
                    for (int i = stupac; i >= a; i--)
                    {
                        matrica[red][i] = b++;
                    }

                   
                    for (int i = red - 1; i >= a; i--)
                    {
                        matrica[i][a] = b++;
                    }

                   
                    for (int i = a + 1; i <= stupac; i++)
                    {
                        matrica[a][i] = b++;
                    }

                    
                    for (int i = a + 1; i < red; i++)
                    {
                        matrica[i][stupac] = b++;
                    }

                    a++;
                    red--;
                    stupac--;
                }

               
                for (int i = 0; i < redova; i++)
                {
                    for (int j = 0; j < stupci; j++)
                    {
                        Console.Write(matrica[i][j] + "\t");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
