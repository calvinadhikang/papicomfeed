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

        public static DataTable getAll(string key = "") {
            DataTable dt = new DataTable();
            MySqlCommand cmd;
            if (key == "")
            {
                cmd = new MySqlCommand("SELECT * FROM customer", DB.conn);
            }
            else
            {
                cmd = new MySqlCommand($"SELECT * FROM customer WHERE nama LIKE '%{key}%'", DB.conn);
            }
            MySqlDataAdapter adapt = new MySqlDataAdapter();
            adapt.SelectCommand = cmd;
            adapt.FillAsync(dt);

            return dt;
        }

        public static Customer get(int id) {
            DataTable dt = new DataTable();
            MySqlCommand cmd = new MySqlCommand($"SELECT * FROM customer where id = {id}", DB.conn);
            MySqlDataAdapter adapt = new MySqlDataAdapter();
            adapt.SelectCommand = cmd;
            adapt.FillAsync(dt);

            if (dt.Rows.Count <= 0) {
                return null;
            }

            string nama = dt.Rows[0][1].ToString();
            string alamat = dt.Rows[0][2].ToString();
            string telpon = dt.Rows[0][3].ToString();

            return new Customer(id, nama, alamat, telpon);
        }

        public void save() {
            string query = $"UPDATE customer SET " +
                $"nama ='{this.nama}'," +
                $"alamat ='{this.alamat}'," +
                $"telp ='{this.telpon}'" +
                $"where id ='{this.id}'";
            cmd = new MySqlCommand(query, DB.conn);
            cmd.ExecuteNonQuery();
        }
    }
}
