using QA.Classes;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace QA.Interactors
{
    class FileUser
    {
        private string path;

        public FileUser(string path)
        {
            this.path = path;
        }

        public object GetItems(IGetItems getItems)
        {
            return getItems.GetItems(path);
        }
    }
}
