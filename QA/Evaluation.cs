using QA.Classes;
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
                if (tag == "y" && CharsListDGV["Value", i].Value is null)
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
                if (tag == "y" && CharsListDGV["Value", i].Value is null)
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

            DialogResult dialogResult = MessageBox.Show("Хотите сохранить результаты в файл?", "", MessageBoxButtons.YesNo);
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
                CharsListDGV.Rows.Add(indicators[i].Id, indicators[i].Code, indicators[i].Description, indicators[i].Value);
                CharsListDGV["Value", i].Tag = tag;
                CharsListDGV["Value", i].Style.BackColor = color;
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
