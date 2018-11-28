using CarnevaleDatabase.Controllers;
using CarnevaleDatabase.Datastore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarnevaleDatabase.Interface
{
    public partial class CreateCharacter : Form
    {
        FactionController factionController = new FactionController();
        List<Faction> factionList = new List<Faction>();

        CharacterController charController = new CharacterController();
        Character newCharacter = new Character();

        KeyWordController keyWordController = new KeyWordController();
        List<KeyWord> keyWords = new List<KeyWord>();

        SpecialRulesController specRuleController = new SpecialRulesController();
        List<SpecialRule> specRulesList = new List<SpecialRule>();

        WeaponController weaponController = new WeaponController();
        List<Weapon> weaponsList = new List<Weapon>();

        


        public CreateCharacter()
        {

            InitializeComponent();
            EditPanel.Visible = true;

            SetKeyWordsList();
            SetFactionList();
            SetSpecRulesList();
            SetWeaponsList();

            uniqueRuleTextBox.Visible = false;
            saveNewRule.Visible = false;
            saveEditedRule.Visible = false;
        }



        private void SetKeyWordsList()
        {
            keyWords = keyWordController.getKeyWords();
            keyWordCombo.DataSource = keyWords;
            keyWordCombo.DisplayMember = "keyWordText";
        }

        private void SetFactionList()
        {
            factionList = factionController.GetFactions();
            factionCombo.DataSource = factionList;
            factionCombo.DisplayMember = "factionName";

        }

        private void SetSpecRulesList()
        {
            specRulesList = specRuleController.getSpecialRules();
            specRuleCombo.DataSource = specRulesList;
            specRuleCombo.DisplayMember = "rule";
        }

        private void SetWeaponsList()
        {
            weaponsList = weaponController.GetWeapons();
            weaponCombo.DataSource = weaponsList;
            weaponCombo.DisplayMember = "weaponName";
        }

        private void FactionCombo_DataSourceChanged(object sender, EventArgs e)
        {
            factionCombo.DataSource = null;
            factionCombo.DataSource = factionList;
            factionCombo.DisplayMember = "factionName";
        }

        private void DeleteKeyWordButton_Click(object sender, EventArgs e)
        {
            try
            {
                KeyWord removekeyWord = (KeyWord)keyWordsListBox.SelectedItem;
                newCharacter.RemoveKeyWord(removekeyWord);
                keyWordsListBox.DataSource = null;
                keyWordsListBox.DataSource = newCharacter.KeyWords;
                keyWordsListBox.DisplayMember = "keyWordText";
            }

            catch (NullReferenceException ex)
            {
                MessageBox.Show("No Key Word selected to Delete", "No Key Words", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddKeyWordButton_Click(object sender, EventArgs e)
        {
            KeyWord newKeyWord = (KeyWord)keyWordCombo.SelectedItem;
            newCharacter.AddKeyWord(newKeyWord);
            keyWordsListBox.DataSource = null;
            keyWordsListBox.DataSource = newCharacter.KeyWords;
            keyWordsListBox.DisplayMember = "keyWordText";
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            SpecialRulesInstance specRuleToRemove = (SpecialRulesInstance)specRulesListBox.SelectedItem;
            newCharacter.RemoveSpecialRule(specRuleToRemove);
            specRulesListBox.DataSource = null;
            specRulesListBox.DataSource = newCharacter.SpecialRules;
            specRulesListBox.DisplayMember = "fullString";
        }

        private void AddSpecRuleButton_Click(object sender, EventArgs e)
        {
            SpecialRulesInstance newSpecRule = new SpecialRulesInstance();
            SpecialRule basicNewRule = (SpecialRule)specRuleCombo.SelectedItem;
            newSpecRule.RuleID = basicNewRule.RuleID;
            newSpecRule.Rule = basicNewRule.Rule;
            newSpecRule.Amount = (int)specRuleAmountCounter.Value;
            newCharacter.AddSpecialRule(newSpecRule);
            specRulesListBox.DataSource = null;
            specRulesListBox.DataSource = newCharacter.SpecialRules;
            specRulesListBox.DisplayMember = "fullString";
        }

        private void ChangeAmountButton_Click(object sender, EventArgs e)
        {
            SpecialRulesInstance ruleEdit = (SpecialRulesInstance)specRulesListBox.SelectedItem;
            ruleEdit.Amount = (int)specRuleAmountCounter.Value;
            specRulesListBox.DataSource = null;
            specRulesListBox.DataSource = newCharacter.SpecialRules;
            specRulesListBox.DisplayMember = "fullString";
        }

        

        private void AddWeaponButton_Click(object sender, EventArgs e)
        {
            Weapon newWeapon = (Weapon)weaponCombo.SelectedItem;
            newCharacter.AddWeapon(newWeapon);
            weaponsListBox.DataSource = null;
            weaponsListBox.DataSource = newCharacter.Weapons;
            weaponsListBox.DisplayMember = "weaponName";
        }

        private void DeleteWeaponButton_Click(object sender, EventArgs e)
        {
            Weapon deleteWeapon = (Weapon)weaponsListBox.SelectedItem;
            newCharacter.RemoveWeapon(deleteWeapon);
            weaponsListBox.DataSource = null;
            weaponsListBox.DataSource = newCharacter.Weapons;
            weaponsListBox.DisplayMember = "weaponName";
        }

        private void DeleteUniqueRuleButton_Click(object sender, EventArgs e)
        {
            UniqueRule deleteRule = (UniqueRule)uniqueRuleBox.SelectedItem;
            newCharacter.RemoveUniqueRule(deleteRule);
            uniqueRuleBox.DataSource = null;
            uniqueRuleBox.DataSource = newCharacter.UniqueRules;
            uniqueRuleBox.DisplayMember = "ruleText";
        }

        private void EditUniqueRuleButton_Click(object sender, EventArgs e)
        {
            uniqueRuleTextBox.Visible = true;
            saveNewRule.Visible = false;
            saveEditedRule.Visible = true;
            UniqueRule editRule = (UniqueRule)uniqueRuleBox.SelectedItem;
            uniqueRuleTextBox.Text = editRule.RuleText;
        }

        private void AddUniqueRuleButton_Click(object sender, EventArgs e)
        {
            uniqueRuleTextBox.Visible = true;
            saveNewRule.Visible = true;
            saveEditedRule.Visible = false;
            uniqueRuleTextBox.Text = "";
        }

        private void SaveEditedRule_Click(object sender, EventArgs e)
        {
            UniqueRule editRule = (UniqueRule)uniqueRuleBox.SelectedItem;
            editRule.RuleText = uniqueRuleTextBox.Text;
            uniqueRuleTextBox.Visible = false;
            saveNewRule.Visible = false;
            saveEditedRule.Visible = false;
            uniqueRuleBox.DataSource = null;
            uniqueRuleBox.DataSource = newCharacter.UniqueRules;
            uniqueRuleBox.DisplayMember = "ruleText";

        }

        private void SaveNewRule_Click(object sender, EventArgs e)
        {
            UniqueRule newRule = new UniqueRule
            {
                RuleText = uniqueRuleTextBox.Text
            };
            newCharacter.AddUniqueRule(newRule);
            uniqueRuleTextBox.Visible = false;
            saveNewRule.Visible = false;
            saveEditedRule.Visible = false;
            uniqueRuleBox.DataSource = null;
            uniqueRuleBox.DataSource = newCharacter.UniqueRules;
            uniqueRuleBox.DisplayMember = "ruleText";
        }

        private void SaveCharacterButton_Click(object sender, EventArgs e)
        {
            newCharacter.Name = nameText.Text;
            newCharacter.BaseSize.BaseSize = (int)baseSizeCounter.Value;
            switch (baseSizeCounter.Value)
            {
                case 30:
                    newCharacter.BaseSize.BaseID = 1;
                    break;

                case 40:
                    newCharacter.BaseSize.BaseID = 2;
                    break;

                case 50:
                    newCharacter.BaseSize.BaseID = 3;
                    break;

                case 60:
                    newCharacter.BaseSize.BaseID = 4;
                    break;
            }
            newCharacter.Movement = (int)movementCounter.Value;
            newCharacter.Dexterity = (int)dexterityCounter.Value;
            newCharacter.Attack = (int)attackCounter.Value;
            newCharacter.Protection = (int)protectionCounter.Value;
            newCharacter.Mind = (int)mindCounter.Value;
            newCharacter.Action = (int)actionCounter.Value;
            newCharacter.Life = (int)lifeCounter.Value;
            newCharacter.Will = (int)willCounter.Value;
            newCharacter.Command = (int)commandCounter.Value;
            newCharacter.Ducats = (int)ducatsCounter.Value;
            newCharacter.CharType = charTypeCombo.Text;
            newCharacter.IsUnique = uniqueCheckBox.Checked;
            newCharacter.Faction = (Faction)factionCombo.SelectedItem;
            newCharacter.Image = imageText.Text;

            charController.InsertNewCharacter(newCharacter);
            newCharacter.CharID = charController.GetCharacterID(newCharacter);
            foreach (UniqueRule rule in newCharacter.UniqueRules)
            {
                charController.InsertUniqueRule(rule, newCharacter.CharID);
            }
            foreach (SpecialRulesInstance rule in newCharacter.SpecialRules)
            {
                charController.InsertSpecialRuleInstance(rule, newCharacter.CharID);
            }
            foreach (KeyWord keyWord in newCharacter.KeyWords)
            {
                charController.InsertKeyWordInstance(keyWord, newCharacter.CharID);
            }
            foreach (Weapon weapon in newCharacter.Weapons)
            {
                charController.InsertWeaponInstance(weapon, newCharacter.CharID);
            }

            CreateCharacter newScreen = new CreateCharacter();
            Thread reloadMessageThread = new Thread(WaitMessage);
            reloadMessageThread.Start();
            newScreen.Show();
            reloadMessageThread.Abort();

            this.Close();


        }

        private void WaitMessage()
        {
            MessageBox.Show("Please Wait while I reload the Screen", "Refreshing", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
