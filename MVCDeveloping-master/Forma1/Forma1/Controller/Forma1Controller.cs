using Forma1.Exceptions;
using System.Collections.Generic;
using Forma1.Service;
using Forma1.Validation;

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

        public void addTeamToF1(string teamName)
        {
            if (service.isExistingTeamName(teamName))
            {
                throw new ControllerException($"{teamName} csapat már létezik!");
            }

            try
            {
                NameValidator nameValidator = new NameValidator(teamName);
                nameValidator.validation();
            }
            catch (NameNotValidException e)
            {
                throw new ControllerException($"{teamName} nem megfelelő csapatnév!");
            }

            service.addTeam(teamName);
        }
    }
}
