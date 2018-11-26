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
    }
}
