using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QA.Classes
{
    public class Result
    {
        public object Layer { get; set; }

        public int Level { get; set; }

        public float Assessment { get; set; }

        public Result(object layer, int level, float assessment)
        {
            Layer = layer;
            Level = level;
            Assessment = assessment;
        }
    }
}
