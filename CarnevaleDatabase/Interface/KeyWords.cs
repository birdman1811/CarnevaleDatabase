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
    public partial class KeyWords : Form
    {

        KeyWordController keyWordController = new KeyWordController();
        List<KeyWord> keyWordsList = new List<KeyWord>();
        KeyWord selectedKeyWord;

        public KeyWords()
        {
            InitializeComponent();
            enterKeyWordLabel.Visible = false;
            newKeyWordText.Visible = false;
            saveNewKeyWordButton.Visible = false;
            selectKeyWordLabel.Visible = false;
            keyWordCombo.Visible = false;
            selectButton.Visible = false;
            keyWordText.Visible = false;
            saveEditKeyWordButton.Visible = false;

        }

        private void saveNewKeyWordButton_Click(object sender, EventArgs e)
        {
            enterKeyWordLabel.Visible = true;
            newKeyWordText.Visible = true;
            saveNewKeyWordButton.Visible = true;
            selectKeyWordLabel.Visible = false;
            keyWordCombo.Visible = false;
            selectButton.Visible = false;
            keyWordText.Visible = false;
            saveEditKeyWordButton.Visible = false;
            KeyWord newKeyWord = new KeyWord();
            newKeyWord.KeyWordText = newKeyWordText.Text;
            keyWordController.InsertKeyWord(newKeyWord);
            newKeyWordText.Clear();
        }

        private void editKeyWordButton_Click(object sender, EventArgs e)
        {
            enterKeyWordLabel.Visible = false;
            newKeyWordText.Visible = false;
            saveNewKeyWordButton.Visible = false;
            selectKeyWordLabel.Visible = true;
            keyWordCombo.Visible = true;
            selectButton.Visible = true;
            keyWordText.Visible = false;
            saveEditKeyWordButton.Visible = false;
            populateComboBox();
        }

        private void populateComboBox()
        {
            keyWordsList = keyWordController.getKeyWords();
            keyWordCombo.DataSource = keyWordsList;
            keyWordCombo.DisplayMember = "KeyWordText";
        }

        private void selectButton_Click(object sender, EventArgs e)
        {
            enterKeyWordLabel.Visible = false;
            newKeyWordText.Visible = false;
            saveNewKeyWordButton.Visible = false;
            selectKeyWordLabel.Visible = true;
            keyWordCombo.Visible = true;
            selectButton.Visible = true;
            keyWordText.Visible = true;
            saveEditKeyWordButton.Visible = true;
            selectedKeyWord = (KeyWord)keyWordCombo.SelectedItem;
            keyWordText.Text = selectedKeyWord.KeyWordText;
        }

        private void saveEditKeyWordButton_Click(object sender, EventArgs e)
        {
            selectedKeyWord.KeyWordText = keyWordText.Text;
            keyWordController.UpdateKeyWords(selectedKeyWord);
            keyWordText.Clear();
            selectKeyWordLabel.Visible = false;
            keyWordCombo.Visible = false;
            selectButton.Visible = false;
            keyWordText.Visible = false;
            saveEditKeyWordButton.Visible = false;
        }

        private void createKeyWordButton_Click(object sender, EventArgs e)
        {
            enterKeyWordLabel.Visible = true;
            newKeyWordText.Visible = true;
            saveNewKeyWordButton.Visible = true;
            selectKeyWordLabel.Visible = false;
            keyWordCombo.Visible = false;
            selectButton.Visible = false;
            keyWordText.Visible = false;
            saveEditKeyWordButton.Visible = false;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
