using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QA.Calculators
{
    class N0502 : CalculateIndicator
    {
        private const string nameFirstParam = @"Допустимое время преобразования i-го входного набора данных";
        private const string nameSecondParam = @"Фактическая продолжительность преобразования i-го входного набора данных";
        public override float Calculate(object tp, object tpdop)
        {
            return (float)tp <= (float)tpdop ? 1 : (float)tpdop / (float)tp;
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
