using CarnevaleDatabase.Datastore;
using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarnevaleDatabase.Controllers
{
    class FactionController
    {
        MySqlConnection connection;
        DatabaseControl dBControl = new DatabaseControl();
        List<Faction> factionList = new List<Faction>();
        MySqlCommand command;
        MySqlDataReader dataReader;
        String sql = "";

         public List<Faction> GetFactions()
        {            
            connection = dBControl.getConnection();            
            
                connection.Open();           

            sql = "Select * from Factions";

            command = new MySqlCommand(sql, connection);

            dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                Faction newFaction = new Faction(dataReader.GetInt16(0), dataReader.GetString(2),
                    dataReader.GetString(5), dataReader.GetString(4), dataReader.GetString(1),
                    dataReader.GetString(3), dataReader.GetString(6), dataReader.GetString(8),
                    dataReader.GetString(9), dataReader.GetString(7));

                factionList.Add(newFaction);
            }

            connection.Close();

            return factionList;
        }

        public void UpdateFaction(Faction faction)
        {
            connection = dBControl.getConnection();

            connection.Open();

            using (MySqlCommand cmd = new MySqlCommand("UPDATE Factions Set faction = @factionName, faction_lore = @factionLore, faction_gameplay = @factionGameplay," +
                "faction_command = @factionCommand, icon = @factionIcon, detailedicon = @detailedIcon, reverseicon = @reverseIcon, strip = @strip, faction_img_url = @imgUrl" +
                " WHERE faction_id = @factionID", connection))
            {
                cmd.Parameters.AddWithValue("@factionID", faction.FactionID);
                cmd.Parameters.AddWithValue("@strip", faction.FactionStrip);
                cmd.Parameters.AddWithValue("@reverseIcon", faction.FactionReverseIcon);
                cmd.Parameters.AddWithValue("@detailedIcon", faction.DetailedIcon);
                cmd.Parameters.AddWithValue("@factionIcon", faction.FactionIcon);
                cmd.Parameters.AddWithValue("@factionCommand", faction.FactionCommand);
                cmd.Parameters.AddWithValue("@factionGameplay", faction.FactionGamePlay);
                cmd.Parameters.AddWithValue("@factionLore", faction.FactionLore);
                cmd.Parameters.AddWithValue("@factionName", faction.FactionName);
                cmd.Parameters.AddWithValue("@imgUrl", faction.FactionImage);

                int rows = cmd.ExecuteNonQuery();
            }
        }
    }
}
