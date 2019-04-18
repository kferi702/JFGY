using Helsinki1952.model;
using System;
using Helsinki1952.repository;

namespace Helsinki1952
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Eredmenyek e = new Eredmenyek();
            e.beolvas();

            Console.WriteLine("3. feladat: ");
            Console.Write("Pontszerző helyek száma: ");
            Console.WriteLine(e.pontSzerzoHelyekSzama());

            Console.ReadKey();
        }
    }
}
