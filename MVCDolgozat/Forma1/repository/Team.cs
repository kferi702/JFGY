using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;
using Forma1.myexeption;
using Forma1.validation;

namespace Forma1.repository
{
    partial class Team : ITeam
    {
        private string name;
        private List<Racer> racers;

        /// <summary>
        /// Konstruktor
        /// </summary>
        /// <param name="name">Az új csapat neve</param>
        public Team(string name)
        {
            try
            {
                NameValidator validator = new NameValidator(name);
                validator.validation();
                this.name = name;
            }
            catch (NameNotValidNameIsEmptyException e)
            {
                Debug.WriteLine(e.Message);
                throw new TeamException(e.Message);
            }
            catch (NameNotValidFirstLetterProblemException e)
            {
                Debug.WriteLine(e.Message);
                throw new TeamException(e.Message);
            }

            racers = new List<Racer>();
        }
        /// <summary>
        /// getter
        /// </summary>
        /// <returns>A csapat neve</returns>
        public string getName()
        {
            return name;
        }
        /// <summary>
        /// Csapat törlésének előkészítése
        /// A listából minden versenyzőt törlünk
        /// </summary>
        public void deleteAllRacersInTeam()
        {
            racers.Clear();
        }
        /// <summary>
        /// Módosítja a csapat nevét
        /// </summary>
        /// <param name="newName">Csapat új neve</param>
        public void update(string newName)
        {

        }
        /// <summary>
        /// A csapat versenyzőinek listáját adja vissza
        /// </summary>
        /// <returns>A versenyzők neveinek listája</returns>
        public List<Racer> getRacers()
        {
            return null;
        }
    }
}
