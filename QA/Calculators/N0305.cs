using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QA.Calculators
{
    class N0305 : CalculateIndicator
    {
        private const string nameFirstParam = @"Число экспериментов, в которых искажающие воздействия приводили к отказу";
        private const string nameSecondParam = @"Число экспериментов, в которых имитировались искажающие воздействия";
        public override float Calculate(object d, object k)
        {
            return 1.0f - (float)d / (float)k;
        }

        public override string GetFirstName()
        {
            return nameFirstParam;
        }

        public override string GetSecondName()
        {
            return nameSecondParam;
        }
    }
}
