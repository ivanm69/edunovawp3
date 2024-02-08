using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E03UvjetnoGrananjeIF
    {

        public static void Izvedi()
        {
            
            int i = 7;

            bool uvjet = i == 7;

            if (uvjet)
            {
                Console.WriteLine("1. Ušao sam u if granu");
            }

           if(uvjet)
                Console.WriteLine("2.Bez {}");
                Console.WriteLine("3.Ovo ce se uvijek ispisati");


            if (i > 0)
            {
                Console.WriteLine("4. i je veće od 0");
            }


            var j = 5;

            i = 6;
            if(i==7 & j==5)
            {
                Console.WriteLine("5.Zadovoljena su oba uvjeta");
            }


            if(i==7 && j == 5)
            {
                Console.WriteLine("6. Oba uvjeta su zadovoljena");
            }
            else
            {
                Console.WriteLine("7. Jedan od uvjeta nije zadovoljen");
            }


            if (i == 7 || j == 5)
            {
                Console.WriteLine("8. Jedan ili oba  uvjeta su zadovoljena");
            }
            else
            {
                Console.WriteLine("9.Niti jedan uvjet nije zadovoljen");
            }



            if((i>0 && i<10)||!(i<5))
            {
                Console.WriteLine("10. Zadovoljen kompliciran uvjet");
            }


            i = 5;
            if (i == 1)
            {
                Console.WriteLine("11. i je jedan");
            }else if (i == 2)
            {
                Console.WriteLine("12. i je 2");
            }else
            {
                Console.WriteLine("13. i nije 1 ili 2");
            }




            if (i == 3)
            {
                Console.WriteLine("14. i je 3");
            }
            else
            {
                Console.WriteLine("15. i nije 3");
            }

            Console.WriteLine(i==3 ? "14. i je 3" : "15. i nije 3");



            if(i== 4)
            {
                if (j < 9)
                {
                    Console.WriteLine("16. ugnježđeni if");
                }
            }





        }

    }
}
