using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarnevaleDatabase.Datastore
{
    class Base
    {
        public Base()
        {
        }

        public Base(int baseID, int baseSize)
        {
            this.BaseID = baseID;
            this.BaseSize = baseSize;
        }

        public int BaseID { get; set; }
        public int BaseSize { get; set; }
    }


}
