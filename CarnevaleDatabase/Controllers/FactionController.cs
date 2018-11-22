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
                    dataReader.GetString(9));

                factionList.Add(newFaction);
            }

            connection.Close();

            return factionList;
        }
    }
}
