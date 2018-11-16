using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarnevaleDatabase.Datastore
{
    class UniqueRule
    {
        public UniqueRule()
        {
        }

        public UniqueRule(int uniqueRuleID, string ruleText)
        {
            this.UniqueRuleID = uniqueRuleID;
            this.RuleText = ruleText;
        }

        public int UniqueRuleID { get; set; }
        public string RuleText { get; set; }
    }
}
