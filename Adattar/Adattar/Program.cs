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

        public static void Main(string[] args)
        {
            VeletlenEgeszSzamok vesz = new VeletlenEgeszSzamok();
            szamok = vesz.getSzamok();
            Console.WriteLine($"Szaámok átlaga: {atlag()}");
        }
    }
}
