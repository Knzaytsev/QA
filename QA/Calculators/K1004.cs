using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QA.Calculators
{
    class K1004 : CalculateIndicator
    {
        private const string nameFirstParam = @"Число логических блоков, отработавших в процессе тестирования и отладки";
        private const string nameSecondParam = @"Общее число логических блоков";
        public override float Calculate(object qtb, object qob)
        {
            return (float)qtb / (float)qob;
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
