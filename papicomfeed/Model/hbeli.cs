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
    class Hbeli
    {
        MySqlCommand cmd;

        public int id;
        public int karyawan_id;
        public int total;
        public string penjual;
        public string alamat;
        public string tanggal;


        

        private Hbeli(int id, int karyawan_id, int total, string penjual, string alamat, string tanggal)
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
        public static Hbeli get(int id)
        {
            DataTable dt = new DataTable();
            MySqlCommand cmd = new MySqlCommand($"SELECT * FROM HBeli WHERE ID = {id}", DB.conn);
            MySqlDataAdapter adpt = new MySqlDataAdapter();
            adpt.SelectCommand = cmd;
            adpt.FillAsync(dt);

            if (dt.Rows.Count <= 0)
            {
                return null;
            }

            int karyawan = int.Parse(dt.Rows[0][1].ToString());
            int total = int.Parse(dt.Rows[0][2].ToString());
            string penjual = dt.Rows[0][3].ToString();
            string alamat = dt.Rows[0][4].ToString();
            string tanggal = dt.Rows[0][5].ToString();

            //Ikan i = new Ikan(idikan, nama, waktu);

            return new Hbeli(id, karyawan, total, penjual, alamat, tanggal);
        }
    }
}
