using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Forma1.Repository;

namespace Forma1.Repository
{
    public interface IF1
    {
        void add(Team team);
        void update(string name, string newName);
        void delete(string name);

        int getF1Salary();
    }
}
