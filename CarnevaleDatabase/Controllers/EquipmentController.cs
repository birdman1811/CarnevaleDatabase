using CarnevaleDatabase.Datastore;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarnevaleDatabase.Controllers
{
    class EquipmentController
    {
        MySqlConnection connection;
        DatabaseControl dBControl = new DatabaseControl();
        List<Equipment> equipmentList = new List<Equipment>();
        MySqlCommand command;
        MySqlDataReader dataReader;
        String sql = "";

        public List<Equipment> GetEquipment()
        {
            connection = dBControl.getConnection();
            connection.Open();

            sql = "SELECT * from Equipment";

            command = new MySqlCommand(sql, connection);

            dataReader = command.ExecuteReader();

            while (dataReader.Read()){
                Equipment newEquipment = new Equipment(dataReader.GetUInt16(0), dataReader.GetString(1), dataReader.GetString(2), dataReader.GetString(4),
                    dataReader.GetInt16(3));

                equipmentList.Add(newEquipment);
            }

            connection.Close();

            return equipmentList;
        }

        public void UpdateEquipment(Equipment item)
        {
            connection = dBControl.getConnection();
            connection.Open();

            using (MySqlCommand cmd = new MySqlCommand("UPDATE Equipment SET equipment = @equipmentName, equipment_text = @equipmentText," +
                " equipment_cost = @cost, icon = @icon WHERE equipment_id = @ID", connection))
            {
                cmd.Parameters.AddWithValue("@ID", item.EquipmentID);
                cmd.Parameters.AddWithValue("@equipmentName", item.EquipmentName);
                cmd.Parameters.AddWithValue("@equipmentText", item.EquipmentText);
                cmd.Parameters.AddWithValue("@cost", item.Cost);
                cmd.Parameters.AddWithValue("@icon", item.Icon);

                int rows = cmd.ExecuteNonQuery();
                connection.Close();
            }            
        }

        public void InsertEquipment(Equipment item)
        {
            connection = dBControl.getConnection();
            connection.Open();

            using (MySqlCommand cmd = new MySqlCommand("INSERT INTO Equipment (equipment, equipment_text," +
                " equipment_cost, icon) VALUES (@equipmentName, @equipmentText, @cost, @icon)", connection))
            {
                
                cmd.Parameters.AddWithValue("@equipmentName", item.EquipmentName);
                cmd.Parameters.AddWithValue("@equipmentText", item.EquipmentText);
                cmd.Parameters.AddWithValue("@cost", item.Cost);
                cmd.Parameters.AddWithValue("@icon", item.Icon);

                int rows = cmd.ExecuteNonQuery();
                connection.Close();
            }
        }
    }

    
}
