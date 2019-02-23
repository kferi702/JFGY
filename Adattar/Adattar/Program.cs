using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListakbanLevoAdatokKezeleseOOPalapokon
{
    public class Program
    {
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

        public static void Main(string[] args)
        {
            /*
             * 1. feladat
             */
            
            //VeletlenEgeszSzamok veletlenEgeszSzamok = new VeletlenEgeszSzamok();
            //szamok = veletlenEgeszSzamok.getSzamok();

            //Console.WriteLine($"Számok átlaga: {Math.Round(atlag(), 2)}");
            //Console.WriteLine($"Pozitív számok átlaga: {Math.Round(pozitivAtlag(), 2)}");

            //Console.WriteLine($"Ennyi szám van a listában: {hanySzamVan()}");
            //Console.WriteLine($"Ennyi százalék poizítv: {Math.Round(hanySzazalekPozitiv(), 2)} %.");

            /*
             * 2. feladat
             */

            MoziSzekSorok moziSzekSorok = new MoziSzekSorok();
            mozi = moziSzekSorok.getAdatok();
            kiírMozi();

            Console.ReadKey();
        }
    }
}
