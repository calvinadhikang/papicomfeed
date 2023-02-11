using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;

namespace papicomfeed.Database
{
    class DB
    {
        public static String server = "localhost";
        public static String uid = "root";
        public static String database = "papicomfeed";

        public static String connString = $"server={server};user id={uid};database={database}";

        public static MySqlConnection conn = new MySqlConnection(connString);

        public static void Open()
        {
            conn.Open();
        }
    }
}
