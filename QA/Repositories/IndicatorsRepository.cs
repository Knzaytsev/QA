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
    class IndicatorsRepository : IGetAllElements
    {
        public object GetElements(string path)
        {
            XmlSerializer formatter = new XmlSerializer(typeof(Indicator[]));
            Indicator[] indicators;

            using (FileStream fs = new FileStream(path, FileMode.Open))
            {
                indicators = (Indicator[])formatter.Deserialize(fs);
            }

            return indicators;
        }
    }
}
