using System;
using System.Windows.Forms;
using Forma1.Controller;

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
            string teamName = listBoxTeam.SelectedItem.ToString();
            listBoxRacer.DataSource = controller.getTeamRacersName(teamName);
        }

        private void buttonAddTeam_Click(object sender, EventArgs e)
        {
            string teamName = textBoxNewTeamName.Text;
            controller.addTeamToF1(teamName);
        }

        private void buttonUpdateTeam_Click(object sender, EventArgs e)
        {
            controller.updateTeamInF1();
        }

        private void buttonDeleteTeam_Click(object sender, EventArgs e)
        {
            controller.deleteTeamFromF1();
        }
    }
}
