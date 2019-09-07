using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QA.Classes
{
    [Serializable]
    class Criteria
    {
        public int Id { get; set; }

        public string Factor { get; set; }

        public string Mark { get; set; }

        public string Description { get; set; }

        public Criteria()
        {

        }
    }
}
