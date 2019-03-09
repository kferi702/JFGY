using System.Collections.Generic;
using System;
using OOPObjectInList___PekingiTorna.repository;
using OOPObjectInList___PekingiTorna.model;

namespace OOPObjectInList___PekingiTorna
{
    public class Program
    {
        private static List<Versenyzo> versenyzok;

        private static void kiirVersenyzokSzama()
        {
            Console.WriteLine("Összesen " + versenyzok.Count + " versenyző indult a versenyen!");
        }

        private static string meghatarozKorlatonNyeroTornaszNevet()
        {
            double max = 0;
            string nev = string.Empty;

            foreach (Versenyzo v in versenyzok)
            {
                if (v.Korlat > max)
                {
                    max = v.Korlat;
                    nev = v.Nev;
                }
            }

            return nev;
        }

        private static double meghatarozGyuruEredmenyt(int rajtszam)
        {
            foreach (Versenyzo v in versenyzok)
            {
                if (v.Rajtszam == rajtszam)
                {
                    return v.Gyuru;
                }
            }
            return -1;
        }

        public static void Main(string[] args)
        {
            PekingiTornaszTorna ptt = new PekingiTornaszTorna();
            versenyzok = ptt.getVersenyzok();

            // 1. feladat
            kiirVersenyzokSzama();

            // 2. feladat
            Console.WriteLine("Korláton " + meghatarozKorlatonNyeroTornaszNevet() + " szerezte meg az aranyérmet!");

            // 3. feladat
            Console.Write("Kérem a versenyző rajtszámát: ");
            int rajtszam = Convert.ToInt32(Console.ReadLine());

            double gyuruEredmeny = meghatarozGyuruEredmenyt(rajtszam);

            if (gyuruEredmeny < 0)
            {
                Console.WriteLine("Nincs ilyen versenyző!");
            }
            else
            {
                Console.WriteLine("A " + rajtszam + " rajtszámú versenyző gyűrűn elért eredménye: " + gyuruEredmeny);
            }

            Console.ReadKey();
        }
    }
}
