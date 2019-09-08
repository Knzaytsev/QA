using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QA.Calculators
{
    class C0302 : CalculateIndicator
    {
        private const string nameFirstParam = @"Общее число точек входа в программу";
        public const string nameSecondParam = @"Общее число точек выхода из программы";
        public override float Calculate(object d, object f)
        {
            return 1.0f / (((float)d + 1.0f) / ((float)f + 1.0f));
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
