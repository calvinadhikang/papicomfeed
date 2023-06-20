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
    public class Hjual
    {
        MySqlCommand cmd;

        public int id;
        public int karyawan_id;
        public int total;
        public int customer;
        public string alamat;
        public string tanggal;

        // constructor untuk insert data hjual
        public Hjual(int karyawan_id, int total, int customer, string alamat, string tanggal)
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
        private Hjual(int id, int karyawan_id, int total, int customer, string alamat, string tanggal)
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
            MySqlCommand cmd = new MySqlCommand("SELECT HJ.ID AS id," +
                "K.nama AS nama," +
                " HJ.total as total," +
                " C.nama As customer," +
                " HJ.alamat as alamat," +
                " HJ.tanggal as tanggal" +
                " FROM HJUAL HJ " +
                "JOIN KARYAWAN K ON K.ID=HJ.KARYAWAN_ID JOIN CUSTOMER C ON C.ID=HJ.customer", DB.conn);
            MySqlDataAdapter adpt = new MySqlDataAdapter();
            adpt.SelectCommand = cmd;
            adpt.FillAsync(dt);

            return dt;
        }

        public static Hjual get(int id)
        {
            DataTable dt = new DataTable();
            MySqlCommand cmd = new MySqlCommand($"SELECT * FROM HJUAL WHERE ID = {id}", DB.conn);
            MySqlDataAdapter adpt = new MySqlDataAdapter();
            adpt.SelectCommand = cmd;
            adpt.FillAsync(dt);

            if (dt.Rows.Count <= 0)
            {
                return null;
            }

            int karyawan = int.Parse(dt.Rows[0][1].ToString());
            int total = int.Parse(dt.Rows[0][2].ToString());
            int customer = int.Parse(dt.Rows[0][3].ToString());
            string alamat = dt.Rows[0][4].ToString();
            string tanggal = dt.Rows[0][5].ToString();

            //Ikan i = new Ikan(idikan, nama, waktu);

            return new Hjual(id, karyawan, total, customer, alamat, tanggal);
        }
    }
}
