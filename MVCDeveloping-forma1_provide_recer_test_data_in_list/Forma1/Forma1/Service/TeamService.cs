using System;
using System.Collections.Generic;
using Forma1.Model;
using Forma1.MyException;
using Forma1.Repository;
using System.Diagnostics;

namespace Forma1.Service
{
    class TeamService
    {
        F1 forma1Repository;

        public TeamService()
        {
            forma1Repository = new F1();
        }
        public void provideTestData()
        {
            TestData td = new TestData();
            forma1Repository = td.getTestData();
        }
        public List<Team> getTeams()
        {
            return forma1Repository.getTeam();
        }

        public List<Racer> getRacers(string teamName)
        {
            return forma1Repository.getRacers(teamName);
        }

        public void createTeam(string teamName)
        {
            try
            {
                if (forma1Repository.existing(teamName))
                {
                    throw new ServiceException($"{teamName} már létezik!");
                }

                Team t = new Team(teamName);
                forma1Repository.add(t);
            }
            catch (RepositoryException re)
            {
                Debug.WriteLine(re.Message);
            }
            catch (Exception e)
            {
                throw new ServiceException(e.Message);
            }
        }
    }
}
