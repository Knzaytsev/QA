using QA.Classes;
using QA.Interactors;
using QA.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QA
{
    public partial class MainForm : Form
    {
        string STsPath = @"..\..\Data\SoftwareTools.xml";
        string STandCM = @"..\..\Data\SoftwareToolsAndCritariaMatrix.txt";
        public MainForm()
        {
            InitializeComponent();
        }


        private void OSradioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;

            if(radioButton.Checked == true)
            {
                int id = int.Parse((string)radioButton.Tag);
                int[] filteredCriteria = GetFilteredCriteria(id);
            }
        }

        private void DBMSradioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;

            if (radioButton.Checked == true)
            {
                int id = int.Parse((string)radioButton.Tag);
                int[] filteredCriteria = GetFilteredCriteria(id);
            }
        }

        private void ProgrammingToolsRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;

            if (radioButton.Checked == true)
            {
                int id = int.Parse((string)radioButton.Tag);
                int[] filteredCriteria = GetFilteredCriteria(id);
            }
        }

        private void InterfaceCommunicationRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;

            if (radioButton.Checked == true)
            {
                int id = int.Parse((string)radioButton.Tag);
                int[] filteredCriteria = GetFilteredCriteria(id);
            }
        }

        private void ComputingProcessRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;

            if (radioButton.Checked == true)
            {
                int id = int.Parse((string)radioButton.Tag);
                int[] filteredCriteria = GetFilteredCriteria(id);
            }
        }

        private void ServiceSoftwareRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;

            if (radioButton.Checked == true)
            {
                int id = int.Parse((string)radioButton.Tag);
                int[] filteredCriteria = GetFilteredCriteria(id);
            }
        }

        private void ServiceComputingRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;

            if (radioButton.Checked == true)
            {
                int id = int.Parse((string)radioButton.Tag);
                int[] filteredCriteria = GetFilteredCriteria(id);
            }
        }

        private void ScienceResearchRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;

            if (radioButton.Checked == true)
            {
                int id = int.Parse((string)radioButton.Tag);
                int[] filteredCriteria = GetFilteredCriteria(id);
            }
        }

        private void ProjectingRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;

            if (radioButton.Checked == true)
            {
                int id = int.Parse((string)radioButton.Tag);
                int[] filteredCriteria = GetFilteredCriteria(id);
            }
        }

        private void ManagingRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;

            if (radioButton.Checked == true)
            {
                int id = int.Parse((string)radioButton.Tag);
                int[] filteredCriteria = GetFilteredCriteria(id);
            }
        }

        private void EconomyRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;

            if (radioButton.Checked == true)
            {
                int id = int.Parse((string)radioButton.Tag);
                int[] filteredCriteria = GetFilteredCriteria(id);
            }
        }

        private void OtherRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;

            if (radioButton.Checked == true)
            {
                int id = int.Parse((string)radioButton.Tag);
                int[] filteredCriteria = GetFilteredCriteria(id);
            }
        }

        private int[] GetFilteredCriteria(int id)
        {
            FileUser fileUser = new FileUser(STsPath, new SoftwareToolRepository());
            SoftwareTool softwareTool = (SoftwareTool)fileUser.getElementById(id);

            fileUser = new FileUser(STandCM, new CriteriaMatrixRepository());
            return (int[])fileUser.getElementById(softwareTool.Id);
        }

        private void ChooseClass_Click(object sender, EventArgs e)
        {
            Stages form = new Stages();
            form.Show();
            this.Visible = false;
        }
    }
}
