using CarnevaleDatabase.Controllers;
using CarnevaleDatabase.Datastore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarnevaleDatabase.Interface
{
    public partial class EditCharacter : Form
    {
        List<Faction> factionList = new List<Faction>();
        FactionController factionController = new FactionController();
        Faction selectedFaction;
        List<Character> charList = new List<Character>();
        CharacterController charController = new CharacterController();
        Character selectedCharacter;
        List<KeyWord> keyWordsList = new List<KeyWord>();
        KeyWordController keyWordController = new KeyWordController();
        List<SpecialRule> specialRules = new List<SpecialRule>();
        SpecialRulesController specRulesController = new SpecialRulesController();
        List<Weapon> weaponsList = new List<Weapon>();
        WeaponController weaponsController = new WeaponController();
        UniqueRule selectedRule;


        public EditCharacter()
        {
            InitializeComponent();
            UpdateFactionToEditComboBox();
            statPanel.Visible = false;
        }

        private void selectFactionToEditButton_Click(object sender, EventArgs e)
        {
            selectedFaction = (Faction)factionToEditCombo.SelectedItem;
            charList = charController.GetCharacters(selectedFaction);
            PopulateCharSlectCombo();
            
        }

        private void UpdateFactionToEditComboBox()
        {
            factionList = factionController.GetFactions();
            factionToEditCombo.DataSource = factionList;
            factionToEditCombo.DisplayMember = "factionName";
        }

        private void PopulateCharSlectCombo()
        {
            selectCharCombo.DataSource = charList;
            selectCharCombo.DisplayMember = "name";
        }

        private void selectCharButton_Click(object sender, EventArgs e)
        {
            selectedCharacter = (Character)selectCharCombo.SelectedItem;
            statPanel.Visible = true;
            ruleTextBox.Visible = false;            
            saveEditRuleButton.Visible = false;
            saveNewRuleButton.Visible = false;
            charNameBox.Text = selectedCharacter.Name;
            baseSizeBox.Value = selectedCharacter.BaseSize.BaseSize;
            movementBox.Value = selectedCharacter.Movement;
            dexBox.Value = selectedCharacter.Dexterity;
            attBox.Value = selectedCharacter.Attack;
            protBox.Value = selectedCharacter.Protection;
            mindBox.Value = selectedCharacter.Mind;
            lifeBox.Value = selectedCharacter.Life;
            willBox.Value = selectedCharacter.Will;
            commandBox.Value = selectedCharacter.Command;
            ducatsBox.Value = selectedCharacter.Ducats;
            charTypeBox.Text = selectedCharacter.CharType;
            isUniqueCheckBox.Checked = selectedCharacter.IsUnique;
            factionBox.DataSource = factionList;
            factionBox.DisplayMember = "factionName";
            factionBox.SelectedItem = selectedCharacter.Faction;
            imageBox.Text = selectedCharacter.Image;
            
            keyWordsList = keyWordController.getKeyWords();
            keyWordsCombo.DataSource = keyWordsList;
            keyWordsCombo.DisplayMember = "keyWordText";
            keyWordsListBox.DataSource = selectedCharacter.KeyWords;
            keyWordsListBox.DisplayMember = "keyWordText";

            specialRules = specRulesController.getSpecialRules();
            specRuleCombo.DataSource = specialRules;
            specRuleCombo.DisplayMember = "rule";
            specRuleListBox.DataSource = selectedCharacter.SpecialRules;
            specRuleListBox.DisplayMember = "fullString";

            weaponsList = weaponsController.GetWeapons();
            weaponCombo.DataSource = weaponsList;
            weaponCombo.DisplayMember = "WeaponName";
            weaponListBox.DataSource = selectedCharacter.Weapons;
            weaponListBox.DisplayMember = "WeaponName";

            uniqueRuleBox.DataSource = selectedCharacter.UniqueRules;
            uniqueRuleBox.DisplayMember = "RuleText";

        }

        private void testURLButton_Click(object sender, EventArgs e)
        {
            imgTestBrowser.Navigate(imageBox.Text);
        }

        private void deleteKeyWordButton_Click(object sender, EventArgs e)
        {
            KeyWord keywordToDelete = (KeyWord)keyWordsListBox.SelectedItem;
                selectedCharacter.RemoveKeyWord(keywordToDelete);
            keyWordsListBox.DataSource = null;
            keyWordsListBox.DataSource = selectedCharacter.KeyWords;
            keyWordsListBox.DisplayMember = "keyWordText";
        }

        private void addKeyWord_Click(object sender, EventArgs e)
        {
            KeyWord newKeyWord = (KeyWord)keyWordsCombo.SelectedItem;
            selectedCharacter.AddKeyWord(newKeyWord);
            keyWordsListBox.DataSource = null;
            keyWordsListBox.DataSource = selectedCharacter.KeyWords;
            keyWordsListBox.DisplayMember = "keyWordText";

        }

        private void removeSpecRuleButton_Click(object sender, EventArgs e)
        {
            SpecialRulesInstance ruleToDelete = (SpecialRulesInstance)specRuleListBox.SelectedItem;
            selectedCharacter.RemoveSpecialRule(ruleToDelete);
            specRuleListBox.DataSource = null;
            specRuleListBox.DataSource = selectedCharacter.SpecialRules;
            specRuleListBox.DisplayMember = "fullString";
        }

        private void updateSpecRuleNumber_Click(object sender, EventArgs e)
        {
            SpecialRulesInstance ruleAmountToEdit = (SpecialRulesInstance)specRuleListBox.SelectedItem;
            ruleAmountToEdit.Amount = (int)specRuleAmountBox.Value;
            specRuleListBox.DataSource = null;
            specRuleListBox.DataSource = selectedCharacter.SpecialRules;
            specRuleListBox.DisplayMember = "fullString";
        }

        private void addNewRuleButton_Click(object sender, EventArgs e)
        {
            SpecialRulesInstance ruleToAdd = new SpecialRulesInstance();
            SpecialRule ruleText = (SpecialRule)specRuleCombo.SelectedItem;
            ruleToAdd.Rule = ruleText.Rule;
            ruleToAdd.RuleID = ruleText.RuleID;
            ruleToAdd.Amount = (int)specRuleAmountBox.Value;
            selectedCharacter.AddSpecialRule(ruleToAdd);
            specRuleListBox.DataSource = null;
            specRuleListBox.DataSource = selectedCharacter.SpecialRules;
            specRuleListBox.DisplayMember = "fullString";
        }

        private void removeWeapon_Click(object sender, EventArgs e)
        {
            Weapon weaponToDelete = (Weapon)weaponListBox.SelectedItem;
            selectedCharacter.RemoveWeapon(weaponToDelete);
            weaponListBox.DataSource = null;
            weaponListBox.DataSource = selectedCharacter.Weapons;
            weaponListBox.DisplayMember = "WeaponName";
        }

        private void addWeapon_Click(object sender, EventArgs e)
        {
            Weapon weaponToAdd = (Weapon)weaponCombo.SelectedItem;
            selectedCharacter.AddWeapon(weaponToAdd);
            weaponListBox.DataSource = null;
            weaponListBox.DataSource = selectedCharacter.Weapons;
            weaponListBox.DisplayMember = "WeaponName";
        }

        private void deleteUniqueRuleButton_Click(object sender, EventArgs e)
        {
            UniqueRule ruleToDelete = (UniqueRule)uniqueRuleBox.SelectedItem;
            selectedCharacter.RemoveUniqueRule(ruleToDelete);
            charController.RemoveUniqueRule(ruleToDelete);
            uniqueRuleBox.DataSource = null;
            uniqueRuleBox.DataSource = selectedCharacter.UniqueRules;
            uniqueRuleBox.DisplayMember = "RuleText";

        }

        private void editRuleButton_Click(object sender, EventArgs e)
        {
            selectedRule = (UniqueRule)uniqueRuleBox.SelectedItem;
            ruleTextBox.Visible = true;
            saveEditRuleButton.Visible = true;
            ruleTextBox.Text = selectedRule.RuleText;

        }

        private void addUniqueRuleButton_Click(object sender, EventArgs e)
        {
            ruleTextBox.Visible = true;
            saveNewRuleButton.Visible = true;
            ruleTextBox.Clear();
        }

        private void saveEditRuleButton_Click(object sender, EventArgs e)
        {
            selectedRule.RuleText = ruleTextBox.Text;
            charController.UpdateUniqueRules(selectedRule);
            uniqueRuleBox.DataSource = null;
            uniqueRuleBox.DataSource = selectedCharacter.UniqueRules;
            uniqueRuleBox.DisplayMember = "RuleText";
            ruleTextBox.Visible = false;
            saveEditRuleButton.Visible = false;

        }

        private void saveNewRuleButton_Click(object sender, EventArgs e)
        {

            UniqueRule newRule = new UniqueRule();
            newRule.RuleText = ruleTextBox.Text;            
            charController.InsertUniqueRule(newRule, selectedCharacter.CharID);
            newRule.UniqueRuleID = charController.GetUniqueRuleID(newRule, selectedCharacter.CharID);
            selectedCharacter.AddUniqueRule(newRule);            
            uniqueRuleBox.DataSource = null;
            uniqueRuleBox.DataSource = selectedCharacter.UniqueRules;
            uniqueRuleBox.DisplayMember = "RuleText";
            ruleTextBox.Visible = false;
            saveNewRuleButton.Visible = false;

        }
    }
}
