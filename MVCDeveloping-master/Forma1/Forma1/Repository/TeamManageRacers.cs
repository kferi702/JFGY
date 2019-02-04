using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forma1.Repository
{
    public partial class Team : ITeamManageRacers
    {
        /// <summary>
        /// Új versenyző felvitele
        /// </summary>
        /// <param name="r">Új versenyző</param>
        /// <exception cref="Exception">Két ugyanolyan versenyző nem adható a listához</exception>
        public void add(Racer r)
        {
            racers.Add(r);
        }

        /// <summary>
        /// Töröl meglévő versenyzőt
        /// </summary>
        /// <param name="name">Törlendő versenyző neve</param>
        /// <exception cref="Exception">A versenyző a csapatnak nem tagja, nem lehet törölni</exception>
        public void delete(string name)
        {
            int index = 0;
            foreach (Racer r in racers)
            {
                if (r.getName() == name)
                {
                    racers.RemoveAt(index);
                    return;
                }
                index++;
            }
            throw new TeamException($"{name} a csapatnak nem tagja, nem lehet törölni!");

            /*if (racers.Exists(x => x.getName() == name))
            {
                racers.RemoveAll(x => x.getName() == name);
            }
            else
            {
                throw new TeamException($"{ name } a csapatnak nem tagja, nem lehet törölni!");
            }*/
        }

        /// <summary>
        /// Módosít meglévő versenyzőt
        /// </summary>
        /// <param name="name">Módosítandó versenyző</param>
        /// <exception cref="Exception">A módosítandó versenyzőt nem találjuk, nem lehet módosítani</exception>
        public void update(string name)
        {

        }
    }
}
