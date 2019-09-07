using QA.Classes;
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
    public partial class Evaluation : Form
    {
        private Indicator[] indicators;
        public Evaluation(Indicator[] indicators)
        {
            InitializeComponent();
            this.indicators = indicators;
        }

        private void Compute_Click(object sender, EventArgs e)
        {
            bool flag = true;
            for (int i = 0; i < CharsListDGV.Rows.Count; ++i)
            {
                CharsListDGV["Value", i].Style.BackColor = System.Drawing.Color.White;
                float value = 0;
                try
                {
                    value = float.Parse((string)CharsListDGV["Value", i].Value);
                    if ((float)value > 1 || (float)value < 0)
                        throw new Exception();
                }
                catch(Exception exc)
                {
                    CharsListDGV["Value", i].Style.BackColor = System.Drawing.Color.FromArgb(255, 207, 207);
                    flag = false;
                }
            }
            if (!flag)
                return;

            foreach (DataGridViewRow r in CharsListDGV.Rows)
            {
                float value = (float)r.DataGridView["Value", 0].Value;
                int id = (int)r.DataGridView["Id", 0].Value;
                Indicator ind = (from i in indicators where i.Id == (int)id select i).First();
                id = indicators.ToList().IndexOf(ind);
                indicators[id].Value = (float)value;
            }
        }

        private void EvaluationLoad(object sender, EventArgs e)
        {
            for (int i = 0; i < indicators.Length; ++i)
            {
                Color color = Color.White;
                switch (indicators[i].Priority)
                {
                    case 1:
                        color = Color.White;
                        break;
                    case 0:
                        color = Color.FromArgb(254, 255, 171);
                        break;
                    case -1:
                        continue;
                }
                CharsListDGV.Rows.Add(indicators[i].Id, indicators[i].Code, indicators[i].Description);
                CharsListDGV["Value", i].Style.BackColor = color;
            }
        }

        private void Back_Click(object sender, EventArgs e)
        {
            Stages form = new Stages();
            form.Show();
            this.Close();
        }
    }
}
