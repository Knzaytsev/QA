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
        public Evaluation()
        {
            InitializeComponent();
        }

        private void Compute_Click(object sender, EventArgs e)
        {
            bool flag = true;
            foreach(DataGridViewRow r in CharsListDGV.Rows)
            {
                var value = r.DataGridView["Value", 0].Value;
                if (!(value is float || value is int))
                {
                    r.DataGridView["Value", 0].Style.BackColor = System.Drawing.Color.Red;
                    flag = false;
                }
                else
                {
                    if ((float)value > 1 || (float)value < 0)
                    {
                        r.DataGridView["Value", 0].Style.BackColor = System.Drawing.Color.Red;
                        flag = false;
                    }
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
            //Получение ОП
            /*indicators = characteristics;
            foreach (var c in characteristics)
            {
                CharsListDGV.Rows.Add(c.Id, c.Code, c.Description);
            }*/
        }
    }
}
