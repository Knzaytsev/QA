using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QA.Classes
{
    public class Indicator
    {
        public int Id { get; set; }

        public int Priority { get; set; }

        public string Code { get; set; }

        public string Description { get; set; }

        public int IdMethod { get; set; }

        public float Value { get; set; }

        public Indicator() { }
    }
}
