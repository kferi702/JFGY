using OOPObjectInList___PekingiTorna.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace OOPObjectInList___PekingiTorna.repository
{
    public class PekingiTornaszTornaAdatokBeolvasasaFajlbol
    {
        private List<Versenyzo> versenyzok;

        public PekingiTornaszTornaAdatokBeolvasasaFajlbol()
        {
            versenyzok = new List<Versenyzo>();
        }

        public void beolvas()
        {
            StreamReader sr = new StreamReader("torna.csv");

            while (!sr.EndOfStream)
            {

            }
        }
    }
}
