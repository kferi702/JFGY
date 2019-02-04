using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                }
                index++;
            }
        }

        public void update(string name, string newName)
        {
            foreach (Team t in teams)
            {
                if (t.getName() == name)
                {
                    t.update(newName);
                }
            }
        }

        public int getF1Salary()
        {
            throw new NotImplementedException();
        }
    }
}
