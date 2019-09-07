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

        private IGetAllElements getAllElements;

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

        public IGetAllElements GetAllElements
        {
            get { return getAllElements; }
            set { getAllElements = value; }
        }

        public FileUser(string path, IGetElement getElement)
        {
            this.path = path;
            this.getElement = getElement;
        }

        public FileUser(string path, IGetAllElements getAllElements)
        {
            this.path = path;
            this.getAllElements = getAllElements;
        }

        public object getElementById(int id)
        {
            return getElement.GetElement(path, id);
        }

        public object getElements()
        {
            return getAllElements.GetElements(path);
        }
    }
}
