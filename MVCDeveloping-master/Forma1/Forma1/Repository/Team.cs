using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forma1.Repository
{
    public class Team : ITeam
    {
        private string name;
        private List<Racer> racers;

        public Team(string name)
        {
            this.name = name;
            racers = new List<Racer>();
        }

        public void setName(string name)
        {
            this.name = name;
        }

        public List<Racer> getRacers()
        {
            return racers;
        }

        public override string ToString()
        {
            return $"{name}";
        }

        public void Update(string newName)
        {
            throw new NotImplementedException();
        }

        public void Delete()
        {
            throw new NotImplementedException();
        }

        public int getTeamSalary()
        {
            throw new NotImplementedException();
        }
    }
}
