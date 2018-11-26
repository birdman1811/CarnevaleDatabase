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

        public EditCharacter()
        {
            InitializeComponent();
            UpdateFactionToEditComboBox();
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
        }
    }
}
