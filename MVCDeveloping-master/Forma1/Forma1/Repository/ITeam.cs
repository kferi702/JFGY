using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forma1.Repository
{
    public interface ITeam
    {
        void Update(string newName);
        void Delete();

        int getTeamSalary();
    }
}
