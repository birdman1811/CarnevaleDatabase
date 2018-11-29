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
    class WeaponController
    {
        MySqlConnection connection;
        DatabaseControl dBControl = new DatabaseControl();
        MySqlCommand command;
        MySqlDataReader dataReader;
        String sql = "";
        List<Weapon>  weaponList = new List<Weapon>();

        public List<Weapon> GetWeapons()
        {
            connection = dBControl.getConnection();
            connection.Open();

            sql = "SELECT * FROM Weapons";

            command = new MySqlCommand(sql, connection);

            dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                Weapon newWeapon = new Weapon();
                newWeapon.WeaponID = dataReader.GetInt16(0);
                newWeapon.WeaponName = dataReader.GetString(1);
                newWeapon.Range = dataReader.GetInt16(2);
                newWeapon.Evasion = dataReader.GetInt16(3);
                newWeapon.Damage = dataReader.GetInt16(4);
                newWeapon.Penetration = dataReader.GetInt16(5);
                

                Thread weaponAbilitiesThread = new Thread(() => newWeapon.SetWeaponAbilities(GetWeaponAbilities(newWeapon.WeaponID)));
                weaponAbilitiesThread.IsBackground = true;
                weaponAbilitiesThread.Name = "WeaponAbilitiesThread";
                weaponAbilitiesThread.Start();

                weaponList.Add(newWeapon);
            }

            connection.Close();

            return weaponList;
        }

        private List<WeaponAbility> GetWeaponAbilities(int weaponID)
        {
            List<WeaponAbility> weaponAbilities = new List<WeaponAbility>();            

            MySqlConnection weaponAbilitiesConnection;
            MySqlDataReader dataReader;

            weaponAbilitiesConnection = dBControl.getConnection();

            weaponAbilitiesConnection.Open();

            using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM WeaponAbilitiesView WHERE weapon_id = @weaponID", weaponAbilitiesConnection))
            {
                cmd.Parameters.AddWithValue("@weaponID", weaponID);

                dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    WeaponAbility newAbility = new WeaponAbility(dataReader.GetString(3));

                    Thread weaponAbilityIDThread = new Thread(() => newAbility.WeaponAbilityID = GetWeaponAbilityID(newAbility.Ability));
                    weaponAbilityIDThread.IsBackground = true;
                    weaponAbilityIDThread.Name = "WeaponAbilitiesIDThread";
                    weaponAbilityIDThread.Start();

                    weaponAbilities.Add(newAbility);
                }

            }

            weaponAbilitiesConnection.Close();


            return weaponAbilities;
        }

        public int GetWeaponAbilityID(string ability)
        {
            int abilityID = 0;

            MySqlConnection weaponAbilityIDConnection;
            MySqlDataReader dataReader;

            weaponAbilityIDConnection = dBControl.getConnection();

            weaponAbilityIDConnection.Open();

            using (MySqlCommand cmd = new MySqlCommand("SELECT weapon_ability_id FROM Weapon_Abilities WHERE weapon_ability = @ability", weaponAbilityIDConnection))
            {
                cmd.Parameters.AddWithValue("@ability", ability);

                dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    abilityID = dataReader.GetInt16(0);
                }
            }

            weaponAbilityIDConnection.Close();

                return abilityID;
        }

        public int GetWeaponID(Weapon weapon)
        {
            int weaponID = 0;

            MySqlConnection weaponAbilityIDConnection;
            MySqlDataReader dataReader;

            weaponAbilityIDConnection = dBControl.getConnection();

            weaponAbilityIDConnection.Open();

            using (MySqlCommand cmd = new MySqlCommand("SELECT weapon_id FROM Weapons WHERE weapon = @weapon", weaponAbilityIDConnection))
            {
                cmd.Parameters.AddWithValue("@weapon", weapon.WeaponName);

                dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    weaponID = dataReader.GetInt16(0);
                }
            }

            weaponAbilityIDConnection.Close();

            return weaponID;
        }

        public List<WeaponAbility> GetAllWeaponAbilities()
        {
            List<WeaponAbility> weaponAbilities = new List<WeaponAbility>();

            connection = dBControl.getConnection();
            connection.Open();

            sql = "SELECT * FROM Weapon_Abilities";

            command = new MySqlCommand(sql, connection);

            dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                WeaponAbility newWeaponAbility = new WeaponAbility();
                newWeaponAbility.WeaponAbilityID = dataReader.GetInt16(0);
                newWeaponAbility.Ability = dataReader.GetString(1);                  

                weaponAbilities.Add(newWeaponAbility);
            }

            connection.Close();

            return weaponAbilities;
        }

        public void InsertWeaponAbilityInstance(Weapon weapon, WeaponAbility weaponAbility)
        {
            connection = dBControl.getConnection();
            connection.Open();

            using (MySqlCommand cmd = new MySqlCommand("INSERT INTO Weapon_Ability_Instances (weapon, weapon_ability) VALUES " +
                "(@weapon, @ability)", connection))
            {
                cmd.Parameters.AddWithValue("@weapon", weapon.WeaponID);
                cmd.Parameters.AddWithValue("@ability", weaponAbility.WeaponAbilityID);

                int rows = cmd.ExecuteNonQuery();
                connection.Close();
            }
        }

        public void RemoveWeaponAbilityInstance(Weapon weapon, WeaponAbility weaponAbility)
        {
            connection = dBControl.getConnection();
            connection.Open();

            using (MySqlCommand cmd = new MySqlCommand("DELETE FROM Weapon_Ability_Instances WHERE weapon = @weapon AND weapon_ability = @ability", connection))
            {
                cmd.Parameters.AddWithValue("@weapon", weapon.WeaponID);
                cmd.Parameters.AddWithValue("@ability", weaponAbility.WeaponAbilityID);

                int rows = cmd.ExecuteNonQuery();
                connection.Close();
            }
        }

        public void InsertNewWeaponAbility(WeaponAbility ability)
        {
            connection = dBControl.getConnection();
            connection.Open();

            using (MySqlCommand cmd = new MySqlCommand("INSERT INTO Weapon_Abilities (weapon_ability) VALUES " +
                "(@ability)", connection))
            {
                cmd.Parameters.AddWithValue("@ability", ability.Ability);
                

                int rows = cmd.ExecuteNonQuery();
                connection.Close();
            }
        }

        public void UpdateWeaponAbility (WeaponAbility ability)
        {
            connection = dBControl.getConnection();
            connection.Open();

            using (MySqlCommand cmd = new MySqlCommand("UPDATE Weapon_Abilities SET weapon_ability = @ability WHERE weapon_ability_id = @abilityID", connection))
            {
                cmd.Parameters.AddWithValue("@ability", ability.Ability);
                cmd.Parameters.AddWithValue("@abilityID", ability.WeaponAbilityID);              

                int rows = cmd.ExecuteNonQuery();
                Console.WriteLine("Updated " + rows + " Lines");
                connection.Close();
            }
        }

        public void InsertNewWeapon(Weapon weapon)
        {
            connection = dBControl.getConnection();
            connection.Open();

            using (MySqlCommand cmd = new MySqlCommand("INSERT INTO Weapons (weapon, weapon_range, evasion, damage, penetration) VALUES " +
                "(@weapon, @range, @evasion, @damage, @penetration)", connection))
            {
                cmd.Parameters.AddWithValue("@weapon", weapon.WeaponName);
                cmd.Parameters.AddWithValue("@range", weapon.Range);
                cmd.Parameters.AddWithValue("@evasion", weapon.Evasion);
                cmd.Parameters.AddWithValue("@damage", weapon.Damage);
                cmd.Parameters.AddWithValue("@penetration", weapon.Penetration);

                int rows = cmd.ExecuteNonQuery();
                connection.Close();
            }
        }

        public void UpdateWeapon(Weapon weapon)
        {
            connection = dBControl.getConnection();
            connection.Open();

            using (MySqlCommand cmd = new MySqlCommand("UPDATE Weapons SET weapon = @name, " +
                "weapon_range = @range, evasion = @evasion, damage = @damage, penetration = @penetration WHERE weapon_id = @weaponID", connection))
            {
                cmd.Parameters.AddWithValue("@name", weapon.WeaponName);
                cmd.Parameters.AddWithValue("@range", weapon.Range);
                cmd.Parameters.AddWithValue("@evasion", weapon.Evasion);
                cmd.Parameters.AddWithValue("@damage", weapon.Damage);
                cmd.Parameters.AddWithValue("@penetration", weapon.Penetration);
                cmd.Parameters.AddWithValue("@weaponID", weapon.WeaponID);

                int rows = cmd.ExecuteNonQuery();
                Console.WriteLine("Updated " + rows + " Lines");
                connection.Close();
            }
        }
    }


}
