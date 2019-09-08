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
            return 1.0f - (float) d / (float) k;
        }

        public float Ind_H0402(int q, int n)
        {
            return 1.0f - (float) q / (float) n;
        }

        public float Ind_H0501(int n, float tvdop, params float[] tvi)
        {
            float tv = Ind_H0501_Tv(n, tvi);
            return tv <= tvdop ? 1.0f : tvdop / tv;
        }

        private float Ind_H0501_Tv(int n, params float[] tvi)
        {
            float tv = 0;
            foreach (float t in tvi)
            {
                tv += t;
            }
            tv *= 1.0f / n;
            return tv;
        }

        public float Ind_H0502(float tp, float tpdop)
        {
            return tp <= tpdop ? 1 : tpdop / tp;
        }

        public float Ind_C0302(int d, int f)
        {
            return 1.0f / ((d + 1.0f) / (f + 1.0f));
        }

        public float Ind_C1002(int a, int b)
        {
            return 1.0f - (float) a / (float) b;
        }

        public float Ind_K1003(int qtm, int qom)
        {
            return (float) qtm / (float) qom;
        }

        public float Ind_K1004(int qtb, int qob)
        {
            return (float) qtb / (float) qob;
        }
    }
}
