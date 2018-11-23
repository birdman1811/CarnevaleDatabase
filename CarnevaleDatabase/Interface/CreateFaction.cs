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
    public partial class CreateFaction : Form
    {
        public CreateFaction()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Faction newFaction = new Faction();
            newFaction.FactionName = factionNameText.Text;
            newFaction.FactionIcon = iconUrlText.Text;
            newFaction.FactionImage = imgUrlText.Text;
            newFaction.FactionStrip = stripUrlText.Text;
            newFaction.FactionReverseIcon = reverseIconUrlText.Text;
            newFaction.FactionCommand = commandImgUrlText.Text;
            newFaction.FactionGamePlay = gamePlayText.Text;
            newFaction.FactionLore = loreText.Text;
            newFaction.DetailedIcon = detailedIconUrlText.Text;

            FactionController factionController = new FactionController();

            factionController.InsertFaction(newFaction);

            factionNameText.Clear();
            iconUrlText.Clear();
            imgUrlText.Clear();
            stripUrlText.Clear();
            reverseIconUrlText.Clear();
            commandImgUrlText.Clear();
            gamePlayText.Clear();
            loreText.Clear();
            detailedIconUrlText.Clear();

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
