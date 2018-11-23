using CarnevaleDatabase.Datastore;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarnevaleDatabase.Controllers
{
    class KeyWordController
    { 
    MySqlConnection connection;
    DatabaseControl dbControl = new DatabaseControl();
    List<KeyWord> keyWords = new List<KeyWord>();
    MySqlCommand command;
    MySqlDataReader dataReader;
    String sql = "";

        public List<KeyWord> getKeyWords()
        {
            connection = dbControl.getConnection();

            connection.Open();

            sql = "Select * from Keywords";

            command = new MySqlCommand(sql, connection);

            dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                KeyWord newKeyword = new KeyWord(dataReader.GetInt16(0), dataReader.GetString(1));

                keyWords.Add(newKeyword);
            }

            connection.Close();

            return keyWords;
        }

        public void UpdateKeyWords(KeyWord keyWord)
        {
            connection = dbControl.getConnection();

            connection.Open();

            using (MySqlCommand cmd = new MySqlCommand("UPDATE Keywords SET keyword = @keyword WHERE keyword_id = @keywordID", connection))
            {
                cmd.Parameters.AddWithValue("@keywordID", keyWord.KeyWordID);
                cmd.Parameters.AddWithValue("@keyword", keyWord.KeyWordText);


                int rows = cmd.ExecuteNonQuery();
                connection.Close();
            }
        }

        public void InsertKeyWord(KeyWord keyWord)
        {
            connection = dbControl.getConnection();

            connection.Open();

            using (MySqlCommand cmd = new MySqlCommand("INSERT INTO Keywords (keyword) VALUES (@keyword) ", connection))
            {

                cmd.Parameters.AddWithValue("@keyword", keyWord.KeyWordText);


                int rows = cmd.ExecuteNonQuery();
                connection.Close();
            }
        }
    }
}
