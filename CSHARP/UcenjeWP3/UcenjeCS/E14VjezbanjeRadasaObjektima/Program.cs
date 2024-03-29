﻿using System;
using System.Buffers;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.E14VjezbanjeRadasaObjektima
{
    internal class Program
    {
        private List<Osoba> Osobe;
        /// <summary>
        /// Kreirati aplikaciju koja unosi,pregledava,mijenja i brise osobe
        /// </summary>

        public Program() 
        {
            Osobe= new List<Osoba>();
            Testpodaci();
            PozdravnaPoruka();
            Izbornik();
        }

        private void Testpodaci()
        {
            Osobe.Add(new() { Ime = "Ana", Prezime = "Kat", Dob = 12 });
            Osobe.Add(new() { Ime = "Marko", Prezime = "Kekin", Dob = 14 });
            Console.WriteLine("******************************************");
        }

        private void Izbornik()
        {
            Console.WriteLine("1.Pregled osoba");
            Console.WriteLine("2.Unos nove osobe");
            Console.WriteLine("3.Promjena osobe");
            Console.WriteLine("4.Brisanje osobe");
            Console.WriteLine("5.Izlaz iz programa");
            OdaberiOpciju();
        }

        private void OdaberiOpciju()
        {
           switch(Pomocno.UcitajCijeliBroj("odaberi opciju ")) 
            {
                case 1:
                    PrikaziOsobe(true);
                    
                    break;
                case 2:
                    UnosNoveOsobe();
                    
                    break;
                case 3:
                    PromjenaOsobe();
                    
                    break;
                case 4:

                    BrisanjeOsobe();
                   
                    break;

                case 5:
                    Console.WriteLine("Progrma je zavrsio,Doviđenja");
                    return;
                default:
                    Console.WriteLine("Nije dobra opcija");
                    Console.WriteLine("*****************");
                    Izbornik();
                    break;
            }
            Izbornik();
        }

        private void BrisanjeOsobe()
        {   
            if(Osobe.Count == 0)
            {
                Console.WriteLine("Nema osoba za brisanje");
                return;
            }
            Console.WriteLine("**********************");
            Console.WriteLine("****Brisanje osobe****");
            PrikaziOsobe();
            int izbor = Pomocno.UcitajCijeliBroj("Izaberi broj osobe (0 odustani)",0,Osobe.Count);
            if (izbor == 0)
            {
                return;
            }
            
            Osobe.RemoveAt(izbor - 1);
            
        }

        private void PromjenaOsobe()
        {
            if (Osobe.Count == 0)
            {
                Console.WriteLine("Nema osoba za mijenjat");
                return;
            }
            PrikaziOsobe();
            int izbor = Pomocno.UcitajCijeliBroj("Izaberi broj osobe (0 odustani)",0,Osobe.Count);
            if(izbor == 0) 
            {
                return;
            }
            var o = Osobe[izbor - 1];
            o.Ime = Pomocno.UcitajString("Ucitaj ime ["+o.Ime +"]");
            o.Prezime = Pomocno.UcitajString("Ucitaj prezime");
            o.Dob = Pomocno.UcitajCijeliBroj("Ucitaj dob");
        }

        private void UnosNoveOsobe()
        {
            Osobe.Add(new()
            {
                Ime=Pomocno.UcitajString("Unesi ime osobe"),
                Prezime=Pomocno.UcitajString("Unesi prezime osobe"),
                Dob = Pomocno.UcitajCijeliBroj("Unesi dob osobe")
            });
        }

        private void PrikaziOsobe(bool PrikaziNaslov=false)
        {
            if(PrikaziNaslov ) 
            {
             Console.WriteLine("***********************");
             Console.WriteLine("***Osobe u Sustavu*****");
             Console.WriteLine("***********************");
            }
            if(Osobe.Count == 0) 
            {
                Console.WriteLine("Nema ni jedne osobe u sustavu");
                Console.WriteLine("*****************************");
                return;
            }
            
            
            int i = 1;
            foreach (var o in Osobe) 
            {
                Console.WriteLine(i++ +". "+o);
            }
        }

        private void PozdravnaPoruka()
        {
            Console.WriteLine("Osobe program v1");
            Console.WriteLine("****************");

        }
    }
}
