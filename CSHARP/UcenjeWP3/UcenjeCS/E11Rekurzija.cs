﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E11Rekurzija
    {
        public  static void Izvedi()
        {
            int suma =0;
            for (int i = 0; i <=100; i++) 
            {
                suma += i;
            }
            Console.WriteLine(suma);
            Console.WriteLine(zbroji(100));
        }
        private static int zbroji(int broj) 
        {
            if(broj == 1) 
            {
            return 1;
            }

            return broj + zbroji(broj - 1);
        }
    }
}
