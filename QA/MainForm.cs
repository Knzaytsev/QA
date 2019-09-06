using QA.Classes;
using QA.Interactors;
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
        public MainForm()
        {
            InitializeComponent();
        }

        private void OSradioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;
            if (radioButton.Checked)
            {
                int id = int.Parse((string)radioButton.Tag);

                FileUser fileUser = new FileUser(@"C:\Users\Tuccc\Desktop\Учёба\3 курс\QA & T\QA\QA\Data\SoftwareTools.xml");
                SoftwareTool[] softwareTools = (SoftwareTool[])fileUser.GetItems(new GetSoftwareTools());

                SoftwareTool softwareTool = softwareTools[id];

                GetCriteriaMatrix criteriaMatrix = new GetCriteriaMatrix();
                int[] matrix = criteriaMatrix.GetItems(@"C:\Users\Tuccc\Desktop\Учёба\3 курс\QA & T\QA\QA\Data\SoftwareToolsAndCritariaMatrix.txt", id);


            }
        }
    }
}
