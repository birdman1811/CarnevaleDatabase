using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarnevaleDatabase.Datastore
{
    class Faction
    {
        public Faction()
        {
        }

        public Faction(int factionID, string factionName, string factionCommand, string factionGamePlay, string factionImage, string factionLore, string factionIcon, string factionReverseIcon, string factionStrip)
        {
            this.FactionID = factionID;
            this.FactionName = factionName;
            this.FactionCommand = factionCommand;
            this.FactionGamePlay = factionGamePlay;
            this.FactionImage = factionImage;
            this.FactionLore = factionLore;
            this.FactionIcon = factionIcon;
            this.FactionReverseIcon = factionReverseIcon;
            this.FactionStrip = factionStrip;
        }

        public int FactionID { get; set; }
        public string FactionName { get; set; }
        public string FactionCommand { get; set; }
        public string FactionGamePlay { get; set; }
        public string FactionImage { get; set; }
        public string FactionLore { get; set; }
        public string FactionIcon { get; set; }
        public string FactionReverseIcon { get; set; }
        public string FactionStrip { get; set; }
    }
}
