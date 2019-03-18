using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helsinki1952.model
{
    public class OlimpiaiHelyezes
    {
        public int Helyezes { get; set; }
        public int Letszam { get; set; }
        public string Sportag { get; set; }
        public string Versenyszam { get; set; }

        public OlimpiaiHelyezes(int helyezes, int letszam, string sportag, string versenyszam)
        {
            Helyezes = helyezes;
            Letszam = letszam;
            Sportag = sportag;
            Versenyszam = versenyszam;
        }

        public OlimpiaiHelyezes(string sor)
        {
            string[] adat = sor.Split(' ');

            Helyezes = Convert.ToInt32(adat[0]);
            Letszam = Convert.ToInt32(adat[1]);
            Sportag = adat[2];
            Versenyszam = adat[3];
        }
    }
}
