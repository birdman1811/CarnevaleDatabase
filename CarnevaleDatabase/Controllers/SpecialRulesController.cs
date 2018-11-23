using CarnevaleDatabase.Datastore;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarnevaleDatabase.Controllers
{
    class SpecialRulesController
    {
        MySqlConnection connection;
        DatabaseControl dbControl = new DatabaseControl();
        List<SpecialRule> specialRules = new List<SpecialRule>();
        MySqlCommand command;
        MySqlDataReader dataReader;
        String sql = "";

        public List<SpecialRule> getSpecialRules()
        {
            connection = dbControl.getConnection();

            connection.Open();

            sql = "Select * from Special_Rules";

            command = new MySqlCommand(sql, connection);

            dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                SpecialRule newSpecRule = new SpecialRule(dataReader.GetInt16(0), dataReader.GetString(1));

                specialRules.Add(newSpecRule);
            }

            connection.Close();

            return specialRules;
        }

        public void UpdateSpecialRule(SpecialRule specRule)
        {
            connection = dbControl.getConnection();

            connection.Open();

            using (MySqlCommand cmd = new MySqlCommand("UPDATE Special_Rules SET rule = @rule WHERE rule_id = @ruleID", connection))
            {
                cmd.Parameters.AddWithValue("@ruleID", specRule.RuleID);
                cmd.Parameters.AddWithValue("@rule", specRule.Rule);
                

                int rows = cmd.ExecuteNonQuery();
            }
        }

        public void InsertSpecialRule(SpecialRule specRule)
        {
            connection = dbControl.getConnection();

            connection.Open();

            using (MySqlCommand cmd = new MySqlCommand("INSERT INTO Special_Rules (rule) VALUES (@rule) ", connection))
            {
                
                cmd.Parameters.AddWithValue("@rule", specRule.Rule);


                int rows = cmd.ExecuteNonQuery();
            }
        }
    }
}
