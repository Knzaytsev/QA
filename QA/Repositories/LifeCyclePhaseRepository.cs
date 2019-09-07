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
    class LifeCyclePhaseRepository : IGetElement
    {
        public object GetElement(string path, int id)
        {
            XmlSerializer formatter = new XmlSerializer(typeof(Phase[]));
            Phase[] phases;

            using (FileStream fs = new FileStream(path, FileMode.Open))
            {
                phases = (Phase[])formatter.Deserialize(fs);
            }

            return phases[id];
        }
    }
}
