using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Forma1.Model;

namespace Forma1.Repository
{
    public interface ITeamManageRacers
    {
        void delete(string name);
        void update(string name, Racer newRacer);
        void add(Racer r);
    }
}
