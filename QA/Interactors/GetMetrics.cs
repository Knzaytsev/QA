using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QA.Repositories;

namespace QA.Interactors
{
    class GetMetrics : IGet
    {
        private string path;

        private IGetElement getElement;

        public string Path
        {
            get { return path; }
            set { path = value; }
        }

        public IGetElement GetElement
        {
            get { return getElement; }
            set { getElement = value; }
        }

        public GetMetrics(string path, IGetElement getElement)
        {
            this.path = path;
            this.getElement = getElement;
        }
    }
}
