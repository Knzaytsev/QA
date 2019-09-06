using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QA.Classes
{
    [Serializable]
    class Phase
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Subphase { get; set; }

        public string Result { get; set; }

        public Phase()
        {

        }
    }
}
