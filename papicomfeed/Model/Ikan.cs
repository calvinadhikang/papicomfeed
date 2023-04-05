﻿using MySql.Data.MySqlClient;
using papicomfeed.Database;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Windows.Forms;

namespace papicomfeed.Model
{
    public class Ikan
    {
        MySqlCommand cmd;

        public int id;
        public string nama;
        public int waktu;
        public int harga;

        public Ikan(string nama, int waktu, int harga)
        {
            this.nama = nama;
            this.waktu = waktu;
            this.harga = harga;

            string query = $"INSERT INTO IKAN (NAMA, WAKTU, HARGA)VALUES ('{nama}', {waktu}, {harga})";
            cmd = new MySqlCommand(query, DB.conn);
            cmd.ExecuteNonQuery();

            this.id = Convert.ToInt32(cmd.LastInsertedId);
        }


        public Ikan(int id , string nama , int waktu, int harga)
        {
            this.id = id;
            this.nama = nama;
            this.waktu = waktu;
            this.harga = harga;
        }

        public void save()
        {
            string query = $"UPDATE IKAN SET NAMA='{nama}', WAKTU={waktu}, HARGA={harga} WHERE ID={id}";
            cmd = new MySqlCommand(query, DB.conn);
            cmd.ExecuteNonQuery();
        }

        public static bool checkDuplicate(string nama)
        {
            MySqlCommand cmd = new MySqlCommand($"SELECT COUNT(*) FROM IKAN WHERE NAMA='{nama}'", DB.conn);
            int count = int.Parse(cmd.ExecuteScalar().ToString());

            return (count > 0) ? true : false ;
        }

        public static Ikan get(int id)
        {
            DataTable dt = new DataTable();
            MySqlCommand cmd = new MySqlCommand($"SELECT * FROM IKAN WHERE ID = {id}", DB.conn);
            MySqlDataAdapter adpt = new MySqlDataAdapter();
            adpt.SelectCommand = cmd;
            adpt.FillAsync(dt);

            if (dt.Rows.Count <= 0)
            {
                return null;
            }

            string nama = dt.Rows[0][1].ToString();
            int waktu = int.Parse(dt.Rows[0][2].ToString());
            int harga = int.Parse(dt.Rows[0][3].ToString());
            int idikan = id;

            //Ikan i = new Ikan(idikan, nama, waktu);

            return new Ikan(idikan, nama, waktu, harga);
        }

        public static DataTable getAll()
        {
            DataTable dt = new DataTable();
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM IKAN", DB.conn);
            MySqlDataAdapter adpt = new MySqlDataAdapter();
            adpt.SelectCommand = cmd;
            adpt.FillAsync(dt);

            return dt;
        }

    }
}
