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
    public class hjual
    {
        MySqlCommand cmd;

        public int id;
        public int karyawan_id;
        public int total;
        public int customer;
        public string alamat;
        public string tanggal;

        // constructor untuk insert data hjual
        public hjual(int karyawan_id, int total, int customer, string alamat, string tanggal)
        {
            this.karyawan_id = karyawan_id;
            this.total = total;
            this.customer = customer;
            this.alamat = alamat;
            this.tanggal = tanggal;

            string query = $"INSERT INTO HJUAL (karyawan_id, total, customer, alamat, tanggal) VALUES('{karyawan_id}','{total}','{customer}','{alamat}','{tanggal}')";
            cmd = new MySqlCommand(query, DB.conn);
            cmd.ExecuteNonQuery();

            this.id = Convert.ToInt32(cmd.LastInsertedId);

            
        }

        // membuat class hjual yang sudah ada
        private hjual(int id, int karyawan_id, int total, int customer, string alamat, string tanggal)
        {
            this.id = id;
            this.karyawan_id = karyawan_id;
            this.total = total;
            this.customer = customer;
            this.alamat = alamat;
            this.tanggal = tanggal;

        }

        //mendapatkan data hjual pada database
        public static DataTable getAll() 
        {
            DataTable dt = new DataTable();
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM HJUAL", DB.conn);
            MySqlDataAdapter adpt = new MySqlDataAdapter();
            adpt.SelectCommand = cmd;
            adpt.FillAsync(dt);

            return dt;
        }
    }
}
