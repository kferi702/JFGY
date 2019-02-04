using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    }
}
