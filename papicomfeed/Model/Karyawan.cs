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
    class Karyawan
    {
        MySqlCommand cmd;
        MySqlDataAdapter adp;

        public int id;
        public string nama;
        public string username;
        public int telp;
        public int role;
        public int status;

        //constructor 1
        //untuk menginsert data karyawan baru ke Database
        public Karyawan(string nama, string username, int telp, int role, int status)
        {
            this.nama = nama;
            this.username = username;
            this.telp = telp;
            this.role = role;
            this.status = status;

            string query = $"INSERT INTO KARYAWAN (NAMA, USERNAME, TELP, ROLE, STATUS)VALUES ('{nama}', '{username}', {telp}, {role}, {status})";
            cmd = new MySqlCommand(query, DB.conn);
            cmd.ExecuteNonQuery();

            this.id = Convert.ToInt32(cmd.LastInsertedId);
        }
        
        //constructor 2
        //untuk membuat class karyawan yang sudah ada
        public Karyawan(int id, string nama, string username, int telp, int role, int status)
        {
            this.id = id;
            this.nama = nama;
            this.username = username;
            this.telp = telp;
            this.role = role;
            this.status = status;
        }

        //untuk update karyawan sesuai dengan
        //properti class
        public void update()
        {
            string query = $"UPDATE KARYAWAN SET " +
                $"NAMA='{this.nama}', " +
                $"USERNAME='{this.username}', " +
                $"TELP={this.telp}, " +
                $"ROLE={this.role}," +
                $"STATUS={this.status}" +
                $"WHERE ID={this.id}";
            cmd = new MySqlCommand(query, DB.conn);
            cmd.ExecuteNonQuery();
        }

        public static void toggleStatus(int id)
        {
            
        }

        //mendapatkan data Karyawan yang sudah ada
        public static Karyawan get(int id)
        {
            DataTable dt = new DataTable();
            MySqlCommand cmd = new MySqlCommand($"SELECT * FROM KARYAWAN WHERE ID = {id}", DB.conn);
            MySqlDataAdapter adpt = new MySqlDataAdapter();
            adpt.SelectCommand = cmd;
            adpt.FillAsync(dt);

            string nama = dt.Rows[0][1].ToString();
            string username = dt.Rows[0][2].ToString();
            int telp = int.Parse(dt.Rows[0][3].ToString());
            int role = int.Parse(dt.Rows[0][4].ToString());
            int status = int.Parse(dt.Rows[0][5].ToString());

            return new Karyawan(id, nama, username, telp, role, status);
        }

        //mendapatkan semua data Karyawan pada sistem
        public static DataTable getAll()
        {
            DataTable dt = new DataTable();
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM KARYAWAN", DB.conn);
            MySqlDataAdapter adpt = new MySqlDataAdapter();
            adpt.SelectCommand = cmd;
            adpt.FillAsync(dt);

            return dt;
        }
    }
}
