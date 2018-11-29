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
    public partial class EditWeapon : Form
    {
        WeaponController weaponController = new WeaponController();
        Weapon editWeapon = new Weapon();
        List<Weapon> weaponList = new List<Weapon>();
        List<WeaponAbility> abilityList = new List<WeaponAbility>();
        
        public EditWeapon()
        {
            InitializeComponent();
            editWeaponPanel.Visible = false;
            weaponList = weaponController.GetWeapons();
            weaponCombo.DataSource = weaponList;
            weaponCombo.DisplayMember = "weaponName";
            abilityList = weaponController.GetAllWeaponAbilities();            
            abilitiesCombo.DataSource = abilityList;
            abilitiesCombo.DisplayMember = "ability";
        }

        private void selectWeaponButton_Click(object sender, EventArgs e)
        {
            editWeapon = (Weapon)weaponCombo.SelectedItem;
            editWeaponPanel.Visible = true;
            nameText.Text = editWeapon.WeaponName;
            rangeCounter.Value = editWeapon.Range;
            evasionCounter.Value = editWeapon.Evasion;
            damageCounter.Value = editWeapon.Damage;
            penetrationCounter.Value = editWeapon.Penetration;
            abilitiesListBox.DataSource = editWeapon.WeaponAbilities;
            abilitiesListBox.DisplayMember = "ability";
        }

        private void rangeCounter_ValueChanged(object sender, EventArgs e)
        {
            editWeapon.Range = (int)rangeCounter.Value;
        }

        private void evasionCounter_ValueChanged(object sender, EventArgs e)
        {
            editWeapon.Evasion = (int)evasionCounter.Value;
        }

        private void damageCounter_ValueChanged(object sender, EventArgs e)
        {
            editWeapon.Damage = (int)damageCounter.Value;
        }

        private void penetrationCounter_ValueChanged(object sender, EventArgs e)
        {
            editWeapon.Penetration = (int)penetrationCounter.Value;
        }

        private void deleteAbilityButton_Click(object sender, EventArgs e)
        {
            WeaponAbility deleteAbility = (WeaponAbility)abilitiesListBox.SelectedItem;
            editWeapon.RemoveWeaponAbility(deleteAbility);
            weaponController.RemoveWeaponAbilityInstance(editWeapon, deleteAbility);
            abilitiesListBox.DataSource = null;
            abilitiesListBox.DataSource = editWeapon.WeaponAbilities;
            abilitiesListBox.DisplayMember = "ability";

        }

        private void addAbilityButton_Click(object sender, EventArgs e)
        {
            WeaponAbility newAbility = (WeaponAbility)abilitiesCombo.SelectedItem;
            editWeapon.AddWeaponAbility(newAbility);
            weaponController.InsertWeaponAbilityInstance(editWeapon, newAbility);
            abilitiesListBox.DataSource = null;
            abilitiesListBox.DataSource = editWeapon.WeaponAbilities;
            abilitiesListBox.DisplayMember = "ability";
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            weaponController.UpdateWeapon(editWeapon);
            editWeaponPanel.Visible = false;
        }
    }
}
