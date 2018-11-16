using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarnevaleDatabase.Datastore
{
    class Character
    {
        private string name;
        private int charID;
        private int movement;
        private int dexterity;
        private int attack;
        private int protection;
        private int mind;
        private int action;
        private int life;
        private int will;
        private int command;
        private BaseSize baseSize;
        private int ducats;
        private List<Weapon> weapons;
        private List<KeyWord> keyWords;
        private List<SpecialRule> specialRules;
        private List<UniqueRule> uniqueRules;

        public Character()
        {
        }

        public Character(string name, int movement, int dexterity, int attack, int protection, int mind, int action, int life, int will, int command, BaseSize baseSize, int ducats, List<Weapon> weapons, List<KeyWord> keyWords, List<SpecialRule> specialRules, List<UniqueRule> uniqueRules)
        {
            this.Name = name;
            this.Movement = movement;
            this.Dexterity = dexterity;
            this.Attack = attack;
            this.Protection = protection;
            this.Mind = mind;
            this.Action = action;
            this.Life = life;
            this.Will = will;
            this.Command = command;
            this.BaseSize = baseSize;
            this.Ducats = ducats;
            this.Weapons = weapons;
            this.KeyWords = keyWords;
            this.SpecialRules = specialRules;
            this.UniqueRules = uniqueRules;
        }

        public string Name { get => name; set => name = value; }
        public int Movement { get => movement; set => movement = value; }
        public int Dexterity { get => dexterity; set => dexterity = value; }
        public int Attack { get => attack; set => attack = value; }
        public int Protection { get => protection; set => protection = value; }
        public int Mind { get => mind; set => mind = value; }
        public int Action { get => action; set => action = value; }
        public int Life { get => life; set => life = value; }
        public int Will { get => will; set => will = value; }
        public int Command { get => command; set => command = value; }
        public int Ducats { get => ducats; set => ducats = value; }
        internal BaseSize BaseSize { get => baseSize; set => baseSize = value; }
        internal List<Weapon> Weapons { get => weapons; set => weapons = value; }
        internal List<KeyWord> KeyWords { get => keyWords; set => keyWords = value; }
        internal List<SpecialRule> SpecialRules { get => specialRules; set => specialRules = value; }
        internal List<UniqueRule> UniqueRules { get => uniqueRules; set => uniqueRules = value; }
        public int CharID { get => charID; set => charID = value; }

        public void AddWeapon(Weapon weapon)
        {
            this.weapons.Add(weapon);
        }

        public void RemoveWeapon(Weapon weapon)
        {
            this.Weapons.Remove(weapon);
        }

        public void AddKeyWord(KeyWord keyword)
        {
            this.KeyWords.Add(keyword);
        }

        public void RemoveKeyWord(KeyWord keyword)
        {
            this.KeyWords.Remove(keyword);
        }

        public void AddSpecialRules(SpecialRule specRule)
        {
            this.SpecialRules.Add(specRule);
        }

        public void RemoveSpecialRules(SpecialRule specRule)
        {
            this.SpecialRules.Remove(specRule);
        }

        public void AddUniqueRule(UniqueRule uniqueRule)
        {
            this.UniqueRules.Add(uniqueRule);            
        }

        public void RemoveUniqueRule(UniqueRule uniqueRule)
        {
            this.UniqueRules.Remove(uniqueRule);
        }
    }


}
