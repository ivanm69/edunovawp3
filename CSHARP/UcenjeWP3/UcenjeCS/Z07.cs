using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class Z07
    {
        public static void Izvedi()
        {
            string ime = Pomocno.UcitajString("Unesi svoje ime");
            int visina = Pomocno.UcitajCijeliBroj("Unesi svoju visinu");
            float tezina = Pomocno.UcitajDecimalniBroj("Unesi svoju tezinu");

            if(visina>170 && visina <190)
            {
                if (tezina > 90.5)
                {
                    Console.WriteLine("Ti," + ime + "si zgodan.");
                }
            }
        }
    }
}
