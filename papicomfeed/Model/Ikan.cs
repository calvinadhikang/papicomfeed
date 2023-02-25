using MySql.Data.MySqlClient;
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


        public Ikan(string nama, int waktu)
        {
            this.nama = nama;
            this.waktu = waktu;
            

            string query = $"INSERT INTO IKAN (NAMA, WAKTU)VALUES ('{nama}', {waktu})";
            cmd = new MySqlCommand(query, DB.conn);
            cmd.ExecuteNonQuery();

            this.id = Convert.ToInt32(cmd.LastInsertedId);
        }


        private Ikan(int id , string nama , int waktu)
        {
            this.id = id;
            this.nama = nama;
            this.waktu = waktu;
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
            int idikan = id;

            //Ikan i = new Ikan(idikan, nama, waktu);

            return new Ikan(idikan, nama, waktu);
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
