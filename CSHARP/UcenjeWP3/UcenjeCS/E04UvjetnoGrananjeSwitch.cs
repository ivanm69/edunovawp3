using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E04UvjetnoGrananjeSwitch
    {
        public static void Izvedi()
        {
            int i = 2;

            if(i==0)
            {
                Console.WriteLine("Dobar");
            }else if (i == 1)
            {
                Console.WriteLine("Loš");
            }else if (i == 2)
            {
                Console.WriteLine("Zao");
            }


            switch(i)
            {
                case 0:
                    Console.WriteLine("Dobar");
                    break;
                case 1:
                    Console.WriteLine("Loš");
                    break;
                case 2:
                    Console.WriteLine("Zao");
                    break;
                default:
                    Console.WriteLine("Ostalo")
                   ; break;
            
            }
            Console.Write("Unesi ime grada: ");
            string Grad =Console.ReadLine();

            switch (Grad)
            {
                case "Osijek":
                case "Vukovar":
                    Console.WriteLine("Slavonija");
                    break;
                case "Split":
                case "Zadar":
                    Console.WriteLine("Dalmacija");
                    break;

            }


        }
    }
}
