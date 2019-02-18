using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListakbanLevoAdatokKezeleseOOPalapokon
{
    class Program
    {
        static List<int> szamok;
        static void Main(string[] args)
        {
            VeletlenEgeszSzamok vesz = new VeletlenEgeszSzamok();
            szamok = vesz.getSzamok();
        }
    }
}
