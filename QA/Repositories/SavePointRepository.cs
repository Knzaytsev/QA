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
    class SavePointRepository : IGetElement
    {
        public object GetElement(string path, int id = 0)
        {
            XmlSerializer formatter = new XmlSerializer(typeof(SavePoint));
            SavePoint savePoint;

            using (FileStream fs = new FileStream(path, FileMode.Open))
            {
                savePoint = (SavePoint)formatter.Deserialize(fs);
            }

            return savePoint;
        }

        public void SaveElement(SavePoint savePoint, string path)
        {
            XmlSerializer xml = new XmlSerializer(typeof(SavePoint));

            using (TextWriter writer = new StreamWriter(path))
            {
                xml.Serialize(writer, savePoint);
            }
        }
    }
}
