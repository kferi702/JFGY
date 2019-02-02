using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forma1.Repository
{
    interface ITeamManageRacers
    {
        void deleteRacer(string name, Racer newRacer);
        void updateRacer(string name);
        void createRacer(Racer r);
    }
}
