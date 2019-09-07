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
    class CalculateResult
    {

        public Result[] CalculateMetrics(Indicator[] indicators)
        {
            FileUser fileUser = new FileUser(MetricsPath, new MetricRepository());
            Metric[] metrics = (Metric[])fileUser.getElements();
            foreach (var VARIABLE in COLLECTION)
            {
                
            }
        }

        public Result[] CalculateCriteria(Criteria[] criterias)
        {

        }

        public Result[] CalculateSoftwareTool(SoftwareTool softwareTool)
        {

        }
    }
}
