using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E10Metode
    {

        public static void Izvedi()
        {
            //for (int i = 0; i < 100; i++) { }
            Tip1();
            Tip1();
            Tip2("Ivan");
            Tip2("Maja", "Zimska");
            Tip3();
            Console.WriteLine(Tip3);
            Console.WriteLine(Tip4(2,7));

        }

        private static void Tip1()
        {
            Console.WriteLine("Hello iz metode koja nije primila parametre i ne vraca vrijednost");
        }
        static void Tip2(string ime)
        {
            Console.WriteLine("Dobar dan " + ime);
        }
     
        static void Tip2(string ime , string prezime)
        {
            Console.WriteLine("Dobar dan " + ime + " "+ prezime);
        }


        internal static int Tip3()
        {
            return (7);
        }

        protected static int Tip4(int odBroja, int doBroja) 
        {
            int suma = 0;
            for(int i = 0;i<=doBroja;i+=2)
            {
                suma+= i;
            }
            return suma;
        }



    }
}
