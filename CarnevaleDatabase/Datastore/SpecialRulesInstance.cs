using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarnevaleDatabase.Datastore
{
    class SpecialRulesInstance : SpecialRule
    {
        private int amount;

        public SpecialRulesInstance()
        {
        }

        public SpecialRulesInstance(int amount)
        {
            this.Amount = amount;
            
        }

        public SpecialRulesInstance(int ruleId, string rule, int amount)
        {
            this.RuleID = ruleId;
            this.Rule = rule;
            this.Amount = amount;
        }

        public int Amount { get => amount; set => amount = value; }
    }
}
