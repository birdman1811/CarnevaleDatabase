using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarnevaleDatabase.Datastore
{
    class KeyWord
    {
        public KeyWord()
        {
        }

        public KeyWord(int keyWordID, string keyWordText)
        {
            this.KeyWordID = keyWordID;
            this.KeyWordText = keyWordText;
        }

        public int KeyWordID { get; set; }
        public string KeyWordText { get; set; }
    }
}
