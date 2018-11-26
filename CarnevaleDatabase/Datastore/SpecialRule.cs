using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarnevaleDatabase.Datastore
{
    class SpecialRule
    {
        public SpecialRule()
        {
        }

        public SpecialRule(int ruleID, string rule)
        {
            this.RuleID = ruleID;
            this.Rule = rule;
           
        }

        public int RuleID { get; set; }
        public string Rule { get; set; }
        
    }
}
