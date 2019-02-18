using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foreach_LINQ_Lambda
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> szamok = new List<int>() { 15, 14, 11, -20, 19, 17, 16, 17, 13, -10 };

            int szamokSzama = szamok.Count;
            Console.WriteLine("Számok száma: " + szamokSzama);

            int szamokSzama0 = szamok.Count(x => x < 0);
            Console.WriteLine("Számok száma <0:" + szamokSzama0);

            bool van15 = szamok.Contains(15);
            Console.WriteLine("Van 15: " + van15);

            bool van9 = szamok.Contains(9);
            Console.WriteLine("Van 9:" + van9);

            bool vanNagyobb15 = szamok.Exists(x => x > 15);
            Console.WriteLine("Van >15:" + vanNagyobb15);

            int elsoNagyobb15 = szamok.Find(x => x > 15);
            Console.WriteLine("Első nagyobb >15:" + elsoNagyobb15);

            int indexElsoNagyobb15 = szamok.FindIndex(x => x > 15);
            Console.WriteLine("Első nagyobb >15 indexe: " + indexElsoNagyobb15);

            int utolsoNagyobb15 = szamok.FindLast(x => x > 15);
            Console.WriteLine("Utolsó nagyobb <15: " + utolsoNagyobb15);

            int indexUtolsoNagyobb15 = szamok.FindLastIndex(x => x > 15);
            Console.WriteLine("Utolsó nagyobb >15 indexe: " + indexUtolsoNagyobb15);
        }
    }
}
