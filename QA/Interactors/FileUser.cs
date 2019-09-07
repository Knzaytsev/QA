using QA.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QA.Interactors
{
    class FileUser
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

        public FileUser(string path, IGetElement getElement)
        {
            this.path = path;
            this.getElement = getElement;
        }

        public object getElementById(int id)
        {
            return getElement.GetElement(path, id);
        }
    }
}
