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
using QA.Singletons;

namespace QA
{
    public partial class MainForm : Form
    {
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
                GetFilteredCriteria(id);
            }
        }

        private void DBMSradioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;

            if (radioButton.Checked == true)
            {
                int id = int.Parse((string)radioButton.Tag);
                GetFilteredCriteria(id);
            }
        }

        private void ProgrammingToolsRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;

            if (radioButton.Checked == true)
            {
                int id = int.Parse((string)radioButton.Tag);
                GetFilteredCriteria(id);
            }
        }

        private void InterfaceCommunicationRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;

            if (radioButton.Checked == true)
            {
                int id = int.Parse((string)radioButton.Tag);
                GetFilteredCriteria(id);
            }
        }

        private void ComputingProcessRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;

            if (radioButton.Checked == true)
            {
                int id = int.Parse((string)radioButton.Tag);
                GetFilteredCriteria(id);
            }
        }

        private void ServiceSoftwareRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;

            if (radioButton.Checked == true)
            {
                int id = int.Parse((string)radioButton.Tag);
                GetFilteredCriteria(id);
            }
        }

        private void ServiceComputingRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;

            if (radioButton.Checked == true)
            {
                int id = int.Parse((string)radioButton.Tag);
                GetFilteredCriteria(id);
            }
        }

        private void ScienceResearchRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;

            if (radioButton.Checked == true)
            {
                int id = int.Parse((string)radioButton.Tag);
                GetFilteredCriteria(id);
            }
        }

        private void ProjectingRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;

            if (radioButton.Checked == true)
            {
                int id = int.Parse((string)radioButton.Tag);
                GetFilteredCriteria(id);
            }
        }

        private void ManagingRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;

            if (radioButton.Checked == true)
            {
                int id = int.Parse((string)radioButton.Tag);
                GetFilteredCriteria(id);
            }
        }

        private void EconomyRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;

            if (radioButton.Checked == true)
            {
                int id = int.Parse((string)radioButton.Tag);
                GetFilteredCriteria(id);
            }
        }

        private void OtherRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;

            if (radioButton.Checked == true)
            {
                int id = int.Parse((string)radioButton.Tag);
                GetFilteredCriteria(id);
            }
        }

        private void GetFilteredCriteria(int id)
        {
            FileUser fileUser = new FileUser(Properties.Settings.Default.SoftwareTools, new SoftwareToolRepository());
            SoftwareTool softwareTool = (SoftwareTool)fileUser.getElementById(id);

            fileUser = new FileUser(Properties.Settings.Default.Matrix, new CriteriaMatrixRepository());
            DataSingleton.GetInstance(id, true);
            DataSingleton.GetInstance((int[])fileUser.getElementById(softwareTool.Id));
        }

        private void ChooseClass_Click(object sender, EventArgs e)
        {
            Stages form = new Stages();
            form.Show();
            this.Visible = false;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            DataSingleton instance = DataSingleton.GetInstance();
            if (instance != null)
            {
                foreach (Control children in panel1.Controls)
                {
                    if (Equals(children.Tag, instance.SoftwareTool.ToString()))
                    {
                        ((RadioButton)children).Checked = true;
                        break;
                    }
                }
            }
        }

        private void loadData_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "xml files (*.xml)|*.xml";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        FileUser fileUser = new FileUser(ofd.FileName, new SavePointRepository());
                        SavePoint savePoint = (SavePoint)fileUser.getElementById(0);
                        EditSavePoint loader = new EditSavePoint();
                        loader.LoadSavePoint(savePoint);
                        CheckRadioButton(savePoint.IdSoftwareTool);
                        DataSingleton.GetInstance(savePoint.IdPhase, savePoint.IdSoftwareTool);
                        SavePointSingleton.GetInstance(savePoint);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Ошибка загрузки файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void CheckRadioButton(int id)
        {
            foreach (Control control in panel1.Controls)
            {
                if (Equals(control.Tag, id.ToString()))
                {
                    ((RadioButton) control).Checked = true;
                    break;
                }
            }
        }
    }
}
