using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class Z02
    {

        public static void Izvedi()
        {
            Console.Write("unesi prvi broj: ");

            int broj = int.Parse(Console.ReadLine());
            
            Console.WriteLine("unesi drugi broj: ");
           
            int broj1= int.Parse(Console.ReadLine());
            
            if (broj>broj1)
            {
                Console.WriteLine(broj);

            }
            else
            {
                Console.WriteLine(broj1);
            }
            


        }
    }
}
