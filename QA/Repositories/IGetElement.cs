using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QA.Repositories
{
    interface IGetElement
    {
        object GetElement(string path, int id);
    }
}
