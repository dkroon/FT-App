using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace FTAppWM6
{
    class RecordManager
    {
        EntityRecord[] erArray = null;
        SortedList erSL = new SortedList();
        public RecordManager(EntityRecord[] entityRecordArray)
        {
            erArray = entityRecordArray;
            init();

        }

        private void init()
        {
            for (int i = 0; i < erArray.Length; i++)
            {
                EntityRecord er = erArray[i];
                erSL.Add(i, er);

            }
        }


        public int getNextEntityRecord()
        {

            return 1;
        }
    }
}
