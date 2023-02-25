using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using papicomfeed.Database;
using System.Data;

namespace papicomfeed.Model
{
    
    public class Customer
    {
        MySqlCommand cmd;

        public int id;
        public string nama;
        public string telpon;
        public string alamat;

        public Customer(string nama, string alamat, string telpon) {
            this.nama = nama;
            this.alamat = alamat;
            this.telpon = telpon;

            string query = $"INSERT INTO customer(nama, alamat, telp) VALUES ('{nama}', '{alamat}','{telpon}')";
            cmd = new MySqlCommand(query, DB.conn);
            cmd.ExecuteNonQuery();

            this.id = Convert.ToInt32(cmd.LastInsertedId);
        }

        private Customer(int id, string nama, string alamat, string telpon) {
            this.id = id;
            this.nama = nama;
            this.alamat = alamat;
            this.telpon = telpon;
        }

        public static bool checkDouble(string nama) {
            MySqlCommand cmd = new MySqlCommand($"SELECT COUNT(*) FROM customer where nama='{nama}'", DB.conn);
            int count = int.Parse(cmd.ExecuteScalar().ToString());

            return (count > 0) ? true : false;
        }

        public static DataTable getAll() {
            DataTable dt = new DataTable();
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM customer", DB.conn);
            MySqlDataAdapter adapt = new MySqlDataAdapter;
            adapt.SelectCommand = cmd;
            adapt.FillAsync(dt);

            return dt;
        }
    }
}
