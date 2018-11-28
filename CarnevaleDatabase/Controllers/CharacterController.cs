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
                    sql = "SELECT * from GuildCharacterView";
                    break;
                case 7:
                    sql = "SELECT * from RashaarCharacterView";
                    break;
                case 8:
                    sql = "SELECT * from DoctorsCharacterView";
                    break;
                case 9:
                    sql = "SELECT * from PatriciansCharacterView";
                    break;
                case 10:
                    sql = "SELECT * from VaticanCharacterView";
                    break;
                case 11:
                    sql = "SELECT * from StrigoiCharacterView";
                    break;
                case 12:
                    sql = "SELECT * from GiftedCharacterView";
                    break;
            }

            connection = dBControl.getConnection();
            connection.Open();

            command = new MySqlCommand(sql, connection);

            dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                Character newCharacter = new Character
                {
                    CharID = dataReader.GetInt16(0),
                    Name = dataReader.GetString(1),
                    Movement = dataReader.GetInt16(2),
                    Dexterity = dataReader.GetInt16(3),
                    Attack = dataReader.GetInt16(4),
                    Protection = dataReader.GetInt16(5),
                    Mind = dataReader.GetInt16(6),
                    Action = dataReader.GetInt16(7),
                    Life = dataReader.GetInt16(8),
                    Will = dataReader.GetInt16(9),
                    Command = dataReader.GetInt16(10),
                    Ducats = dataReader.GetInt16(11),
                    IsUnique = dataReader.GetBoolean(12),
                    Image = dataReader.GetString(13),
                    CharType = dataReader.GetString(14),
                    Faction = faction
                };
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
                        Base newBase50 = new Base(3, 50);
                        newCharacter.BaseSize = newBase50;
                        break;

                    case 60:
                        Base newBase60 = new Base(4, 60);
                        newCharacter.BaseSize = newBase60;
                        break;

                }

                Thread uniqueRulesThread = new Thread(() => newCharacter.SetUniqueRules(GetUniqueRules(newCharacter.CharID)))
                {
                    IsBackground = true,
                    Name = "UnqiueRulesThread"
                };
                uniqueRulesThread.Start();

                Thread specialRulesThread = new Thread(() => newCharacter.SetSpecialRule(GetSpecialRules(newCharacter.CharID)))
                {
                    IsBackground = true,
                    Name = "SpecialRulesThread"
                };
                specialRulesThread.Start();

                Thread keyWordsThread = new Thread(() => newCharacter.SetKeyWords(GetKeyWords(newCharacter.CharID)))
                {
                    IsBackground = true,
                    Name = "KeyWordsThread"
                };
                keyWordsThread.Start();

                Thread weaponsThread = new Thread(() => newCharacter.SetWeapons(GetWeapons(newCharacter.CharID)))
                {
                    IsBackground = true,
                    Name = "WeaponsThread"
                };
                weaponsThread.Start();

                charlist.Add(newCharacter);
            }
            connection.Close();

            return charlist;
        }

        public void UpdateCharacter(Character charToUpdate)
        {

            int charType = 0;
            switch (charToUpdate.CharType)
            {
                case "Leader":
                    charType = 1;
                    break;

                case "Hero":
                    charType = 2;
                    break;

                case "Henchman":
                    charType = 3;
                    break;
            }            

            connection = dBControl.getConnection();
            connection.Open();

            using (MySqlCommand cmd = new MySqlCommand("UPDATE Characters SET name = @name, base_size = @base, movement = @movement, " +
                "dexterity = @dexterity, attack = @attack, protection = @protection, mind = @mind, actionpoints = @actionpoints, lifepoints = @lifepoints, " +
                "willpoints = @willpoints, commandpoints = @commandPoints, ducats = @ducats, char_type = @charType, is_unique = @isUnique, " +
                "faction = @faction, image_url = @image WHERE char_id = @charID", connection))
            {
                cmd.Parameters.AddWithValue("@name", charToUpdate.Name);
                cmd.Parameters.AddWithValue("@base", charToUpdate.BaseSize.BaseID);
                cmd.Parameters.AddWithValue("@movement", charToUpdate.Movement);
                cmd.Parameters.AddWithValue("@dexterity", charToUpdate.Dexterity);
                cmd.Parameters.AddWithValue("@attack", charToUpdate.Attack);
                cmd.Parameters.AddWithValue("@protection", charToUpdate.Protection);
                cmd.Parameters.AddWithValue("@mind", charToUpdate.Mind);
                cmd.Parameters.AddWithValue("@actionpoints", charToUpdate.Action);
                cmd.Parameters.AddWithValue("@lifepoints", charToUpdate.Life);
                cmd.Parameters.AddWithValue("@willpoints", charToUpdate.Will);
                cmd.Parameters.AddWithValue("@commandPoints", charToUpdate.Command);
                cmd.Parameters.AddWithValue("@ducats", charToUpdate.Ducats);
                cmd.Parameters.AddWithValue("@charType", charType);
                cmd.Parameters.AddWithValue("@isUnique", charToUpdate.IsUnique);
                cmd.Parameters.AddWithValue("@faction", charToUpdate.Faction.FactionID);
                cmd.Parameters.AddWithValue("@image", charToUpdate.Image);
                cmd.Parameters.AddWithValue("@charID", charToUpdate.CharID);

                int rows = cmd.ExecuteNonQuery();
                connection.Close();
            }

            
        }

        public void InsertNewCharacter(Character character)
        {

            int charType = 0;
            switch (character.CharType)
            {
                case "Leader":
                    charType = 1;
                    break;

                case "Hero":
                    charType = 2;
                    break;

                case "Henchman":
                    charType = 3;
                    break;
            }

            connection = dBControl.getConnection();
            connection.Open();

            using (MySqlCommand cmd = new MySqlCommand("INSERT INTO Characters (name, base_size, movement, dexterity, attack, " +
                "protection, mind, actionpoints, lifepoints, willpoints, commandpoints, ducats, char_type, is_unique, faction, " +
                "image_url) VALUES (@name, @base, @movement, @dexterity, @attack, @protection, @mind, @actionpoints, @lifepoints, " +
                "@willpoints, @commandPoints, @ducats, @charType, @isUnique, @faction, @image)", connection))
            {
                cmd.Parameters.AddWithValue("@name", character.Name);
                cmd.Parameters.AddWithValue("@base", character.BaseSize.BaseID);
                cmd.Parameters.AddWithValue("@movement", character.Movement);
                cmd.Parameters.AddWithValue("@dexterity", character.Dexterity);
                cmd.Parameters.AddWithValue("@attack", character.Attack);
                cmd.Parameters.AddWithValue("@protection", character.Protection);
                cmd.Parameters.AddWithValue("@mind", character.Mind);
                cmd.Parameters.AddWithValue("@actionpoints", character.Action);
                cmd.Parameters.AddWithValue("@lifepoints", character.Life);
                cmd.Parameters.AddWithValue("@willpoints", character.Will);
                cmd.Parameters.AddWithValue("@commandPoints", character.Command);
                cmd.Parameters.AddWithValue("@ducats", character.Ducats);
                cmd.Parameters.AddWithValue("@charType", charType);
                cmd.Parameters.AddWithValue("@isUnique", character.IsUnique);
                cmd.Parameters.AddWithValue("@faction", character.Faction.FactionID);
                cmd.Parameters.AddWithValue("@image", character.Image);
                

                int rows = cmd.ExecuteNonQuery();
                connection.Close();
            }
        }

        public int GetCharacterID(Character charWithoutID)
        {
            int charID = 0;

            connection = dBControl.getConnection();
            MySqlDataReader dataReader;
            connection.Open();

            using (MySqlCommand cmd = new MySqlCommand("SELECT char_id FROM Characters WHERE name = @name", connection))
            {
                cmd.Parameters.AddWithValue("@name", charWithoutID.Name);                

                dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    charID = dataReader.GetInt16(0);
                }
                connection.Close();
            }

            return charID;
        }

        public List<UniqueRule> GetUniqueRules(int charid)
        {
            Console.WriteLine("Hello From " + Thread.CurrentThread.Name);
            List<UniqueRule> uniqueRules = new List<UniqueRule>();

            MySqlConnection uniqueRulesConnection;           
            MySqlDataReader dataReader;            

            uniqueRulesConnection = dBControl.getConnection();

            uniqueRulesConnection.Open();

            using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM Unique_Rules WHERE character_id = @charID", uniqueRulesConnection))
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

            Console.WriteLine("Goodbye From " + Thread.CurrentThread.Name);

            return uniqueRules;
        }        

        public void UpdateUniqueRules (UniqueRule ruleToUpdate)
        {
            connection = dBControl.getConnection();
            connection.Open();

            using (MySqlCommand cmd = new MySqlCommand("UPDATE Unique_Rules SET unique_rule_text = @ruleText WHERE unique_rule_id = @ruleID", connection))
            {
                cmd.Parameters.AddWithValue("@ruleText", ruleToUpdate.RuleText);
                cmd.Parameters.AddWithValue("@ruleID", ruleToUpdate.UniqueRuleID);

                int rows = cmd.ExecuteNonQuery();
                connection.Close();
            }

        }

        public void InsertUniqueRule (UniqueRule ruleToInsert, int charID)
        {
            connection = dBControl.getConnection();
            connection.Open();

            using (MySqlCommand cmd = new MySqlCommand("INSERT INTO Unique_Rules (unique_rule_text, character_id) VALUES " +
                "(@ruleText, @charID)", connection))
            {
                cmd.Parameters.AddWithValue("@ruleText", ruleToInsert.RuleText);
                cmd.Parameters.AddWithValue("@charID", charID);

                int rows = cmd.ExecuteNonQuery();
                connection.Close();
            }
        }

        public int GetUniqueRuleID (UniqueRule ruleToInsert, int charID)
        {
            int ruleID = 0;

            connection = dBControl.getConnection();
            MySqlDataReader dataReader;
            connection.Open();

            using (MySqlCommand cmd = new MySqlCommand("SELECT unique_rule_id FROM Unique_Rules WHERE unique_rule_text = @ruleText AND " +
                "character_id = @charID", connection))
            {
                cmd.Parameters.AddWithValue("@ruleText", ruleToInsert.RuleText);
                cmd.Parameters.AddWithValue("@charID", charID);

                dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    ruleID = dataReader.GetInt16(0);
                }
                connection.Close();
            }

            return ruleID;
        }

        public void RemoveUniqueRule (UniqueRule ruleToRemove)
        {
            connection = dBControl.getConnection();
            connection.Open();

            using (MySqlCommand cmd = new MySqlCommand("DELETE FROM Unique_Rules WHERE unique_rule_id = @ruleID", connection))
            {
                cmd.Parameters.AddWithValue("@ruleID", ruleToRemove.UniqueRuleID);

                int rows = cmd.ExecuteNonQuery();
                connection.Close();
            }

        }

        public List<SpecialRulesInstance> GetSpecialRules(int charid)
        {
            Console.WriteLine("Hello From " + Thread.CurrentThread.Name);
            List<SpecialRulesInstance> specialRules = new List<SpecialRulesInstance>();

            MySqlConnection specialRulesConnection;
            MySqlDataReader dataReader;

            specialRulesConnection = dBControl.getConnection();

            specialRulesConnection.Open();

            using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM SpecialRuleView WHERE char_id = @charID", specialRulesConnection))
            {
                cmd.Parameters.AddWithValue("@charID", charid);

                dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    SpecialRulesInstance newRule = new SpecialRulesInstance(dataReader.GetInt16(0), dataReader.GetString(3), dataReader.GetInt16(4));
                    
                    specialRules.Add(newRule);
                }

            }

            specialRulesConnection.Close();

            Console.WriteLine("Goodbye From " + Thread.CurrentThread.Name);

            return specialRules;
        }

        public void InsertSpecialRuleInstance(SpecialRulesInstance ruleToInsert, int charID)
        {
            connection = dBControl.getConnection();
            connection.Open();

            using (MySqlCommand cmd = new MySqlCommand("INSERT INTO Special_Rule_Instances (rule_id, character_id, amount) VALUES(@ruleId, " +
                "@charID, @amount)", connection))
            {
                cmd.Parameters.AddWithValue("@ruleId", ruleToInsert.RuleID);
                cmd.Parameters.AddWithValue("@charID", charID);
                cmd.Parameters.AddWithValue("@amount", ruleToInsert.Amount);

                int rows = cmd.ExecuteNonQuery();
                connection.Close();
            }

        }


        public void DeleteSpecialRulesInstance(SpecialRulesInstance ruleToDelete, int charID)
        {
            connection = dBControl.getConnection();
            connection.Open();

            using (MySqlCommand cmd = new MySqlCommand("DELETE FROM Special_Rule_Instances WHERE rule_id = @ruleID AND character_id = @charID " +
                "AND amount = @amount", connection))
            {
                cmd.Parameters.AddWithValue("@ruleId", ruleToDelete.RuleID);
                cmd.Parameters.AddWithValue("@charID", charID);
                cmd.Parameters.AddWithValue("@amount", ruleToDelete.Amount);

                int rows = cmd.ExecuteNonQuery();                
                connection.Close();
            }
        }

        public void UpdateSpecialRuleInstance(SpecialRulesInstance ruleToUpdate, int charID)
        {

            connection = dBControl.getConnection();
            connection.Open();           

            using (MySqlCommand cmd = new MySqlCommand("UPDATE Special_Rule_Instances SET amount = @amount WHERE rule_id = @ruleID AND character_id = @charID", connection))
            {
                cmd.Parameters.AddWithValue("@amount", ruleToUpdate.Amount);
                cmd.Parameters.AddWithValue("@ruleID", ruleToUpdate.RuleID);
                cmd.Parameters.AddWithValue("@charID", charID);

                int rows = cmd.ExecuteNonQuery();
                Console.WriteLine("Updated " + rows + " Lines");
                connection.Close();
            }
        }


        public int GetSpecialRuleID(SpecialRulesInstance specRule)
        {
            int ruleID = 0;

            connection = dBControl.getConnection();
            MySqlDataReader dataReader;
            connection.Open();

            using (MySqlCommand cmd = new MySqlCommand("SELECT rule_id FROM Special_Rules WHERE rule = @ruleText", connection))
            {
                cmd.Parameters.AddWithValue("@ruleText", specRule.Rule);

                dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    ruleID = dataReader.GetInt16(0);
                    Console.WriteLine("The ID for this Rule is " + ruleID);
                }
                connection.Close();
            }

            return ruleID;
        }

        public List<KeyWord> GetKeyWords(int charid)
        {

            Console.WriteLine("Hello From " + Thread.CurrentThread.Name);
            List<KeyWord> keywords = new List<KeyWord>();

            MySqlConnection keyWordConnection;
            MySqlDataReader dataReader;

            keyWordConnection = dBControl.getConnection();

            keyWordConnection.Open();

            using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM KeywordsView WHERE char_id = @charID", keyWordConnection))
            {
                cmd.Parameters.AddWithValue("@charID", charid);

                dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    KeyWord newKeyWord = new KeyWord(dataReader.GetInt16(0), dataReader.GetString(3));
                    keywords.Add(newKeyWord);
                    Console.WriteLine("* " + newKeyWord.KeyWordText);
                }

            }

            keyWordConnection.Close();

            Console.WriteLine("Goodbye From " + Thread.CurrentThread.Name);

            return keywords;
        }

        public int GetKeyWordID(KeyWord keyWord)
        {
            int keyWordID = 0;

            connection = dBControl.getConnection();
            MySqlDataReader dataReader;
            connection.Open();

            using (MySqlCommand cmd = new MySqlCommand("SELECT keyword_id FROM Keywords WHERE keyword = @ruleText", connection))
            {
                cmd.Parameters.AddWithValue("@ruleText", keyWord.KeyWordText);

                dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    keyWordID = dataReader.GetInt16(0);
                    Console.WriteLine("The ID for this Rule is " + keyWordID);
                }
                connection.Close();
            }

            return keyWordID;
        }

        public void InsertKeyWordInstance(KeyWord keyword, int charID)
        {
            connection = dBControl.getConnection();
            connection.Open();

            using (MySqlCommand cmd = new MySqlCommand("INSERT INTO Keyword_Instances (keyword, character_id) VALUES(@keyword, " +
                "@charID)", connection))
            {
                cmd.Parameters.AddWithValue("@keyword", keyword.KeyWordID);
                cmd.Parameters.AddWithValue("@charID", charID);                

                int rows = cmd.ExecuteNonQuery();
                connection.Close();
            }
        }

        public void DeleteKeyWordInstance(KeyWord keyword, int charID)
        {
            connection = dBControl.getConnection();
            connection.Open();

            using (MySqlCommand cmd = new MySqlCommand("DELETE FROM Keyword_Instances WHERE keyword = @keyword AND character_id = @charID", connection))
            {
                cmd.Parameters.AddWithValue("@keyword", keyword.KeyWordID);
                cmd.Parameters.AddWithValue("@charID", charID);

                int rows = cmd.ExecuteNonQuery();
                connection.Close();
            }
        }

        public List<Weapon> GetWeapons(int charid)
        {

            Console.WriteLine("Hello From " + Thread.CurrentThread.Name);
            List<Weapon> weapons = new List<Weapon>();

            MySqlConnection weaponsConnection;
            MySqlDataReader dataReader;

            weaponsConnection = dBControl.getConnection();

            weaponsConnection.Open();

            using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM WeaponInstancesView WHERE char_id = @charID", weaponsConnection))
            {
                cmd.Parameters.AddWithValue("@charID", charid);

                dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    Weapon newWeapon = new Weapon
                    {
                        WeaponID = dataReader.GetInt16(3),
                        WeaponName = dataReader.GetString(4)
                    };
                    weapons.Add(newWeapon);
                }
            }

            weaponsConnection.Close();

            Console.WriteLine("Goodbye From " + Thread.CurrentThread.Name);

            return weapons;
        }

        public void InsertWeaponInstance(Weapon weapon, int charID)
        {
            connection = dBControl.getConnection();
            connection.Open();

            using (MySqlCommand cmd = new MySqlCommand("INSERT INTO weapon_Instances (weapon, character_id) VALUES(@weapon, " +
                "@charID)", connection))
            {
                cmd.Parameters.AddWithValue("@weapon", weapon.WeaponID);
                cmd.Parameters.AddWithValue("@charID", charID);

                int rows = cmd.ExecuteNonQuery();
                connection.Close();
            }
        }

        public void DeleteWeaponInstance(Weapon weapon, int charID)
        {
            connection = dBControl.getConnection();
            connection.Open();

            using (MySqlCommand cmd = new MySqlCommand("DELETE FROM weapon_Instances WHERE weapon = @weapon AND character_id = @charID", connection))
            {
                cmd.Parameters.AddWithValue("@weapon", weapon.WeaponID);
                cmd.Parameters.AddWithValue("@charID", charID);

                int rows = cmd.ExecuteNonQuery();
                connection.Close();
            }
        }
    }
}
    

