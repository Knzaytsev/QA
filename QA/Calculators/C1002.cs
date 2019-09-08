using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QA.Calculators
{
    class C1002 : CalculateIndicator
    {
        private const string nameFirstParam = @"Общее число переходов по условию";
        private const string nameSecondParam = @"Общее число исполняемых операторов";
        public override float Calculate(object a, object b)
        {
            return 1.0f - (float)a / (float)b;
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
