using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using MySql.Data.MySqlClient;
using papicomfeed.Database;

namespace papicomfeed.Model
{
    class DBeli
    {
        MySqlCommand cmd;

        int id;
        int hbeli_id;
        int kolam_id;
        int ikan_id;
        int harga;
        int jumlah;
        string nama_ikan;
        int subtotal;
        string tanggal;

        // mendapatkan data dbeli pada database
        public static DataTable get(int hbeli_id)
        {
            DataTable dt = new DataTable();
            MySqlCommand cmd = new MySqlCommand($"Select * from DBELI where hbeli_id = {hbeli_id}", DB.conn);
            MySqlDataAdapter adpt = new MySqlDataAdapter();
            adpt.SelectCommand = cmd;
            adpt.FillAsync(dt);

            if (dt.Rows.Count <= 0)
            {
                return null;
            }

            return dt;
        }

        public static DataTable getByDBeliId(int id)
        {
            DataTable dt = new DataTable();
            MySqlCommand cmd = new MySqlCommand($"Select * from DBELI where id = {id}", DB.conn);
            MySqlDataAdapter adpt = new MySqlDataAdapter();
            adpt.SelectCommand = cmd;
            adpt.FillAsync(dt);

            if (dt.Rows.Count <= 0)
            {
                return null;
            }

            return dt;
        }


        public static DataTable getAll()
        {
            DataTable dt = new DataTable();
            MySqlCommand cmd = new MySqlCommand("Select * from DBELI", DB.conn);
            MySqlDataAdapter adpt = new MySqlDataAdapter();
            adpt.SelectCommand = cmd;
            adpt.FillAsync(dt);

            return dt;
        }
    }
}
