using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QA.Calculators
{
    class CalculateIndicators
    {
        public float Ind_H0305(int d, int k)
        {
            return 1 - (float) d / (float) k;
        }

        public float Ind_H0402(int q, int n)
        {
            return q - (float) q / (float) n;
        }
    }
}
