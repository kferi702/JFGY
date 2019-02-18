﻿using System.Collections.Generic;
using Forma1.Exceptions;

namespace Forma1.Repository
{
    public class F1 : IF1
    {
        private List<Team> teams;
        private Team team;

        public F1()
        {
            teams = new List<Team>();
        }

        public void add(Team t)
        {
            teams.Add(t);
        }

        public void delete(string name)
        {
            int index = 0;
            foreach (Team t in teams)
            {
                if (t.getName() == name)
                {
                    teams.RemoveAt(index);
                    return;
                }
                index++;
            }
            throw new F1Exception($"{name} nevű csapat nem létezik, nem lehet törölni!");
        }

        public void update(string name, string newName)
        {
            foreach (Team t in teams)
            {
                if (t.getName() == name)
                {
                    t.update(newName);
                    return;
                }
            }
            throw new F1Exception($"{name} nevű csapat nem létezik, nem lehet módosítani!");
        }

        public int getF1Salary()
        {
            int sum = 0;
            foreach (Team t in teams)
            {
                sum += t.getTeamSalary();
            }
            return sum;
        }

        public List<string> getTeamNamesList()
        {
            List<string> names = new List<string>();

            foreach (Team t in teams)
            {
                names.Add(t.getName());
            }

            return names;
        }

        public bool isExistingTeamName(string teamName)
        {
            foreach (Team t in teams)
            {
                if (t.getName() == teamName)
                {
                    return true;
                }
            }

            return false;
        }

        public List<string> getRacerNameFromTheTeam(string teamName)
        {
            foreach (Team t in teams)
            {
                if (t.getName() == teamName)
                {
                    return t.getRacerNames();
                }
            }

            return null;
        }
    }
}
