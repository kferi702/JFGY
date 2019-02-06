using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Forma1.MyExceptions;

namespace Forma1.Repository
{
    public class F1 : IF1
    {
        private List<Team> teams;
        private Team team;

        public F1()
        {
            teams = new List<Team>();
        }

        public void add(Team t)
        {
            teams.Add(t);
        }

        public void delete(string name)
        {
            int index = 0;
            foreach (Team t in teams)
            {
                if (t.getName() == name)
                {
                    teams.RemoveAt(index);
                    return;
                }
                index++;
            }
            throw new F1Exception($"{name} nevű csapat nem létezik, nem lehet törölni!");
        }

        internal bool isExistingTeamName(string teamName)
        {
            throw new NotImplementedException();
        }

        public void update(string name, string newName)
        {
            foreach (Team t in teams)
            {
                if (t.getName() == name)
                {
                    t.update(newName);
                    return;
                }
            }
            throw new F1Exception($"{name} nevű csapat nem létezik, nem lehet módosítani!");
        }

        internal List<string> getRacerNameFromTheTeam()
        {
            throw new NotImplementedException();
        }

        public int getF1Salary()
        {
            int sum = 0;
            foreach (Team t in teams)
            {
                sum += t.getTeamSalary();
            }
            return sum;
        }

        public List<string> getTeamNamesList()
        {
            List<string> names = new List<string>();

            foreach (Team t in teams)
            {
                names.Add(t.getName());
            }

            return names;
        }
    }
}
