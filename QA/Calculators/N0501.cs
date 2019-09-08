using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QA.Calculators
{
    class N0501
    {
        public float Compute(int n, float tvdop, params float[] tvi)
        {
            float tv = ComputeTv(n, tvi);
            return tv <= tvdop ? 1.0f : tvdop / tv;
        }

        private float ComputeTv(int n, params float[] tvi)
        {
            float tv = 0;
            foreach (float t in tvi)
            {
                tv += t;
            }
            tv *= 1.0f / n;
            return tv;
        }
    }
}
