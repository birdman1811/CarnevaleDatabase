using CarnevaleDatabase.Datastore;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CarnevaleDatabase.Controllers
{
    class CharacterController
    {
        MySqlConnection connection;
        DatabaseControl dBControl = new DatabaseControl();
        List<Character> factionList = new List<Character>();
        MySqlCommand command;
        MySqlDataReader dataReader;
        String sql = "";


        public List<Character> GetCharacters(Faction faction)
        {
            List<Character> charlist = new List<Character>();

            switch (faction.FactionID)
            {

                case 6:
                    sql = "GET * from GuildCharacterView";
                    break;
                case 7:
                    sql = "Get * from RashaarCharacterView";
                    break;
                case 8:
                    sql = "GET * from DoctorsCharacterView";
                    break;
                case 9:
                    sql = "GET * from PatriciansCharacterView";
                    break;
                case 10:
                    sql = "GET * from VaticanCharacterView";
                    break;
                case 11:
                    sql = "GET * from StrigoiCharacterView";
                    break;
                case 12:
                    sql = "GET * from GiftedCharacterView";
                    break;
            }

            connection = dBControl.getConnection();
            connection.Open();

            command = new MySqlCommand(sql, connection);

            dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                Character newCharacter = new Character();
                newCharacter.CharID = dataReader.GetInt16(0);
                newCharacter.Name = dataReader.GetString(1);
                newCharacter.Movement = dataReader.GetInt16(2);
                newCharacter.Dexterity = dataReader.GetInt16(3);
                newCharacter.Attack = dataReader.GetInt16(4);
                newCharacter.Protection = dataReader.GetInt16(5);
                newCharacter.Mind = dataReader.GetInt16(6);
                newCharacter.Action = dataReader.GetInt16(7);
                newCharacter.Life = dataReader.GetInt16(8);
                newCharacter.Will = dataReader.GetInt16(9);
                newCharacter.Command = dataReader.GetInt16(10);
                newCharacter.Ducats = dataReader.GetInt16(11);
                newCharacter.IsUnique = dataReader.GetBoolean(12);
                newCharacter.Image = dataReader.GetString(13);
                newCharacter.CharType = dataReader.GetString(14);
                newCharacter.Faction = faction;
                switch (dataReader.GetInt16(16))
                {
                    case 30:
                        Base newBase30 = new Base(1, 30);
                        newCharacter.BaseSize = newBase30;
                        break;

                    case 40:
                        Base newBase40 = new Base(2, 40);
                        newCharacter.BaseSize = newBase40;
                        break;

                    case 50:
                        Base newBase50 = new Base(1, 50);
                        newCharacter.BaseSize = newBase50;
                        break;

                    case 60:
                        Base newBase60 = new Base(1, 60);
                        newCharacter.BaseSize = newBase60;
                        break;

                }

                 Thread uniqueRulesThread = new Thread(() => newCharacter.SetUniqueRules( GetUniqueRules(newCharacter.CharID)));
                uniqueRulesThread.IsBackground = true;
                uniqueRulesThread.Start();

                Thread specialRulesThread = new Thread(() => newCharacter.SetSpecialRules(GetSpecialRules(newCharacter.CharID)));
                specialRulesThread.IsBackground = true;
                specialRulesThread.Start();

                Thread keyWordsThread = new Thread(() => newCharacter.SetKeyWords(GetKeyWords(newCharacter.CharID)));
                keyWordsThread.IsBackground = true;
                keyWordsThread.Start();
                

            }
            connection.Close();

            return charlist;
        }

        private List<UniqueRule> GetUniqueRules(int charid)
        {
            List<UniqueRule> uniqueRules = new List<UniqueRule>();

            MySqlConnection uniqueRulesConnection;           
            MySqlDataReader dataReader;            

            uniqueRulesConnection = dBControl.getConnection();

            uniqueRulesConnection.Open();

            using (MySqlCommand cmd = new MySqlCommand("GET * FROM Unique_Rules WHERE character_id = @charID", uniqueRulesConnection))
            {
                cmd.Parameters.AddWithValue("@charID", charid);

                dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    UniqueRule newRule = new UniqueRule(dataReader.GetInt16(0), dataReader.GetString(1));
                    uniqueRules.Add(newRule);
                }

            }

            uniqueRulesConnection.Close();

                return uniqueRules;
        }

        private List<SpecialRule> GetSpecialRules(int charid)
        {
            List<SpecialRule> specialRules = new List<SpecialRule>();

            MySqlConnection specialRulesConnection;
            MySqlDataReader dataReader;

            specialRulesConnection = dBControl.getConnection();

            specialRulesConnection.Open();

            using (MySqlCommand cmd = new MySqlCommand("GET * FROM SpecialRuleView WHERE char_id = @charID", specialRulesConnection))
            {
                cmd.Parameters.AddWithValue("@charID", charid);

                dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    SpecialRule newRule = new SpecialRule(dataReader.GetInt16(0), dataReader.GetString(1), dataReader.GetInt16(2));
                    specialRules.Add(newRule);
                }

            }

            specialRulesConnection.Close();

            return specialRules;
        }

        public List<KeyWord> GetKeyWords(int charid)
        {
            List<KeyWord> keywords = new List<KeyWord>();

            MySqlConnection keyWordConnection;
            MySqlDataReader dataReader;

            keyWordConnection = dBControl.getConnection();

            keyWordConnection.Open();

            using (MySqlCommand cmd = new MySqlCommand("GET * FROM KeywordsView WHERE char_id = @charID", keyWordConnection))
            {
                cmd.Parameters.AddWithValue("@charID", charid);

                dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    KeyWord newKeyWord = new KeyWord(dataReader.GetInt16(0), dataReader.GetString(1));
                    keywords.Add(newKeyWord);
                }

            }

            keyWordConnection.Close();

            return keywords;
        }

        private List<Weapon> getWeapons(int charid)
        {
            List<Weapon> weapons = new List<Weapon>();



            return weapons;
        }


    }
}
    

