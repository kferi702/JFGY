using Forma1.Controller;
using System;
using System.Windows.Forms;

namespace Forma1
{
    public partial class Form1Form : Form
    {
        F1Controller controller;
        public Form1Form()
        {
            controller = new F1Controller();
            InitializeComponent();
        }

        private void buttonInitializeData_Click(object sender, EventArgs e)
        {
            controller.provideTestData();
            listBoxTeam.DataSource = controller.getTeamNames();
        }

        private void listBoxTeam_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxTeam.SelectedIndex < 0)
            {
                return;
            }

            string teamName = listBoxTeam.SelectedItem.ToString();
            textBoxTeamName.Text = teamName;

            listBoxRacer.DataSource = null;
            listBoxRacer.DataSource = controller.getRacersNames(teamName);
        }

        private void buttonAddRacer_Click(object sender, EventArgs e)
        {
            errorProviderAddTeam.Clear();

            string teamName = textBoxTeamName.Text;

            try
            {
                controller.createTeamName(teamName);
            }
            catch (ControllerException ex)
            {
                errorProviderAddTeam.SetError(buttonAddTeam, ex.Message);
            }

            listBoxTeam.DataSource = null;
            listBoxTeam.DataSource = controller.getTeamNames();
        }

        private void buttonUpdateRacer_Click(object sender, EventArgs e)
        {

        }

        private void buttonDeleteRacer_Click(object sender, EventArgs e)
        {

        }
    }
}
