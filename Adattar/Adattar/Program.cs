using System;
using System.Collections.Generic;
using System.Linq;

namespace ListakbanLevoAdatokKezeleseOOPalapokon
{
    public class Program
    {
        #region 1. feladat

        private static List<int> szamok;

        private static double atlag()
        {
            return szamok.Average();
        }

        private static double pozitivAtlag()
        {
            var eredmeny =
                from int szam in szamok
                where szam > 0
                select szam;

            return eredmeny.Average();
        }

        private static int hanySzamVan()
        {
            return szamok.Count;
        }

        private static double hanySzazalekPozitiv()
        {
            double pozitivDarab = szamok.Count(x => x > 0);
            double osszesSzam = szamok.Count;

            double result = pozitivDarab / osszesSzam;
            return result;
        }

        #endregion

        #region 2. feladat

        private static List<string> mozi;

        private static void kiírMozi()
        {
            foreach (string sor in mozi)
            {
                foreach (char szek in sor)
                {
                    if (szek == 'x')
                    {
                        Console.Write('F');
                    }
                    else
                    {
                        Console.Write('U');
                    }
                }
                Console.WriteLine();
            }
        }

        private static int szabadSzekekSzama(int sor)
        {
            string sorok = mozi.ElementAt(sor);

            int counter = 0;

            foreach (char szek in sorok)
            {
                if (szek == 'o')
                {
                    counter++;
                }
            }

            return counter;
        }

        #endregion

        #region 3. feladat

        private static List<char> kiserlet;

        private static int getKiserletekSzama()
        {
            return kiserlet.Count;
        }

        private static int getFejekSzama()
        {
            return kiserlet.Count(x => x == 'F');
        }

        private static int getIrasokSzama()
        {
            return kiserlet.Count(x => x == 'I');
        }

        private static double getRelativGyakorisagFej()
        {
            int osszesDobas = getKiserletekSzama();
            int fejek = getFejekSzama();
            double result = (double)fejek / osszesDobas * 100;
            return Math.Round(result, 2);
        }

        private static double getRelativGyakorisagIras()
        {
            int osszesDobas = getKiserletekSzama();
            int irasok = getIrasokSzama();
            double result = (double)irasok / osszesDobas * 100;
            return Math.Round(result, 2);
        }

        private static int hanyszorSzerepeltDuplaFF()
        {
            int dbDuplaF = 0;
            int dbF = 0;
            foreach (char dobas in kiserlet)
            {
                if (dobas == 'F')
                {
                    dbF++;
                }

                if ((dobas == 'I') && (dbDuplaF == 2))
                {
                    dbDuplaF++;
                }

                if (dobas == 'I')
                {
                    dbF = 0;
                }
            }

            if (dbF == 2)
            {
                dbDuplaF++;
            }

            return dbDuplaF;
        }

        #endregion

        public static void Main(string[] args)
        {
            #region 1. feladat

            //VeletlenEgeszSzamok veletlenEgeszSzamok = new VeletlenEgeszSzamok();
            //szamok = veletlenEgeszSzamok.getSzamok();

            //Console.WriteLine($"Számok átlaga: {Math.Round(atlag(), 2)}");
            //Console.WriteLine($"Pozitív számok átlaga: {Math.Round(pozitivAtlag(), 2)}");

            //Console.WriteLine($"Ennyi szám van a listában: {hanySzamVan()}");
            //Console.WriteLine($"Ennyi százalék poizítv: {Math.Round(hanySzazalekPozitiv(), 2)} %.");

            #endregion

            #region 2. feladat

            //MoziSzekSorok moziSzekSorok = new MoziSzekSorok();
            //mozi = moziSzekSorok.getAdatok();
            //kiírMozi();
            //Console.WriteLine(szabadSzekekSzama(3));

            #endregion

            #region 3. feladat

            FejVagyIrasKiserlet fejVagyIrasKiserlet = new FejVagyIrasKiserlet();
            kiserlet = fejVagyIrasKiserlet.getAdatok();

            Console.WriteLine(getKiserletekSzama());
            Console.WriteLine(getFejekSzama());
            Console.WriteLine(getIrasokSzama());
            Console.WriteLine(getRelativGyakorisagFej());
            Console.WriteLine(getRelativGyakorisagIras());
            Console.WriteLine(hanyszorSzerepeltDuplaFF());


            #endregion


            Console.ReadKey();
        }
    }
}
