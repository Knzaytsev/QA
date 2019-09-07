using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QA.Repositories;

namespace QA.Interactors
{
    interface IGet
    {
        string Path { get; set; }
        IGetElement GetElement { get; set; }
    }
}
