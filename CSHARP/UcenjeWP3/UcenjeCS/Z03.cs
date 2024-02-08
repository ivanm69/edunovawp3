using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class Z03
    {
        public static void Izvedi()
        {
            Console.Write("unesi prvi broj: ");

            int broj = int.Parse(Console.ReadLine());

            Console.WriteLine("unesi drugi broj: ");

            int broj1 = int.Parse(Console.ReadLine());

            Console.WriteLine("unesi treci broj: ");
            
            int broj2= int.Parse(Console.ReadLine());

            if(broj<broj1&broj1<broj&broj<broj2)
            {
                Console.WriteLine(broj);
            }if(broj1<broj&broj1<broj2)
            {
                Console.WriteLine(broj1);
            }else
            {
                Console.WriteLine(broj2);
            }
        }
    }
}
