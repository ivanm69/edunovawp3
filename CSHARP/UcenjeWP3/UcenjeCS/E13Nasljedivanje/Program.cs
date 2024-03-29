﻿using System;
using System.Buffers;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.E13Nasljedivanje
{
    internal class Program

    {
        public Program() 
        {

            Console.WriteLine("Nalazim se u konstuktoru programa u namespace E13..");

            Primjer1();
            Primjer2();
            Primjer3();
            Primjer4();
            Primjer5();
            Primjer6();
            Primjer7();
        }

        private void Primjer7()
        {
            Polaznik[] polaznici = new Polaznik[3];

            polaznici[0]= new Polaznik("Ivana","Maleš","1/24");
            polaznici[1] = new Polaznik("Marko", "Kas", "2/24");
            polaznici[2] = new Polaznik();

            Console.WriteLine(polaznici[1].Prezime);

        }

        private void Primjer6()
        {
            // Baza b = new Baza();
            
            Baza b = new Baza("edunovawp3");

        }

        private void Primjer5()
        {

            string s = "Osijek";

            var grad = new string("Osijek");

            Console.WriteLine(s.GetHashCode());
            s = s + "je super";
            Console.WriteLine(s.GetHashCode());


            StringBuilder sb = new StringBuilder();

            Console.WriteLine(sb.GetHashCode());

            sb.Append("Osijek");
            Console.WriteLine(sb.GetHashCode());
            sb.Append(" je super");
            Console.WriteLine(sb.GetHashCode());
            Console.WriteLine(sb);



        }




        private void Primjer4()
        {
           
            Polaznik p1= new() {Ime="Iva"};
            Polaznik p2= new() {Ime="Iva"};

            Console.WriteLine(p1==p2);

            Console.WriteLine(p1.GetHashCode());
            Console.WriteLine(p2.GetHashCode());
        }



        private void Primjer3()
        {
            var p = new Predavac()
            {
                Ime = "Karlo",
                Prezime = "Sat",
                Iban = "HR22"
            };
            Console.WriteLine(p);
            Console.WriteLine(new Polaznik(){ Ime="Ranko",Prezime = "Ekul",BrojUgovora="1"});
        }



        private void Primjer2()
        {
            
            OsobaImpl osoba = new OsobaImpl();
            osoba.Ime = "Luka";

            osoba.GetType();
        }

        private void Primjer1()
        {
            Predavac p = new Predavac();
            p.Ime = "Pero";
            p.Iban = "HR445";

            Polaznik polaznik = new Polaznik();
            polaznik.Ime = "Kata";
            polaznik.BrojUgovora = "12/2024";

            Console.WriteLine(p.Iban+" "+polaznik.BrojUgovora);
        }
    }
}
