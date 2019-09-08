using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QA.Calculators
{
    public abstract class CalculateIndicator : ICalculateIndicators
    {
        public string NameFirstParam { get; private set; }
        public string NameSecondParam { get; private set; }
        public abstract float Calculate(object a, object b);

        public abstract string GetFirstName();

        public abstract string GetSecondName();
    }
}
