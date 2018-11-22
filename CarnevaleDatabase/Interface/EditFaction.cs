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

        FactionController factionController = new FactionController();
        List<Faction> factionList = new List<Faction>();
        

        public EditFaction()
        {
            InitializeComponent();
        }

        private void EditFaction_Load(object sender, EventArgs e)
        {
            factionList = factionController.GetFactions();

            foreach (Faction faction in factionList)
            {
                Console.WriteLine(faction.FactionName);
            }
            
        }
    }
}
