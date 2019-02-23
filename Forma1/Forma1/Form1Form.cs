using Forma1.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            listBoxRacer.DataSource = controller.getTeamRacersName(teamName);
        }

        private void buttonComputeF1Salary_Click(object sender, EventArgs e)
        {
            textBoxF1Salary.Text = controller.getF1Salary();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void buttonComputeTeamSalary_Click(object sender, EventArgs e)
        {
            if (listBoxTeam.SelectedIndex > 0)
            {
                return;
            }

            string teamName = listBoxTeam.SelectedItem.ToString();
            textBoxTeamSalary.Text = controller.getTeamSalary(teamName);
        }
    }
}
