using CarnevaleDatabase.Interface;
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


namespace CarnevaleDatabase
{
    public partial class StartScreen : Form
    {
        public StartScreen()
        {
            InitializeComponent();
            createFaction.Visible = false;
        }

        private void createCharacter_Click(object sender, EventArgs e)
        {
            Thread messageThread = new Thread(LoadingMessage);
            messageThread.Start();
            CreateCharacter creatCharScreen = new CreateCharacter();
            creatCharScreen.Show();            
        }

        private void LoadingMessage()
        {
            MessageBox.Show("Loading, this takes a little while.", "Loading Resource", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void createWeapon_Click(object sender, EventArgs e)
        {
            CreateWeapon createWeaponScreen = new CreateWeapon();
            createWeaponScreen.Show();
        }

        private void editCharacter_Click(object sender, EventArgs e)
        {
            EditCharacter editCharScreen = new EditCharacter();
            editCharScreen.Show();
        }

        private void editWeapon_Click(object sender, EventArgs e)
        {
            Thread waitThread = new Thread(LoadingMessage);
            waitThread.Start();
            EditWeapon editWeaponScreen = new EditWeapon();
            editWeaponScreen.Show();
            
        }

        private void keyWords_Click(object sender, EventArgs e)
        {
            KeyWords keyWordScreen = new KeyWords();
            keyWordScreen.Show();
        }

        private void specialRules_Click(object sender, EventArgs e)
        {
            SpecialRules specRulesScreen = new SpecialRules();
            specRulesScreen.Show();
        }

        private void createFaction_Click(object sender, EventArgs e)
        {
            CreateFaction createFactionScreen = new CreateFaction();
            createFactionScreen.Show();
        }

        private void editFaction_Click(object sender, EventArgs e)
        {
            EditFaction editFactionScreen = new EditFaction();
            editFactionScreen.Show();
        }

        private void equipmentButton_Click(object sender, EventArgs e)
        {
            EditEquipment equipmentScreen = new EditEquipment();
            equipmentScreen.Show();
        }
    }
}
