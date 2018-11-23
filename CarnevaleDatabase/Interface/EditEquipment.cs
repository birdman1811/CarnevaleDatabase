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
    public partial class EditEquipment : Form
    {
        EquipmentController equipmentController = new EquipmentController();
        List<Equipment> equipmentList = new List<Equipment>();
        Equipment selectedEquipment;

        public EditEquipment()
        {
            InitializeComponent();
            equipmentCombo.Visible = false;
            selectButton.Visible = false;
            itemNameLabel.Visible = false;
            equipmentNameText.Visible = false;
            equipmentTextLabel.Visible = false;
            equipmentRulesText.Visible = false;
            itemCostLabel.Visible = false;
            costSpinner.Visible = false;
            iconUrlLabel.Visible = false;
            iconUrlText.Visible = false;
            insertNewButton.Visible = false;
            updateItemButton.Visible = false;
        }

        private void createNewButton_Click(object sender, EventArgs e)
        {
            equipmentCombo.Visible = false;
            selectButton.Visible = false;
            itemNameLabel.Visible = true;
            equipmentNameText.Visible = true;
            equipmentTextLabel.Visible = true;
            equipmentRulesText.Visible = true;
            itemCostLabel.Visible = true;
            costSpinner.Visible = true;
            iconUrlLabel.Visible = true;
            iconUrlText.Visible = true;
            insertNewButton.Visible = true;
            updateItemButton.Visible = false;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void insertNewButton_Click(object sender, EventArgs e)
        {
            Equipment newEquipment = new Equipment();
            newEquipment.EquipmentName = equipmentNameText.Text;
            newEquipment.EquipmentText = equipmentRulesText.Text;
            newEquipment.Cost = (int)costSpinner.Value;
            newEquipment.Icon = iconUrlText.Text;

            equipmentController.InsertEquipment(newEquipment);

            equipmentNameText.Clear();
            equipmentRulesText.Clear();
            costSpinner.Value = 0;
            iconUrlText.Clear();
        }

        private void editItemButton_Click(object sender, EventArgs e)
        {
            equipmentCombo.Visible = true;
            selectButton.Visible = true;
            itemNameLabel.Visible = false;
            equipmentNameText.Visible = false;
            equipmentTextLabel.Visible = false;
            equipmentRulesText.Visible = false;
            itemCostLabel.Visible = false;
            costSpinner.Visible = false;
            iconUrlLabel.Visible = false;
            iconUrlText.Visible = false;
            insertNewButton.Visible = false;
            updateItemButton.Visible = false;

            PopulateCombo();
        }

        private void PopulateCombo()
        {
            equipmentList = equipmentController.GetEquipment();
            equipmentCombo.DataSource = equipmentList;
            equipmentCombo.DisplayMember = "EquipmentName";

        }

        private void selectButton_Click(object sender, EventArgs e)
        {
            equipmentCombo.Visible = true;
            selectButton.Visible = true;
            itemNameLabel.Visible = true;
            equipmentNameText.Visible = true;
            equipmentTextLabel.Visible = true;
            equipmentRulesText.Visible = true;
            itemCostLabel.Visible = true;
            costSpinner.Visible = true;
            iconUrlLabel.Visible = true;
            iconUrlText.Visible = true;
            insertNewButton.Visible = false;
            updateItemButton.Visible = true;

            selectedEquipment = (Equipment)equipmentCombo.SelectedItem;

            equipmentNameText.Text = selectedEquipment.EquipmentName;
            equipmentRulesText.Text = selectedEquipment.EquipmentText;
            costSpinner.Value = selectedEquipment.Cost;
            iconUrlText.Text = selectedEquipment.Icon;

        }

        private void updateItemButton_Click(object sender, EventArgs e)
        {
            selectedEquipment.EquipmentName = equipmentNameText.Text;
            selectedEquipment.EquipmentText = equipmentRulesText.Text;
            selectedEquipment.Cost = (int)costSpinner.Value;
            selectedEquipment.Icon = iconUrlText.Text;

            equipmentController.UpdateEquipment(selectedEquipment);

            equipmentNameText.Clear();
            equipmentRulesText.Clear();
            costSpinner.Value = 0;
            iconUrlText.Clear();

            equipmentCombo.Visible = false;
            selectButton.Visible = false;
            itemNameLabel.Visible = false;
            equipmentNameText.Visible = false;
            equipmentTextLabel.Visible = false;
            equipmentRulesText.Visible = false;
            itemCostLabel.Visible = false;
            costSpinner.Visible = false;
            iconUrlLabel.Visible = false;
            iconUrlText.Visible = false;
            insertNewButton.Visible = false;
            updateItemButton.Visible = false;
        }
    }
}
