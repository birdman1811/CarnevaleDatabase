using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarnevaleDatabase.Datastore
{
    class Equipment
    {
        

        public Equipment()
        {
        }

        public Equipment(int equipmentID, string equipment, string equipmentText, string icon, int cost)
        {
            this.EquipmentID = equipmentID;
            this.EquipmentName = equipment;
            this.EquipmentText = equipmentText;
            this.Icon = icon;
            this.Cost = cost;
        }

        public int EquipmentID { get; set; }
        public string EquipmentName { get; set; }
        public string EquipmentText { get; set; }
        public string Icon { get; set; }
        public int Cost { get; set; }
    }
}
