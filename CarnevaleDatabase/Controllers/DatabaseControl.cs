using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace CarnevaleDatabase.Controllers
{
    class DatabaseControl
    {

        public MySqlConnection getConnection()
        {
            string server = "31.132.4.108";
            string database = "carnevale_webapp";
            string uid = "carnevale_webAdmin";
            string password = "VYz!FWLos0BS";


            string connectionString;
            MySqlConnection connection;
            connectionString = "SERVER =" + server + ";" + "DATABASE=" + database + ";" +
                "UID=" + uid + ";" + "PASSWORD=" + password + ";";
            connection = new MySqlConnection(connectionString);
            return connection;
        }
        
    }
}
