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
    public partial class EditFaction : Form
    {
        List<Faction> factionList = new List<Faction>();
        FactionController factionController = new FactionController();
        Faction selectedFaction;
        

        public EditFaction()
        {
            InitializeComponent();
        }

        private void EditFaction_Load(object sender, EventArgs e)
        {
            
            UpdateFactionComboBox();
            SwitchHiddenVisible(false);
        }

        private void UpdateFactionComboBox()
        {
            factionList = factionController.GetFactions();
            factionSelectBox.DataSource = factionList;
            factionSelectBox.DisplayMember = "factionName";
        }

        private void SelectFactionButton_Click(object sender, EventArgs e)
        {
            SwitchHiddenVisible(true);
            selectedFaction = (Faction)factionSelectBox.SelectedItem;
            factionNameBox.Text = selectedFaction.FactionName;
            imgUrlText.Text = selectedFaction.FactionImage;
            commandImgUrlText.Text = selectedFaction.FactionCommand;
            iconUrlText.Text = selectedFaction.FactionIcon;
            detailedIconText.Text = selectedFaction.DetailedIcon;
            reverseIconText.Text = selectedFaction.FactionReverseIcon;
            factionStripUrlText.Text = selectedFaction.FactionStrip;
            factionLoreText.Text = selectedFaction.FactionLore;
            factionGameplayText.Text = selectedFaction.FactionGamePlay;
        }

        private void SwitchHiddenVisible(bool state)
        {
            factionNameBox.Visible = state;
            factionNameLabel.Visible = state;
            imgUrlLabel.Visible = state;
            imgUrlText.Visible = state;
            commandImgUrlLabel.Visible = state;
            commandImgUrlText.Visible = state;
            iconUrlLabel.Visible = state;
            iconUrlText.Visible = state;
            detailedIconLabel.Visible = state;
            detailedIconText.Visible = state;
            reverseIconLabel.Visible = state;
            reverseIconText.Visible = state;
            factionStripUrlLabel.Visible = state;
            factionStripUrlText.Visible = state;
            factionLoreLabel.Visible = state;
            factionLoreText.Visible = state;
            factionGameplayLabel.Visible = state;
            factionGameplayText.Visible = state;
            saveButton.Visible = state;
            cancelButton.Visible = state;

            if (state == true)
            {
                factionSelectBox.Visible = false;
                selectFactionLabel.Visible = false;
                selectFactionButton.Visible = false;
                this.Width = 1500;
            }

            if (state == false)
            {
                factionSelectBox.Visible = true;
                selectFactionLabel.Visible = true;
                selectFactionButton.Visible = true;
                this.Width = 500;
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            selectedFaction.FactionName = factionNameBox.Text;
            selectedFaction.FactionCommand = commandImgUrlText.Text;
            selectedFaction.FactionGamePlay = factionGameplayText.Text;
            selectedFaction.FactionIcon = iconUrlText.Text;
            selectedFaction.FactionImage = imgUrlText.Text;
            selectedFaction.FactionLore = factionLoreText.Text;
            selectedFaction.FactionReverseIcon = reverseIconText.Text;
            selectedFaction.FactionStrip = factionStripUrlText.Text;
            selectedFaction.DetailedIcon = detailedIconText.Text;

            factionController.UpdateFaction(selectedFaction);

            UpdateFactionComboBox();

            SwitchHiddenVisible(false);
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            SwitchHiddenVisible(false);
        }

        
    }
}
