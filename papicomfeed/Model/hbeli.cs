using MySql.Data.MySqlClient;
using papicomfeed.Database;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace papicomfeed.Model
{
    class hbeli
    {
        MySqlCommand cmd;

        public int id;
        public int karyawan_id;
        public int total;
        public string penjual;
        public string alamat;
        public string tanggal;

        private hbeli(int id, int karyawan_id, int total, string penjual, string alamat, string tanggal)
        {
            this.id = id;
            this.karyawan_id = karyawan_id;
            this.total = total;
            this.penjual = penjual;
            this.alamat = alamat;
            this.tanggal = tanggal;

        }

        public static DataTable getAll()
        {
            DataTable dt = new DataTable();
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM HBELI", DB.conn);
            MySqlDataAdapter adpt = new MySqlDataAdapter();
            adpt.SelectCommand = cmd;
            adpt.FillAsync(dt);

            return dt;
        }

    }
}
