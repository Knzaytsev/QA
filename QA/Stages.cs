using QA.Classes;
using QA.Interactors;
using QA.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QA
{
    public partial class Stages : Form
    {
        string LCPhasesPath = @"..\..\Data\LifeCyclePhases.xml";
        public Stages()
        {
            InitializeComponent();
        }

        private void Analysis_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;

            if (radioButton.Checked)
            {
                int id = int.Parse((string)radioButton.Tag);

                Phase phase = GetPhase(id);
            }
        }

        private void ProjectingRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;

            if (radioButton.Checked)
            {
                int id = int.Parse((string)radioButton.Tag);

                Phase phase = GetPhase(id);
            }
        }

        private void ImplementationRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;

            if (radioButton.Checked)
            {
                int id = int.Parse((string)radioButton.Tag);

                Phase phase = GetPhase(id);
            }
        }

        private void ManufactureReleaseRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;

            if (radioButton.Checked)
            {
                int id = int.Parse((string)radioButton.Tag);

                Phase phase = GetPhase(id);
            }
        }

        private void ManufactureTestRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;

            if (radioButton.Checked)
            {
                int id = int.Parse((string)radioButton.Tag);

                Phase phase = GetPhase(id);
            }
        }

        private void IntroductionRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;

            if (radioButton.Checked)
            {
                int id = int.Parse((string)radioButton.Tag);

                Phase phase = GetPhase(id);
            }
        }

        private void ExploitationRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;

            if (radioButton.Checked)
            {
                int id = int.Parse((string)radioButton.Tag);

                Phase phase = GetPhase(id);
            }
        }

        private void ServiceRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;

            if (radioButton.Checked)
            {
                int id = int.Parse((string)radioButton.Tag);

                Phase phase = GetPhase(id);
            }
        }

        private Phase GetPhase(int id)
        {
            FileUser fileUser = new FileUser(LCPhasesPath, new LifeCyclePhaseRepository());
            return (Phase)fileUser.getElementById(id);
        }

        private void ChoosePhase_Click(object sender, EventArgs e)
        {

        }

        private void Back_Click(object sender, EventArgs e)
        {

        }
    }
}
