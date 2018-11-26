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

        public SpecialRule(int ruleID, string rule, int amount)
        {
            this.RuleID = ruleID;
            this.Rule = rule;
            this.Amount = amount;
        }

        public int RuleID { get; set; }
        public string Rule { get; set; }
        public int Amount { get; set; }
    }
}
