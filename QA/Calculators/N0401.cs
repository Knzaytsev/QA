using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QA.Calculators
{
    class N0401 : CalculateIndicator
    {
        private const string nameFirstParam = @"Число зарегистрированных отказов";
        private const string nameSecondParam = @"Число экспериментов";
        public override float Calculate(object q, object n)
        {
            return 1.0f - (float)q / (float)n;
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
