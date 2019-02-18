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

        public static void Main(string[] args)
        {
            VeletlenEgeszSzamok vesz = new VeletlenEgeszSzamok();
            szamok = vesz.getSzamok();
            Console.WriteLine($"Számok átlaga: {Math.Round(atlag(), 2)}");
            Console.WriteLine($"Pozitív számok átlaga: {Math.Round(pozitivAtlag(), 2)}");

            Console.ReadKey();
        }
    }
}
