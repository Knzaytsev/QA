﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QA.Classes
{
    [Serializable]
    public class Phase
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Step { get; set; }

        public string Result { get; set; }

        public Phase()
        {

        }
    }
}
