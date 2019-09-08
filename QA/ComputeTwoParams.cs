using QA.Calculators;
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
    public partial class ComputeTwoParams : Form
    {
        private CalculateIndicator calculate;
        public float Result { get; private set; }
        public ComputeTwoParams(CalculateIndicator calculate)
        {
            InitializeComponent();
            this.calculate = calculate;
        }

        private void Compute_Click(object sender, EventArgs e)
        {
            try
            {
                var first = float.Parse(a.Text);
                var second = float.Parse(b.Text);
                Result = calculate.Calculate(first, second);
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception exc)
            {
                MessageBox.Show("Введены неверные данные.", "Ошибка!", MessageBoxButtons.OK);
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void LoadForm(object sender, EventArgs e)
        {
            label1.Text = calculate.GetFirstName();
            label2.Text = calculate.GetSecondName();
        }
    }
}
