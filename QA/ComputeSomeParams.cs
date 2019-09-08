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
    public partial class ComputeSomeParams : Form
    {
        public float Result { get; set; }
        public ComputeSomeParams()
        {
            InitializeComponent();
        }

        private void Compute_Click(object sender, EventArgs e)
        {
            try
            {
                N0501 compute = new N0501();
                var tvd = float.Parse(tvdop.Text);
                float[] tvi = new float[dataGridView1.Rows.Count];
                if (tvi.Length <= 0)
                {
                    throw new Exception();
                }
                for(int i = 0; i < dataGridView1.Rows.Count - 1; ++i)
                {
                    float time = float.Parse((string)dataGridView1[0, i].Value);
                    tvi[i] = time;
                }
                float result = compute.Compute(tvi.Length, tvd, tvi);
                this.Result = result;
                if (tvd >= result)
                {
                    this.Result = 1;
                }
                this.DialogResult = DialogResult.OK;
            }catch(Exception exc)
            {
                MessageBox.Show("Введите корректно данные", "Ошибка!", MessageBoxButtons.OK);
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
