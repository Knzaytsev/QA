using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QA
{
    public class DataSingleton
    {
        private static DataSingleton instance;

        public int IdPhase { get; private set; }

        public List<int> Priorities { get; private set; }

        private DataSingleton()
        {
            if (Priorities is null)
            {
                Priorities = new List<int>();
            }
        }

        private void SetPhase(int idPhase)
        {
            IdPhase = idPhase;
        }

        private void SetPriorities(int[] priorities)
        {
            Priorities = priorities.ToList();
        }

        public static DataSingleton GetInstance(int idPhase)
        {
            if (instance is null)
            {
                instance = new DataSingleton();
            }
            instance.SetPhase(idPhase);
            return instance;
        }

        public static DataSingleton GetInstance(int[] priorities)
        {
            if (instance is null)
            {
                instance = new DataSingleton();
            }
            instance.SetPriorities(priorities);
            return instance;
        }

        public static DataSingleton GetInstance()
        {
            return instance ?? (instance = new DataSingleton());
        }
    }
}
