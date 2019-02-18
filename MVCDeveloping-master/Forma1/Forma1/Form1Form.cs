using System;
using System.Windows.Forms;
using Forma1.Controller;
using Forma1.Exceptions;

namespace Forma1
{
    public partial class Form1Form : Form
    {
        private Forma1Controller controller;

        public Form1Form()
        {
            InitializeComponent();
            controller = new Forma1Controller();
        }

        private void buttonInitializeData_Click(object sender, EventArgs e)
        {
            controller.initializeTestData();
            listBoxTeam.DataSource = controller.getTeamNamesList();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void listBoxTeam_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxTeam.SelectedIndex >= 0)
            {
                string teamName = listBoxTeam.SelectedItem.ToString();
                listBoxRacer.DataSource = controller.getTeamRacersName(teamName);
            }
        }

        private void buttonAddTeam_Click(object sender, EventArgs e)
        {
            string teamName = textBoxNewTeamName.Text;
            errorProviderAddTeam.Clear();
            try
            {
                controller.addTeamToF1(teamName);
                listBoxTeam.DataSource = null;
                listBoxTeam.DataSource = controller.getTeamNamesList();
            }
            catch (ControllerException controlEx)
            {
                errorProviderAddTeam.SetError(buttonAddTeam, controlEx.Message);
            }
        }

        private void buttonUpdateTeam_Click(object sender, EventArgs e)
        {

        }

        private void buttonDeleteTeam_Click(object sender, EventArgs e)
        {

        }
    }
}
