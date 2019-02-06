using System.Collections.Generic;
using Forma1.Repository;

namespace Forma1.Service
{
    public class TeamService
    {
        private TestData testData;
        private F1 f1Repository;

        public TeamService()
        {
            testData = new TestData();
            f1Repository = new F1();
        }

        public void provideTestData()
        {
            testData = new TestData();
            f1Repository = testData.getTestData();
        }

        public List<string> getTeamNamesList()
        {
            return f1Repository.getTeamNamesList();
        }

        public bool isExistingTeamName(string teamName)
        {
            if (f1Repository.isExistingTeamName(teamName))
            {
                return true;
            }

            return false;
        }

        public List<string> getRacerNameFromTheTeam(string teamName)
        {
            return f1Repository.getRacerNameFromTheTeam(teamName);
        }
    }
}
