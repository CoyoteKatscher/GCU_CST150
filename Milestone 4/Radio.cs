// Brian Potter
// CST-150
// 04/24/2022
// The code is of my own work


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Milestone_3
{
    internal class Radio
    {
        public string serialNumber;
        public string modelNumber;
        public string description;
        public string mdcID;
        public int trunkedID;
        public int conventionalID;
        public bool systemRWC;
        public bool systemTRWC;
        public bool systemMCWS;
        public bool systemNARICS;

        public Radio ()
        {
            serialNumber = " ";
            modelNumber = " ";
            description = " ";
            mdcID = " ";
            trunkedID = 0;
            conventionalID = 0;
            systemRWC = false;
            systemTRWC = false;
            systemMCWS = false;
            systemNARICS = false;
        }

    }
}
