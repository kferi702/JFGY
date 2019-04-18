using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPObjectInList___PekingiTorna.model
{
    class Tornasz
    {
        public double Talaj { get; set; }
        public double Lolenges { get; set; }
        public double Gyuru { get; set; }
        public double Nyujto { get; set; }
        public double Korlat { get; set; }
        public double Ugras { get; set; }

        public Tornasz(double talaj, double lolenges, double gyuru, double nyujto, double korlat, double ugras)
        {
            Talaj = talaj;
            Lolenges = lolenges;
            Gyuru = gyuru;
            Nyujto = nyujto;
            Korlat = korlat;
            Ugras = ugras;
        }
    }
}
