﻿using Forma1.Repository;
using Forma1.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Forma1.Model;

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

        public List<string> getTeamRacersName(string teamName)
        {
            List<Racer> racers = service.getRacers(teamName);
            List<string> racersName = new List<string>();

            foreach (Racer r in racers)
            {
                racersName.Add(r.getName());
            }

            return racersName;
        }

        public string getF1Salary()
        {
            int f1Salary = service.getF1Salary();
            return f1Salary.ToString();
        }

        public string getTeamSalary(string teamName)
        {
            int teamSalary = service.getTeamSalary(teamName);
            return teamSalary.ToString();
        }
    }
}