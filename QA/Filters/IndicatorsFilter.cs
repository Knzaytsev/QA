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
    public class IndicatorsFilter
    {
        private string IndicatorsPath = @"..\..\Data\Indicators.xml";

        public Indicator[] FilterIndicators()
        {
            FileUser fileUser = new FileUser(IndicatorsPath, new IndicatorsRepository());
            Indicator[] indicators = (Indicator[])fileUser.getElements();

            MetricsFilter metricsFilter = new MetricsFilter();
            Metric[] metrics = metricsFilter.FilterMetrics();
            indicators = SetPriority(indicators, metrics);
            return indicators;
        }

        private Indicator[] SetPriority(Indicator[] indicators, Metric[] metrics)
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
