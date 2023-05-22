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
    class Supplier
    {
        MySqlCommand cmd;

        public int id;
        public string nama;
        public string telpon;
        public string alamat;
        public DataTable dtIkan;

        public Supplier(string nama, string alamat, string telpon)
        {
            this.nama = nama;
            this.alamat = alamat;
            this.telpon = telpon;

            string query = $"INSERT INTO supplier(nama, alamat, telp) VALUES ('{nama}', '{alamat}','{telpon}')";
            cmd = new MySqlCommand(query, DB.conn);
            cmd.ExecuteNonQuery();

            this.id = Convert.ToInt32(cmd.LastInsertedId);
        }

        private Supplier(int id, string nama, string alamat, string telpon)
        {
            this.id = id;
            this.nama = nama;
            this.alamat = alamat;
            this.telpon = telpon;

            getIkanSupplier(id);
        }

        public static bool checkDouble(string nama)
        {
            MySqlCommand cmd = new MySqlCommand($"SELECT COUNT(*) FROM supplier where nama='{nama}'", DB.conn);
            int count = int.Parse(cmd.ExecuteScalar().ToString());

            return (count > 0) ? true : false;
        }

        public static DataTable getAll(string key = "")
        {
            DataTable dt = new DataTable();
            MySqlCommand cmd;
            if (key == "")
            {
                cmd = new MySqlCommand("SELECT * FROM supplier", DB.conn);
            }
            else
            {
                cmd = new MySqlCommand($"SELECT * FROM supplier WHERE nama LIKE '%{key}%'", DB.conn);
            }
            MySqlDataAdapter adapt = new MySqlDataAdapter();
            adapt.SelectCommand = cmd;
            adapt.FillAsync(dt);

            return dt;
        }

        public static Supplier get(int id)
        {
            DataTable dt = new DataTable();
            MySqlCommand cmd = new MySqlCommand($"SELECT * FROM supplier where id = {id}", DB.conn);
            MySqlDataAdapter adapt = new MySqlDataAdapter();
            adapt.SelectCommand = cmd;
            adapt.FillAsync(dt);

            if (dt.Rows.Count <= 0)
            {
                return null;
            }

            string nama = dt.Rows[0][1].ToString();
            string alamat = dt.Rows[0][2].ToString();
            string telpon = dt.Rows[0][3].ToString();

            return new Supplier(id, nama, alamat, telpon);
        }

        public void getIkanSupplier(int idSupplier)
        {
            DataTable dt = new DataTable();
            MySqlCommand cmd = new MySqlCommand($"SELECT * FROM rsupply where supplier_id = {idSupplier}", DB.conn);
            MySqlDataAdapter adapt = new MySqlDataAdapter();
            adapt.SelectCommand = cmd;
            adapt.FillAsync(dt);

            if (dt.Rows.Count <= 0)
            {
                return;
            }

            DataTable dtIkan = new DataTable();
            foreach (DataRow row in dt.Rows)
            {
                Ikan ikan = Ikan.get(int.Parse(row["ikan_id"].ToString()));

                DataRow dtRow = dtIkan.NewRow();
                dtRow[0] = ikan.id;
                dtRow[1] = ikan.nama;
                dtRow[2] = ikan.waktu;
                dtRow[3] = ikan.harga;

                dtIkan.Rows.Add(dtRow);
            }

            this.dtIkan = dtIkan;
        }

        public void addIkanSupplier(int idSupplier, int idIkan)
        {
            string query = $"INSERT INTO rsupply (ikan_id, supplier_id) VALUES ({idIkan}, {idSupplier})";
            cmd = new MySqlCommand(query, DB.conn);
            cmd.ExecuteNonQuery();
        }

        public void deleteIkanSupplier(int idSupplier, int idIkan)
        {
            string query = $"DELETE rsupply WHERE ikan_id={idIkan} AND supplier_id={idSupplier}";
            cmd = new MySqlCommand(query, DB.conn);
            cmd.ExecuteNonQuery();
        }

        public void save()
        {
            string query = $"UPDATE supplier SET " +
                $"nama ='{this.nama}'," +
                $"alamat ='{this.alamat}'," +
                $"telp ='{this.telpon}'" +
                $"where id ='{this.id}'";
            cmd = new MySqlCommand(query, DB.conn);
            cmd.ExecuteNonQuery();
        }
    }
}
