using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forma1.Repository
{
    public interface ITeamManageRacers
    {
        void delete(string name);
        void update(string name);
        void add(Racer r);
    }
}
