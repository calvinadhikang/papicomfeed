using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace papicomfeed.Database
{
    class Connection
    {
        public static String server = "localhost";
        public static String uid = "root";
        public static String database = "papicomfeed";

        public static String connString = $"server={server};user id={uid};database={database}";
    }
}
