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

                int counter = 1;
                int row = redova - 1;
                int col = stupci - 1;
                int layer = 0;

                while (counter <= redova * stupci)
                {
                   
                    for (int i = col; i >= layer; i--)
                    {
                        matrica[row][i] = counter++;
                    }

                   
                    for (int i = row - 1; i >= layer; i--)
                    {
                        matrica[i][layer] = counter++;
                    }

                   
                    for (int i = layer + 1; i <= col; i++)
                    {
                        matrica[layer][i] = counter++;
                    }

                    
                    for (int i = layer + 1; i < row; i++)
                    {
                        matrica[i][col] = counter++;
                    }

                    layer++;
                    row--;
                    col--;
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
