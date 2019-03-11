using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOPObjectInList___PekingiTorna.repository;
using OOPObjectInList___PekingiTorna.model;

namespace OOPObjectInList___PekingiTorna
{
    public class Program
    {
        static void Main(string[] args)
        {
            PekingiTornaszTornaAdatokBeolvasasaFajlbol pt = new PekingiTornaszTornaAdatokBeolvasasaFajlbol();
            pt.beolvas();

            Console.WriteLine("9. feladat");
            Console.WriteLine($"Legeslegjobb eredmény: {pt.getLegeslegjobbEredmeny()}");

            Console.WriteLine("10. feladat");
            pt.kiirFranciakat();

            Console.ReadKey();
        }
    }
}
