﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QA.Classes
{
    [Serializable]
    public class Metric
    {
        public int Id { get; set; }

        public int CriteriaId { get; set; }

        public int PhaseId { get; set; }

        public string Metrics { get; set; }

        public int Priority { get; set; }

        public Metric()
        {

        }
    }
}
