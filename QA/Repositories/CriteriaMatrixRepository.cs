using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QA.Repositories
{
    class CriteriaMatrixRepository : IGetElement
    {
        public object GetElement(string path, int id)
        {
            List<int> column = new List<int>();
            using (StreamReader sr = new StreamReader(path))
            {
                while (!sr.EndOfStream)
                {
                    string[] line = sr.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    column.Add(int.Parse(line[id]));
                }
            }

            return column.ToArray();
        }
    }
}
