using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPObjectInList___PekingiTorna.model
{
    class Versenyzo : Tornasz
    {
        public int Rajtszam { set; get; }
        public string Nev { set; get; }
        public string Orszag { set; get; }
        public string Foldresz { set; get; }

        public Versenyzo(int rajtszam, string nev, string orszag, string foldresz, double talaj, double lolenges, double gyuru, double nyujto, double korlat, double ugras)
            : base(talaj, lolenges, gyuru, nyujto, korlat, ugras)
        {
            Rajtszam = rajtszam;
            Nev = nev;
            Orszag = orszag;
            Foldresz = foldresz;
        }

        public Versenyzo(string sor)
        {
            string[] adat = sor.Split(';');

            Rajtszam = Convert.ToInt32(adat[0]);
            Nev = adat[1];
            Orszag = adat[2];
            Foldresz = adat[3];
            Talaj = Convert.ToDouble(adat[4]);
            Lolenges = Convert.ToDouble(adat[5]);
            Gyuru = Convert.ToDouble(adat[6]);
            Nyujto = Convert.ToDouble(adat[7]);
            Korlat = Convert.ToDouble(adat[8]);
            Ugras = Convert.ToDouble(adat[9]);
        }

        public override string ToString()
        {
            return $"{Rajtszam} {Nev} {Orszag} {Foldresz} {Talaj} {Lolenges} {Gyuru} {Nyujto} {Korlat} {Ugras}";
        }
    }
}
