using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QA.Calculators
{
    class K1003 : CalculateIndicator
    {
        private const string nameFirstParam = @"Число модулей, отработавших в процессе тестирования и отладки";
        private const string nameSecondParam = @"Общее число модулей";
        public override float Calculate(object qtm, object qom)
        {
            return (float)qtm / (float)qom;
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
