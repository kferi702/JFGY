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

        private static List<Versenyzo> meghatarozLolengesbenNemDontosoket()
        {
            List<Versenyzo> lolengesbenNemDontosok = new List<Versenyzo>();

            foreach (Versenyzo v in versenyzok)
            {
                if (v.Lolenges < 14.5)
                {
                    lolengesbenNemDontosok.Add(v);
                }
            }

            return lolengesbenNemDontosok;
        }

        private static SortedSet<string> meghatarozFoldreszeket()
        {
            SortedSet<string> foldreszek = new SortedSet<string>();

            foreach (Versenyzo v in versenyzok)
            {
                foldreszek.Add(v.Foldresz);
            }

            return foldreszek;
        }

        private static void kiirFoldreszenkentVersenyzokSzamot()
        {
            Dictionary<string, int> db = new Dictionary<string, int>();

            foreach (Versenyzo v in versenyzok)
            {
                if (db.ContainsKey(v.Foldresz))
                {
                    db[v.Foldresz]++;
                }
                else
                {
                    db.Add(v.Foldresz, 1);
                }
            }

            foreach (KeyValuePair<string, int> foldreszDarab in db)
            {
                Console.WriteLine(foldreszDarab.Key + " " + foldreszDarab.Value);
            }
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

            // 4. feladat
            Console.WriteLine("Lólengésben nem jutottak döntőbe:");
            List<Versenyzo> lolengesbenNemDontosok = meghatarozLolengesbenNemDontosoket();

            foreach (Versenyzo v in lolengesbenNemDontosok)
            {
                Console.WriteLine(v.Nev);
            }

            // 5. feladat
            Console.WriteLine("A versenyen a kövezkező földrészekről volt versenyző: ");

            SortedSet<string> foldreszek = meghatarozFoldreszeket();

            foreach (string foldresz in foldreszek)
            {
                Console.WriteLine(foldresz);
            }

            // 6. feladat
            kiirFoldreszenkentVersenyzokSzamot();

            Console.ReadKey();
        }
    }
}
