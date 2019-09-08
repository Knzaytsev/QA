using QA.Classes;
using QA.Calculators;
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
using QA.Repositories;

namespace QA
{
    public partial class Evaluation : Form
    {
        private Indicator[] indicators;
        private List<Indicator> methodIndicators = new List<Indicator>();

        private bool closedByUser = true;

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
                string tag = (string)CharsListDGV["Value", i].Tag;
                switch (tag)
                {
                    case "w":
                        CharsListDGV["Value", i].Style.BackColor = System.Drawing.Color.FromArgb(255, 240, 240); //всё ок
                        break;
                    case "y":
                        CharsListDGV["Value", i].Style.BackColor = System.Drawing.Color.FromArgb(254, 255, 211); //всё ок
                        break;
                }
                if (tag == "y" && (CharsListDGV["Value", i].Value is null || (string)CharsListDGV["Value", i].Value == ""))
                {
                    continue;
                }
                float value = 0;
                try
                {
                    value = float.Parse(((string) CharsListDGV["Value", i].Value).Replace('.', ','));
                    if (value > 1 || value < 0)
                        throw new Exception();
                }
                catch (Exception exc)
                {
                    CharsListDGV["Value", i].Style.BackColor = tag == "w" ? System.Drawing.Color.FromArgb(255, 207, 207) : System.Drawing.Color.FromArgb(252, 255, 140);

                    flag = false;
                }
            }
            if (!flag)
                return;

            for (int i = 0; i < CharsListDGV.Rows.Count; ++i)
            {
                string tag = (string)CharsListDGV["Value", i].Tag;
                if (tag == "y" && (CharsListDGV["Value", i].Value is null || (string)CharsListDGV["Value", i].Value == ""))
                {
                    continue;
                }
                float value = float.Parse(((string)CharsListDGV["Value", i].Value).Replace('.', ','));
                int id = (int)CharsListDGV["Id", i].Value;
                Indicator ind = (from indicator in indicators where indicator.Id == id select indicator).First();
                id = indicators.ToList().IndexOf(ind);
                indicators[id].Value = (float)value;

            }
            CalculateResult calculate = new CalculateResult();
            calculate.GeneralResult(indicators, out Result[] metrics, out Result[] criterias, out Result softwareTool);
            MessageBox.Show("Оценка вашего ПС: " + softwareTool.Assessment, "Результат", MessageBoxButtons.OK);

            DialogResult dialogResult = MessageBox.Show("Сохранить результаты в файл?", "", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "Text files(*.txt)|*.txt";
                if (sfd.ShowDialog() == DialogResult.Cancel)
                {
                    return;
                }
                string fileName = sfd.FileName;
                using (StreamWriter sw = new StreamWriter(new FileStream(fileName, FileMode.OpenOrCreate)))
                {
                    string resultGeneral = "Ваш общий результат оценки ПС: " + softwareTool.Assessment;
                    sw.WriteLine(resultGeneral);
                    sw.WriteLine();
                    resultGeneral = "Ваши результаты на уровне критериев:";
                    sw.WriteLine(resultGeneral);
                    foreach (var c in criterias)
                    {
                        Criteria criteria = (Criteria)c.Layer;
                        resultGeneral = "Критерий: " + criteria.Description;
                        sw.WriteLine(resultGeneral);
                        resultGeneral = "Оценка критерия: " + c.Assessment;
                        sw.WriteLine(resultGeneral);
                    }
                    sw.WriteLine();
                    resultGeneral = "Ваши результаты на уровне метрик:";
                    sw.WriteLine(resultGeneral);
                    foreach (var m in metrics)
                    {
                        Metric metric = (Metric)m.Layer;
                        resultGeneral = "Метрики: " + metric.Metrics;
                        sw.WriteLine(resultGeneral);
                        resultGeneral = "Оценка метрик: " + m.Assessment;
                        sw.WriteLine(resultGeneral);
                    }
                }
            }
        }

        private void EvaluationLoad(object sender, EventArgs e)
        {
            int offset = 0;
            for (int i = 0; i < indicators.Length; ++i)
            {
                Color color = Color.FromArgb(255, 207, 207); //незаполнено или ошибка
                string tag = "";
                switch (indicators[i].Priority)
                {
                    case 1:
                        color = Color.FromArgb(255, 207, 207);
                        tag = "w";
                        break;
                    case 0:
                        color = Color.FromArgb(252, 255, 140);
                        tag = "y";
                        break;
                    case -1:
                        continue;
                }
                if (indicators[i].IdMethod != -1)
                {
                    foreach (Button c in buttonPanel.Controls)
                    {
                        if (Equals(c.Tag, indicators[i].IdMethod.ToString()))
                        {
                            c.BackColor = indicators[i].Priority == 0 ? Color.FromArgb(252, 255, 140) : Color.FromArgb(255, 207, 207);
                            c.Enabled = true;
                            methodIndicators.Add(indicators[i]);
                        }
                    }
                    offset++;
                    continue;
                }
                CharsListDGV.Rows.Add(indicators[i].Id, indicators[i].Code, indicators[i].Description, indicators[i].Value == -1 ? "" : indicators[i].Value.ToString());
                CharsListDGV["Value", i - offset].Tag = tag;
                CharsListDGV["Value", i - offset].Style.BackColor = color;
            }
        }

        private void Back_Click(object sender, EventArgs e)
        {
            Stages form = new Stages();
            form.Show();
            closedByUser = false;
            this.Close();
        }

        private void Evaluation_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (closedByUser)
            {
                Application.Exit();
            }
        }

        private void N0305_Click(object sender, EventArgs e)
        {
            ComputeTwoParams form = new ComputeTwoParams(new N0305());
            if (form.ShowDialog() == DialogResult.Cancel)
                return;
            float result = form.Result;
            SetValue(0, result);
        }

        private void N0401_Click(object sender, EventArgs e)
        {
            ComputeTwoParams form = new ComputeTwoParams(new N0401());
            if (form.ShowDialog() == DialogResult.Cancel)
                return;
            float result = form.Result;
            SetValue(1, result);
        }

        private void N0501_Click(object sender, EventArgs e)
        {
            ComputeSomeParams form = new ComputeSomeParams();
            if (form.ShowDialog() == DialogResult.Cancel)
                return;
            float result = form.Result;
            SetValue(2, result);
        }

        private void N0502_Click(object sender, EventArgs e)
        {
            ComputeTwoParams form = new ComputeTwoParams(new N0502());
            if (form.ShowDialog() == DialogResult.Cancel)
                return;
            float result = form.Result;
            SetValue(3, result);
        }

        private void C0302_Click(object sender, EventArgs e)
        {
            ComputeTwoParams form = new ComputeTwoParams(new C0302());
            if (form.ShowDialog() == DialogResult.Cancel)
                return;
            float result = form.Result;
            SetValue(4, result);

        }

        private void C1002_Click(object sender, EventArgs e)
        {
            ComputeTwoParams form = new ComputeTwoParams(new C1002());
            if (form.ShowDialog() == DialogResult.Cancel)
                return;
            float result = form.Result;
            SetValue(5, result);
        }

        private void K1003_Click(object sender, EventArgs e)
        {
            ComputeTwoParams form = new ComputeTwoParams(new K1003());
            if (form.ShowDialog() == DialogResult.Cancel)
                return;
            float result = form.Result;
            SetValue(6, result);
        }

        private void K1004_Click(object sender, EventArgs e)
        {
            ComputeTwoParams form = new ComputeTwoParams(new K1004());
            if (form.ShowDialog() == DialogResult.Cancel)
                return;
            float result = form.Result;
            SetValue(7, result);
        }

        private void SetValue(int idMethod, float result)
        {
            Indicator indicator = new Indicator();
            for(int i = 0; i < methodIndicators.Count; ++i)
            {
                if (methodIndicators[i].IdMethod == idMethod)
                {
                    indicator = methodIndicators[i];
                    break;
                }
            }
            int id = indicators.ToList().IndexOf(indicator);
            indicators[id].Value = result;
        }

        private void SaveData_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "xml files (*.xml)|*.xml";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    DataSingleton instance = DataSingleton.GetInstance();

                    List<string> values = new List<string>();
                    for (int i = 0; i < CharsListDGV.RowCount; ++i)
                    {
                        values.Add(CharsListDGV["Value", i].Value != null ? CharsListDGV["Value", i].Value.ToString() : "");
                    }
                    SavePoint savePoint = new SavePoint(instance.IdPhase, instance.SoftwareTool, values.ToArray());
                    SavePointRepository savePointRepository = new SavePointRepository();
                    savePointRepository.SaveElement(savePoint, sfd.FileName);
                }
            }
        }
    }
}
