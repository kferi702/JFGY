using Forma1.Repository;
using Forma1.Model;
using Forma1.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forma1.Controller
{
    class F1Controller
    {
        TeamService service;

        public F1Controller()
        {
            service = new TeamService();
        }

        public void provideTestData()
        {
            service.provideTestData();
        }

        public List<string> getTeamNames()
        {
            List<Team> teams = service.getTeams();
            List<string> teamNames = new List<string>();
            foreach (Team t in teams)
            {
                teamNames.Add(t.getName());
            }
            return teamNames;

        }
        /// <summary>
        /// Elkészíti listába adott csapat versenyzőinek listáját
        /// </summary>
        /// <param name="teamName">Adott csapat neve</param>
        /// <returns>A versneyzők neveinek listája</returns>
        public List<string> getRacersNames(string teamName)
        {
            List<string> racersName = new List<string>();

            List<Racer> racers = service.getRacers(teamName);

            foreach (Racer r in racers)
            {
                racersName.Add(r.getName());
            }

            return racersName;
        }

        public void createTeamName(string teamName)
        {
            try
            {
                service.createTeam(teamName);
            }
            catch (Exception e)
            {
                throw new ControllerException(e.Message);
            }
        }
    }
}
