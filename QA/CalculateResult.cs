using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QA.Classes;
using QA.Filters;
using QA.Interactors;
using QA.Repositories;

namespace QA
{
    public class CalculateResult
    {
        public void GeneralResult(Indicator[] indicators, out Result[] metricsResults, out Result[] criteriaResults, out Result stResult)
        {
            metricsResults = CalculateMetrics(indicators);
            criteriaResults = CalculateCriteria(metricsResults);
            stResult = CalculateSoftwareTool(criteriaResults);
        }

        public Result[] CalculateMetrics(Indicator[] indicators)
        {
            MetricsFilter metricsFilter = new MetricsFilter();
            Metric[] metrics = metricsFilter.FilterMetrics();
            string[] temp;
            List<Result> results = new List<Result>();
            float sum;
            int count;
            IEnumerable<Indicator> neededIndicators = new List<Indicator>();
            foreach (Metric metric in metrics)
            {
                sum = 0;
                count = 0;
                temp = metric.Metrics.Split(' ');
                foreach (string t in temp)
                {
                    neededIndicators = indicators.Where(x => x.Code.StartsWith(t));
                }

                foreach (Indicator indicator in neededIndicators)
                {
                    sum += indicator.Value;
                    ++count;
                }
                if (count == 0) { count = 1; }
                results.Add(new Result(metric, 3, sum / count));
            }

            return results.ToArray();
        }

        public Result[] CalculateCriteria(Result[] metrics)
        {
            FileUser fileUser = new FileUser(Properties.Settings.Default.Criteria, new CriteriasRepository());
            Criteria[] allCriterias = (Criteria[]) fileUser.getElements();
            List<Result> results = new List<Result>();
            float[] sum = new float[allCriterias.Length];
            int[] count = new int[allCriterias.Length];
            bool[] flags = new bool[allCriterias.Length];
            foreach (Result metric in metrics)
            {
                Metric temp = (Metric) metric.Layer;
                flags[temp.CriteriaId] = true;
                sum[temp.CriteriaId] += metric.Assessment;
                ++count[temp.CriteriaId];
            }

            for (int i = 0; i < allCriterias.Length; ++i)
            {
                if (flags[i] == true)
                {
                    int c = count[i];
                    if (c == 0) { c = 1; }
                    results.Add(new Result(allCriterias[i], 2, sum[i] / c));
                }
            }

            return results.ToArray();
        }

        public Result CalculateSoftwareTool(Result[] criterias)
        {
            float sum = 0;
            float count = 0;
            foreach (Result criteria in criterias)
            {
                sum += criteria.Assessment;
                ++count;
            }

            if (count == 0) { count = 1; }

            FileUser fileUser = new FileUser(Properties.Settings.Default.SoftwareTools, new SoftwareToolRepository());
            SoftwareTool softwareTool = (SoftwareTool)fileUser.getElementById(DataSingleton.GetInstance().SoftwareTool);

            Result result = new Result(softwareTool, 1, sum / count);
            return result;
        }
    }
}
