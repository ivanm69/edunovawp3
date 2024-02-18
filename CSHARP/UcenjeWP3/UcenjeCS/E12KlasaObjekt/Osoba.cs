﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.E12KlasaObjekt
{
    internal class Osoba
    {

        public string? Ime { get; set; }
        public string? Prezime { get; set; }

        public Mjesto? Mjesto { get; set; }


        public string ImePrezime()
        {
            return Ime + " " + Prezime;
        }


    }
}
