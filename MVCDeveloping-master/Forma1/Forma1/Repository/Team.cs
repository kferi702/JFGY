using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forma1.Repository
{
    public partial class Team : ITeam
    {
        private string name;
        private List<Racer> racers;

        public Team(string name)
        {
            this.name = name;
            racers = new List<Racer>();
        }

        /// <summary>
        /// Módosítja a csapat nevét
        /// </summary>
        /// <param name="newName">Új csapat neve</param>
        public void update(string newName)
        {
            name = newName;
        }

        /// <summary>
        /// Törlés funkció
        /// A listából minden versenyzőt törlünk
        /// </summary>
        public void delete()
        {
            racers.Clear();
        }

        /// <summary>
        /// A csapat versenyzőinek összbére
        /// </summary>
        /// <returns></returns>
        public int getTeamSalary()
        {
            // Foreach

            int sum = 0;
            foreach (Racer r in racers)
            {
                sum += r.getSalary();
            }
            return sum;

            // Lambda-kifejezés
            //return racers.Sum(x => x.getSalary());

            // LINQ
            //var result = from racer in racers
            //             select racer.getSalary();

            //return result.Sum();
        }
    }
}
