using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QA.Classes;
using QA.Interactors;
using QA.Repositories;

namespace QA.Filters
{
    public static class IndicatorsFilter
    {
        private static string IndicatorsPath = @"..\..\Data\Indicators.xml";

        public static Indicator[] FilterIndicators()
        {
            FileUser fileUser = new FileUser(IndicatorsPath, new IndicatorsRepository());
            Indicator[] indicators = (Indicator[])fileUser.getElements();

            Metric[] metrics = MetricsFilter.FilterMetrics();
            indicators = SetPriority(indicators, metrics);
            return indicators;
        }

        private static Indicator[] SetPriority(Indicator[] indicators, Metric[] metrics)
        {
            string[] indicatorsGroups;
            List<Indicator> neededIndicators = new List<Indicator>();
            IEnumerable<Indicator> temp;
            foreach (Metric metric in metrics)
            {
                indicatorsGroups = metric.Metrics.Split(' ');
                foreach (string group in indicatorsGroups)
                {
                    temp = indicators.Where(x => x.Code.StartsWith(group));
                    foreach (Indicator t in temp)
                    {
                        t.Priority = metric.Priority;
                    }
                    neededIndicators.AddRange(temp);
                }
            }

            return neededIndicators.Distinct().ToArray();
        }
    }
}
