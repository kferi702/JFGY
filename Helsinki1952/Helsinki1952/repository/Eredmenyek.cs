using System.Collections.Generic;
using Helsinki1952.model;
using System.IO;
using System;

namespace Helsinki1952.repository
{
    public class Eredmenyek
    {
        private List<OlimpiaiHelyezes> eredmenyek;

        public Eredmenyek()
        {
            eredmenyek = new List<OlimpiaiHelyezes>();
        }

        public void beolvas()
        {
            StreamReader sr = new StreamReader("helsinki.txt");

            while (!sr.EndOfStream)
            {
                string sor = sr.ReadLine();

                OlimpiaiHelyezes o = new OlimpiaiHelyezes(sor);
                eredmenyek.Add(o);
            }
        }

        public string pontSzerzoHelyekSzama()
        {
            return eredmenyek.Count.ToString();
        }
    }
}
