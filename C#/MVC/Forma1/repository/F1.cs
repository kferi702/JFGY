using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Forma1.myexeption;

namespace Forma1.repository
{
    partial class F1 : IF1, IF1Salary
    {
        List<Team> teams;

        /// <summary>
        /// Forma 1 konstruktor
        /// </summary>
        public F1()
        {
            teams = new List<Team>();
        }

        /// <summary>
        /// Új csapat hozzáadása a Forma1-hez
        /// </summary>
        /// <param name="t">A csapat</param>
        public void add(Team t)
        {
            teams.Add(t);
        }

        /// <summary>
        /// Adott nevű csapat törlése
        /// Kivétel dobás ha a csapat nem létezik
        /// </summary>
        /// <param name="teamName">A csapat neve</param>ű
        /// <exception cref="F1Exception">Az adott nevű csapat nem létezik.</exception>
        public void delete(string teamName)
        {
            int index = 0;
            foreach (Team t in teams)
            {
                if (t.getName() == teamName)
                {
                    teams.RemoveAt(index);
                    return;
                }
                index++;
            }
            throw new F1Exception($"{teamName} nevű csapat nem létezik, nem lehet törölni!");
        }

        /// <summary>
        /// Adott nevű csapat nevének módosítása
        /// Kivétel dobás, ha a csapat nem létezik
        /// </summary>
        /// <param name="teamName">A csapat régi neve</param>
        /// <param name="newTeamName">A csapat új neve</param>
        /// <exception cref="F1Exception">Az adott nevű csapat nem létezik.</exception>
        public void update(string teamName, string newTeamName)
        {
            foreach (Team t in teams)
            {
                if (t.getName() == teamName)
                {
                    t.update(newTeamName);
                    return;
                }
            }
            throw new F1Exception($"{teamName} nevű csapat nem létezik, nem lehet módosítani!");
        }

        /// <summary>
        /// A csapatok listája
        /// </summary>
        /// <returns>Az csapatok listája</returns>
        public List<Team> getTeams()
        {
            return teams;
        }

        /// <summary>
        /// Van-e adott nevű csapat
        /// </summary>
        /// <param name="teamName">A keresett csapat neve</param>
        /// <returns>true ha van és false ha nincs</returns>
        public bool existTeamName(string teamName)
        {
            foreach (Team t in teams)
                if (t.getName() == teamName)
                    return true;
            return false;
        }

        public int getF1Salary()
        {
            int F1salary = 0;

            foreach (Team t in teams)
            {
                F1salary += t.getTeamSalary();
            }
            return F1salary;
        }

        public int getTeamSalary(string teamName)
        {
            foreach (Team t in teams)
            {
                if (t.getName() == teamName)
                {
                    return t.getTeamSalary();
                }
            }
            return 0;
        }
    }
}
