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

        public void add(Team team)
        {
            throw new NotImplementedException();
        }

        public void delete(string name)
        {
            throw new NotImplementedException();
        }

        public int getF1Salary()
        {
            throw new NotImplementedException();
        }

        public void update(string name, string newName)
        {
            throw new NotImplementedException();
        }
    }
}
