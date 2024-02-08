using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E09ForEach
    {
        public static void Izvedi()
        {

            string grad = "Osijek";

            for(int i = 0; i < grad.Length; i++) 
            {

                Console.WriteLine(grad[i]);
            }


            foreach(var c in grad)
            {
                Console.WriteLine(c);
            }

            for (int i = grad.Length - 1; i >= 0; i--) 
            {
                Console.Write(grad[i]);
            }



            int[] niz = new int[] { 2, 3, 3, 4, 5, 6, 76, 78 };
            foreach(var c in niz)
            {
                Console.Write(c);
            }







        }
    }
}
