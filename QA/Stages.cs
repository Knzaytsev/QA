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
using QA.Filters;
using QA.Singletons;

namespace QA
{
    public partial class Stages : Form
    {
        private bool closedByUser = true;

        private float[] indicators;

        public Stages(float[] values = null)
        {
            InitializeComponent();
            indicators = values;
        }

        private void Analysis_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;

            if (radioButton.Checked)
            {
                int id = int.Parse((string)radioButton.Tag);
                GetPhase(id);
            }
        }

        private void ProjectingRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;

            if (radioButton.Checked)
            {
                int id = int.Parse((string)radioButton.Tag);
                GetPhase(id);
            }
        }

        private void ImplementationRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;

            if (radioButton.Checked)
            {
                int id = int.Parse((string)radioButton.Tag);
                GetPhase(id);
            }
        }

        private void ManufactureReleaseRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;

            if (radioButton.Checked)
            {
                int id = int.Parse((string)radioButton.Tag);
                GetPhase(id);
            }
        }

        private void ManufactureTestRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;

            if (radioButton.Checked)
            {
                int id = int.Parse((string)radioButton.Tag);
                GetPhase(id);
            }
        }

        private void IntroductionRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;

            if (radioButton.Checked)
            {
                int id = int.Parse((string)radioButton.Tag);
                GetPhase(id);
            }
        }

        private void ExploitationRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;

            if (radioButton.Checked)
            {
                int id = int.Parse((string)radioButton.Tag);
                GetPhase(id);
            }
        }

        private void ServiceRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;

            if (radioButton.Checked)
            {
                int id = int.Parse((string)radioButton.Tag);
                GetPhase(id);
            }
        }

        private void GetPhase(int id)
        {
            FileUser fileUser = new FileUser(Properties.Settings.Default.Phases, new LifeCyclePhaseRepository());
            DataSingleton.GetInstance(((Phase)fileUser.getElementById(id)).Id);
        }

        private void ChoosePhase_Click(object sender, EventArgs e)
        {
            IndicatorsFilter indicatorsFilter = new IndicatorsFilter();
            Indicator[] indicators = indicatorsFilter.FilterIndicators();
            DataSingleton dataSingleton = DataSingleton.GetInstance();
            SavePointSingleton savePointSingleton = SavePointSingleton.GetInstance();
            int diff = indicators.Count(x => x.IdMethod > -1);
            if (dataSingleton.IdPhase == savePointSingleton.SavePoint.IdPhase &&
                dataSingleton.SoftwareTool == savePointSingleton.SavePoint.IdSoftwareTool &&
                indicators.Length == savePointSingleton.SavePoint.IndicatorsValues.Length + diff)
            {
                int count = 0;
                for (int i = 0; i < indicators.Length; ++i)
                {
                    if (indicators[i].IdMethod > -1)
                    {
                        ++count;
                        continue;
                    }
                    bool ok = float.TryParse(savePointSingleton.SavePoint.IndicatorsValues[i - count]?.Replace('.', ','), out float t);
                    indicators[i].Value = ok ? t : -1;
                }
            }
            else
            {
                foreach (Indicator indicator in indicators)
                {
                    indicator.Value = -1;
                }
            }

            Evaluation form = new Evaluation(indicators);
            form.Show();
            closedByUser = false;
            Close();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            MainForm form = new MainForm();
            form.Show();
            closedByUser = false;
            Close();
        }

        private void Stages_Load(object sender, EventArgs e)
        {
            DataSingleton instance = DataSingleton.GetInstance();
            if (instance != null)
            {
                foreach (Control children in panel1.Controls)
                {
                    if (Equals(children.Tag, instance.IdPhase.ToString()))
                    {
                        ((RadioButton)children).Checked = true;
                        break;
                    }
                }
            }
        }

        private void Stages_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (closedByUser)
            {
                Application.Exit();
            }
        }
    }
}
