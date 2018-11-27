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

        private int GetWeaponAbilityID(string ability)
        {
            int abilityID = 0;

            MySqlConnection weaponAbilityIDConnection;
            MySqlDataReader dataReader;

            weaponAbilityIDConnection = dBControl.getConnection();

            weaponAbilityIDConnection.Open();

            using (MySqlCommand cmd = new MySqlCommand("Select * FROM Weapon_Abilities WHERE weapon_ability = @ability", weaponAbilityIDConnection))
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
    }


}
