using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forma1.Repository
{
    interface ITeamManageRacers
    {
        void deleteRacer(Racer r);
        void updateRacer(Racer r);
        void createRacer(Racer r);
    }
}
