using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using QA.Classes;

namespace QA.Repositories
{
    class CriteriasRepository : IGetAllElements
    {
        public object GetElements(string path)
        {
            XmlSerializer formatter = new XmlSerializer(typeof(Criteria[]));
            Criteria[] criterias;

            using (FileStream fs = new FileStream(path, FileMode.Open))
            {
                criterias = (Criteria[])formatter.Deserialize(fs);
            }

            return criterias;
        }
    }
}
