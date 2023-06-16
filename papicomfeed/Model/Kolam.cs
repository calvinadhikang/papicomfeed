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
    class Kolam
    {
        MySqlCommand cmd;

        public int id;
        public string nama;
        public int kapasitas;
        public int status;
        public int dbeli;

        //constructor 1
        //untuk menginsert data karyawan baru ke Database
        public Kolam(string nama, int kapasitas, int status, int dbeli = 0)
        {
            this.nama = nama;
            this.kapasitas = kapasitas;
            this.status = status;
            this.dbeli = dbeli;

            string query = $"INSERT INTO KOLAM (NAMA, KAPASITAS, STATUS, DBELI)VALUES ('{nama}', {kapasitas}, {status}, {dbeli})";
            cmd = new MySqlCommand(query, DB.conn);
            cmd.ExecuteNonQuery();

            this.id = Convert.ToInt32(cmd.LastInsertedId);
        }

        public Kolam(int id, string nama, int kapasitas, int status, int dbeli)
        {
            this.id = id;
            this.nama = nama;
            this.kapasitas = kapasitas;
            this.status = status;
            this.dbeli = dbeli;
        }

        //untuk update karyawan sesuai dengan
        //properti class
        public int save()
        {
            string query = $"UPDATE KOLAM SET " +
                $"NAMA='{this.nama}', " +
                $"KAPASITAS={this.kapasitas}, " +
                $"STATUS={this.status} " +
                $"DBELI={this.dbeli} " +
                $"WHERE ID={this.id}";
            cmd = new MySqlCommand(query, DB.conn);
            return cmd.ExecuteNonQuery();
        }

        public static Kolam get(int id)
        {
            DataTable dt = new DataTable();
            MySqlCommand cmd = new MySqlCommand($"SELECT * FROM KOLAM WHERE ID = {id}", DB.conn);
            MySqlDataAdapter adpt = new MySqlDataAdapter();
            adpt.SelectCommand = cmd;
            adpt.FillAsync(dt);

            if (dt.Rows.Count <= 0)
            {
                return null;
            }

            string nama = dt.Rows[0][1].ToString();
            int kapasitas = int.Parse(dt.Rows[0][2].ToString());
            int status = int.Parse(dt.Rows[0][3].ToString());
            int dbeli = int.Parse(dt.Rows[0][4].ToString());

            return new Kolam(id, nama, kapasitas, status, dbeli);
        }

        public static DataTable getAll(string key = "")
        {
            DataTable dt = new DataTable();
            MySqlCommand cmd;
            if (key == "")
            {
                cmd = new MySqlCommand("SELECT * FROM kolam", DB.conn);
            }
            else
            {
                cmd = new MySqlCommand($"SELECT * FROM kolam WHERE nama LIKE '%{key}%'", DB.conn);
            }
            MySqlDataAdapter adpt = new MySqlDataAdapter();
            adpt.SelectCommand = cmd;
            adpt.FillAsync(dt);

            return dt;
        }
    }
}
