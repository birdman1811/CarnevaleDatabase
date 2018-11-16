using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarnevaleDatabase.Datastore
{
    class WeaponAbility
    {
        public WeaponAbility()
        {
        }

        public WeaponAbility(string ability)
        {
            this.Ability = ability;
        }

        public int WeaponAbilityID { get; set; }
        public string Ability { get; set; }
    }
}
