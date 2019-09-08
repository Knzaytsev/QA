using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QA.Classes
{
    [Serializable]
    public class SavePoint
    {
        public int IdPhase { get; set; }

        public int IdSoftwareTool { get; set; }

        public string[] IndicatorsValues { get; set; }

        public SavePoint()
        {

        }

        public SavePoint(int idPhase, int idSoftwareTool, string[] indicatorsValues)
        {
            IdPhase = idPhase;
            IdSoftwareTool = idSoftwareTool;
            IndicatorsValues = indicatorsValues;
        }
    }
}
