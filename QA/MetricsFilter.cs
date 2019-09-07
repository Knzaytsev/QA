using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QA.Classes;
using QA.Interactors;
using QA.Repositories;

namespace QA
{
    public static class MetricsFilter
    {
        private static string MetricsPath = @"..\..\Data\Metrics.xml";

        public static Metric[] FilterMetrics()
        {
            FileUser fileUser = new FileUser(MetricsPath, new MetricRepository());
            Metric[] metrics = (Metric[])fileUser.getElements();
            metrics = FilterByPhase(metrics);
            metrics = SetPriority(metrics);
            return metrics;
        }

        private static Metric[] FilterByPhase(Metric[] metrics)
        {
            return metrics.Where(x => x.PhaseId == DataSingleton.GetInstance().IdPhase).ToArray();
        }

        /// <summary>
        /// Установка приоритетов для ОП
        /// </summary>
        private static Metric[] SetPriority(Metric[] metrics)
        {
            int[] priorities = DataSingleton.GetInstance().Priorities.ToArray();
            List<Metric> result = new List<Metric>();
            for (int i = 0; i < priorities.Length; ++i)
            {
                int priority = priorities[i];
                var temp = metrics.Where(x => x.CriteriaId == i);
                foreach (Metric metric in temp)
                {
                    metric.Priority = priority;
                    result.Add(metric);
                }
            }

            return result.ToArray();
        }
    }
}
