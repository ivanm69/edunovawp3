using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class Z01
    {
        public static void Izvedi()
        {

            
            Console.Write("unesi cijeli broj: ");
            
            int broj = int.Parse(Console.ReadLine());

            if (broj %2==0)
            {
                Console.WriteLine("Super");

            }
            else
            {
                Console.WriteLine("Ok");
            }




        }

    }
}
