using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QA.Interactors
{
    class GetCriteriaMatrix
    {
        public int[] GetItems(string path, int id)
        {
            List<int> criterias = new List<int>();
            using (StreamReader sr = new StreamReader(path))
            {
                while (!sr.EndOfStream)
                {
                    string[] line = sr.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    criterias.Add(int.Parse(line[id]));
                }
            }
            return criterias.ToArray();
        }
    }
}
