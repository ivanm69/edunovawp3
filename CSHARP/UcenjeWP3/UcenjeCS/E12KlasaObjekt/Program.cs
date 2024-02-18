using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UcenjeCS.E12KlasaObjekt.Edunova;

namespace UcenjeCS.E12KlasaObjekt
{
    internal class Program
    {
        public static void Izvedi()
        {
            Osoba osoba = new Osoba();

            osoba.Ime = "Mirko";//Pomocno.UcitajString("Unesi ime osobe");
            osoba.Prezime = "Perić";

            Console.WriteLine(osoba.ImePrezime());

            osoba = new Osoba
            {
                Ime = "Katja", //Pomocno.UcitajString("Unesi ime"),
                Prezime = "Kelić"
            };

            Osoba o = new()
            {
                Ime = "Ivana",
                Prezime = "Jak"

            };

            var direktor = new Osoba() { Prezime = "Kas" };
            var m = new Mjesto() { Naziv = "Osijek" };


            direktor.Mjesto = m;
            Console.WriteLine(direktor.Mjesto?.Naziv);


            var s = new Smjer()
            {
                Sifra = 1,
                Naziv = "Web programiranje",
                Trajanje = 135,
                Cijena = 1234.55m,
                Vaucer = true
            };

            Predavac[] predavaci =
            {
                new(){Ime="Šaki",Prezime="O'Neail"},
                new Predavac(){Ime="Maja",Prezime="Lak"}
            };

            Grupa g=new Grupa();
            g.Sifra = 1;
            g.Naziv = "WP3";
            g.Smjer = s;
            g.Predavac = predavaci[1];

            Console.WriteLine(g.Smjer.Trajanje);

        }
    }
}
