using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QA.Classes;

namespace QA.Singletons
{
    class SavePointSingleton
    {
        private static SavePointSingleton instance;

        public SavePoint SavePoint { get; private set; }

        private SavePointSingleton()
        {
            SavePoint = new SavePoint();
        }

        private void SetIndicators(SavePoint savePoint)
        {
            SavePoint = savePoint;
        }

        public static SavePointSingleton GetInstance(SavePoint savePoint)
        {
            if (instance is null)
            {
                instance = new SavePointSingleton();
            }
            instance.SetIndicators(savePoint);
            return instance;
        }

        public static SavePointSingleton GetInstance()
        {
            return instance ?? (instance = new SavePointSingleton());
        }
    }
}
