using QA.Classes;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace QA.Repositories
{
    class SoftwareToolRepository : IGetElement
    {
        public object GetElement(string path, int id)
        {
            XmlSerializer formatter = new XmlSerializer(typeof(SoftwareTool[]));

            SoftwareTool[] softwareTools;
            using (FileStream fs = new FileStream(path, FileMode.Open))
            {
                softwareTools = (SoftwareTool[])formatter.Deserialize(fs);
            }

            return softwareTools[id];
        }
    }
}
