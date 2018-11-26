using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarnevaleDatabase.Datastore
{
    class Weapon
    {
        public Weapon()
        {
        }

        public Weapon(string weaponName, int range, int evasion, int damage, int penetration)
        {
            this.WeaponName = weaponName;
            this.Range = range;
            this.Evasion = evasion;
            this.Damage = damage;
            this.Penetration = penetration;
        }

        public int WeaponID { get; set; }
        public string WeaponName { get; set; }
        public int Range { get; set; }
        public int Evasion { get; set; }
        public int Damage { get; set; }
        public int Penetration { get; set; }

    }
}
