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
    public partial class CreateWeapon : Form
    {
        WeaponController weaponController = new WeaponController();
        List<WeaponAbility> abilityList = new List<WeaponAbility>();
        Weapon newWeapon = new Weapon();

        public CreateWeapon()
        {
            InitializeComponent();
            editAbilitiesPanel.Visible = false;
            abilityTextBox.Visible = false;
            saveEditedAbilityButton.Visible = false;
            savNewAbilityButton.Visible = false;
            abilityList = weaponController.GetAllWeaponAbilities();
            abilityCombo.DataSource = abilityList;
            abilityCombo.DisplayMember = "ability";
            editAbilitiesListBox.DataSource = abilityList;
            editAbilitiesListBox.DisplayMember = "ability";
            
        }

        private void addWeaponAbility_Click(object sender, EventArgs e)
        {
            WeaponAbility newAbility = (WeaponAbility)abilityCombo.SelectedItem;
            newWeapon.AddWeaponAbility(newAbility);
            abilityBox.DataSource = null;
            abilityBox.DataSource = newWeapon.WeaponAbilities;
            abilityBox.DisplayMember = "ability";
        }

        private void RemoveAbilityButton_Click(object sender, EventArgs e)
        {
            WeaponAbility removeAbility = (WeaponAbility)abilityBox.SelectedItem;
            newWeapon.RemoveWeaponAbility(removeAbility);
            abilityBox.DataSource = null;
            abilityBox.DataSource = newWeapon.WeaponAbilities;
            abilityBox.DisplayMember = "ability";
        }

        private void SaveWeaponButton_Click(object sender, EventArgs e)
        {
            newWeapon.WeaponName = nameTextBox.Text;
            newWeapon.Range = (int)rangeCounter.Value;
            newWeapon.Evasion = (int)evasionCounter.Value;
            newWeapon.Damage = (int)damageCounter.Value;
            newWeapon.Penetration = (int)penetrationCounter.Value;
            weaponController.InsertNewWeapon(newWeapon);
            newWeapon.WeaponID = weaponController.GetWeaponID(newWeapon);
            foreach (WeaponAbility ability in newWeapon.WeaponAbilities)
            {
                weaponController.InsertWeaponAbilityInstance(newWeapon, ability);
            }
            CreateWeapon newScreen = new CreateWeapon();
            newScreen.Visible = true;
            this.Close();
        }

        private void editAbilitiesButton_Click(object sender, EventArgs e)
        {
            editAbilitiesPanel.Visible = true;
        }

        private void editAbilityButton_Click(object sender, EventArgs e)
        {
            abilityTextBox.Visible = true;
            saveEditedAbilityButton.Visible = true;
            savNewAbilityButton.Visible = false;
            WeaponAbility editAbility = (WeaponAbility)editAbilitiesListBox.SelectedItem;
            abilityTextBox.Text = editAbility.Ability;
            editAbilitiesListBox.Enabled = false;
        }

        private void saveEditedAbilityButton_Click(object sender, EventArgs e)
        {
            WeaponAbility editAbility = (WeaponAbility)editAbilitiesListBox.SelectedItem;
            editAbility.Ability = abilityTextBox.Text;
            weaponController.UpdateWeaponAbility(editAbility);
            abilityTextBox.Visible = false;
            saveEditedAbilityButton.Visible = false;
            savNewAbilityButton.Visible = false;
            abilityCombo.DataSource = null;
            abilityCombo.DataSource = abilityList;
            abilityCombo.DisplayMember = "ability";
            editAbilitiesListBox.DataSource = null;
            editAbilitiesListBox.DataSource = abilityList;
            editAbilitiesListBox.DisplayMember = "ability";
            editAbilitiesListBox.Enabled = true;
        }

        private void savNewAbilityButton_Click(object sender, EventArgs e)
        {
            WeaponAbility newAbility = new WeaponAbility();
            newAbility.Ability = abilityTextBox.Text;
            weaponController.InsertNewWeaponAbility(newAbility);
            newAbility.WeaponAbilityID = weaponController.GetWeaponAbilityID(newAbility.Ability);
            abilityList.Add(newAbility);
            abilityTextBox.Visible = false;
            saveEditedAbilityButton.Visible = false;
            savNewAbilityButton.Visible = false;
            abilityCombo.DataSource = null;
            abilityCombo.DataSource = abilityList;
            abilityCombo.DisplayMember = "ability";
            editAbilitiesListBox.DataSource = null;
            editAbilitiesListBox.DataSource = abilityList;
            editAbilitiesListBox.DisplayMember = "ability";
            editAbilitiesListBox.Enabled = true;
        }

        private void newAbilityButton_Click(object sender, EventArgs e)
        {
            abilityTextBox.Visible = true;
            saveEditedAbilityButton.Visible = false;
            savNewAbilityButton.Visible = true;
        }
    }
}
