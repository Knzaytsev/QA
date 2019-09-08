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
    public class MetricRepository : IGetAllElements
    {
        public object GetElements(string path)
        {
            XmlSerializer formatter = new XmlSerializer(typeof(Metric[]));
            Metric[] metrics;

            using (FileStream fs = new FileStream(path, FileMode.Open))
            {
                metrics = (Metric[])formatter.Deserialize(fs);
            }

            return metrics;
        }
    }
}
