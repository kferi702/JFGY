using System.Collections.Generic;
using Forma1.Service;

namespace Forma1.Controller
{
    public class Forma1Controller
    {
        private TeamService service;

        public Forma1Controller()
        {
            service = new TeamService();
        }

        public void initializeTestData()
        {
            service.provideTestData();
        }

        public List<string> getTeamNamesList()
        {
            return service.getTeamNamesList();
        }

        public List<string> getTeamRacersName(string teamName)
        {
            if (service.isExistingTeamName(teamName))
            {
                return service.getRacerNameFromTheTeam(teamName);
            }

            return null;
        }
    }
}
