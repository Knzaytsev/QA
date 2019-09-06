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
    class GetSoftwareTools : IGetItems
    {
        public object GetItems(string path)
        {
            XmlSerializer formatter = new XmlSerializer(typeof(SoftwareTool[]));
            SoftwareTool[] softwareTools;
            using (FileStream fs = new FileStream(path, FileMode.Open))
            {
                softwareTools = (SoftwareTool[])formatter.Deserialize(fs);
            }
            return softwareTools;
        }
    }
}
