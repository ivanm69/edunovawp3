using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class LjubavniKalkulator
    {
       public static void Izvedi()
        {
            Console.Write("Unesi svoje ime: ");
            string ime1 = Console.ReadLine().ToLower();
            while (!IsValidInput(ime1))
            {
                Console.Write("Pogresan unos. Molim unesite Ime: ");
                ime1 = Console.ReadLine().ToLower();
            }
            Console.Write("Unesi ime svoje simpatije: ");
            string ime2 = Console.ReadLine().ToLower();
            while (!IsValidInput(ime2))
            {
                Console.Write("Pogresan unos. Molim unesite Ime: ");
                ime2 = Console.ReadLine().ToLower();
            }
            string konacno = "";

            foreach (int i in Analiza(StvaranjeMatrice(ime1, ime2)))
            {
                konacno += i;
            }

            Console.WriteLine(ime1 + " i " + ime2 + " se vole " + konacno + "% !");
        }
        static bool IsValidInput(string input)
        {
            return !string.IsNullOrWhiteSpace(input) && !input.Any(char.IsDigit) && !input.Contains(" ");
        }

        static int[] StvaranjeMatrice(string ime1, string ime2)
        {
            string manji = ime1.Length < ime2.Length ? ime1.ToLower() : ime2.ToLower();
            string veci = ime1.Length < ime2.Length ? ime2.ToLower() : ime1.ToLower();

            string ime = manji + veci;

            int[] imena = new int[ime.Length];

            for (int i = 0; i < ime.Length; i++)
            {
                for (int j = 0; j < ime.Length; j++)
                {
                    if (ime[i] == ime[j])
                    {
                        imena[i] += 1;
                    }
                }
            }

            imena = RazdvajanjeDvoznamenkastih(imena);

            int[] matrica = new int[veci.Length];

            for (int i = 0; i < matrica.Length; i++)
            {
                if (manji.ToCharArray().Length > i)
                {
                    matrica[i] += imena[i];
                }

                if (veci.ToCharArray().Length > i)
                {
                    matrica[i] += imena[imena.Length - 1 - i];
                }
            }
            return RazdvajanjeDvoznamenkastih(matrica);
        }

        static int[] Analiza(int[] niz)
        {
            if (niz.Length <= 2)
            {
                return niz;
            }
            else
            {
                if (niz.Length % 2 == 0)
                {
                    int[] zbroj = new int[niz.Length / 2];

                    for (int i = 0; i < niz.Length; i++)
                    {
                        if (i < niz.Length - 1 - i)
                        {
                            zbroj[i] = niz[i] + niz[niz.Length - 1 - i];
                        }
                    }

                    return Analiza(RazdvajanjeDvoznamenkastih(zbroj));
                }
                else
                {
                    int[] zbroj = new int[(niz.Length / 2) + 1];

                    for (int i = 0; i < niz.Length; i++)
                    {
                        if (i < niz.Length - 1 - i)
                        {
                            zbroj[i] = niz[i] + niz[niz.Length - 1 - i];
                        }

                        if (niz[i] == niz[niz.Length - 1 - i])
                        {
                            zbroj[i] = niz[i];
                            break;
                        }
                    }

                    return Analiza(RazdvajanjeDvoznamenkastih(zbroj));
                }
            }
        }

        static int[] RazdvajanjeDvoznamenkastih(int[] niz)
        {
            int brojac = 0;
            foreach (int i in niz)
            {
                if (i >= 10)
                {
                    brojac++;
                }
            }

            int[] pomocnaMatrica = new int[niz.Length + brojac];

            for (int i = 0, j = 0; i < niz.Length; i++)
            {
                if (niz[i] < 10)
                {
                    pomocnaMatrica[j++] = niz[i];
                }
                else
                {
                    pomocnaMatrica[j++] = niz[i] / 10;
                    pomocnaMatrica[j++] = niz[i] % 10;
                }
            }

            return pomocnaMatrica;
        }
    }
}