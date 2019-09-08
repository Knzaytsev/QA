using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QA.Classes;
using QA.Singletons;

namespace QA.Interactors
{
    class EditSavePoint
    {
        public void LoadSavePoint(SavePoint savePoint)
        {
            if (savePoint != null)
            {
                SavePointSingleton.GetInstance(savePoint);
                DataSingleton.GetInstance(savePoint.IdPhase, savePoint.IdSoftwareTool);
            }
        }

        public void UnloadSavePoint(string path, SavePoint savePoint)
        {

        }
    }
}
