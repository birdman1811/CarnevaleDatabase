using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarnevaleDatabase.Datastore
{
    class Character
    {
        public Character()
        {
        }

        public Character(int charID, string name, int movement, int dexterity, int attack, int protection, int mind, int action, int life, int will,
            int command, Base baseSize, int ducats, List<Weapon> weapons, List<KeyWord> keyWords, List<SpecialRule> specialRules,
            List<UniqueRule> uniqueRules, bool isUnique, string charType, Faction faction, string image)
        {
            this.CharID = charID;
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
            this.IsUnique = isUnique;
            this.CharType = charType;
            this.Faction = Faction;
            this.Image = image;
        }
                
        public string Name { get; set; }
        public int Movement { get; set; }
        public int Dexterity { get; set; }
        public int Attack { get; set; }
        public int Protection { get; set; }
        public int Mind { get; set; }
        public int Action { get; set; }
        public int Life { get; set; }
        public int Will { get; set; }
        public int Command { get; set; }
        public int Ducats { get; set; }
        internal Base BaseSize { get; set; }
        internal List<Weapon> Weapons { get; set; }
        internal List<KeyWord> KeyWords { get; set; }
        internal List<SpecialRule> SpecialRules { get; set; }
        internal List<UniqueRule> UniqueRules { get; set; }
        public int CharID { get; set; }
        public bool IsUnique { get; set; }
        public string CharType { get; set; }
        public Faction Faction { get; set; }
        public string Image { get; set; }

        public void AddWeapon(Weapon weapon)
        {
            this.Weapons.Add(weapon);
        }

        public void RemoveWeapon(Weapon weapon)
        {
            this.Weapons.Remove(weapon);
        }

        public void SetWeapons(List<Weapon> weapons)
        {
            this.Weapons = weapons;
        }

        public void AddKeyWord(KeyWord keyword)
        {
            this.KeyWords.Add(keyword);
        }

        public void RemoveKeyWord(KeyWord keyword)
        {
            this.KeyWords.Remove(keyword);
        }

        public void SetKeyWords(List<KeyWord> keywords)
        {
            this.KeyWords = keywords;
        }

        public void AddSpecialRules(SpecialRule specRule)
        {
            this.SpecialRules.Add(specRule);
        }

        public void RemoveSpecialRules(SpecialRule specRule)
        {
            this.SpecialRules.Remove(specRule);
        }

        public void SetSpecialRules(List<SpecialRule> specRules)
        {
            this.SpecialRules = specRules;
        }

        public void AddUniqueRule(UniqueRule uniqueRule)
        {
            this.UniqueRules.Add(uniqueRule);            
        }

        public void RemoveUniqueRule(UniqueRule uniqueRule)
        {
            this.UniqueRules.Remove(uniqueRule);
        }

        public void SetUniqueRules(List<UniqueRule> uniqueRules)
        {
            this.UniqueRules = uniqueRules;
        }
    }


}
