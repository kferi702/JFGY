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

        public static void Main(string[] args)
        {
            VeletlenEgeszSzamok vesz = new VeletlenEgeszSzamok();
            szamok = vesz.getSzamok();

            Console.WriteLine($"Számok átlaga: {Math.Round(atlag(), 2)}");
            Console.WriteLine($"Pozitív számok átlaga: {Math.Round(pozitivAtlag(), 2)}");

            Console.WriteLine($"Ennyi szám van a listában: {hanySzamVan()}");
            Console.WriteLine($"Ennyi százalék poizítv: {hanySzazalekPozitiv()} %.");

            Console.ReadKey();
        }
    }
}
