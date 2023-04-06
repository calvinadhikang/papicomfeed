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
    public class Djual
    {
        MySqlCommand cmd;

        int id;
        int hjual_id;
        int ikan_id;
        int qty;
        int harga;
        int subtotal;

        //membuat class djual yang sudah ada
        private Djual(int id, int hjual_id, int ikan_id, int qty, int harga, int subtotal) 
        {
            this.id = id;
            this.hjual_id = hjual_id;
            this.ikan_id = ikan_id;
            this.qty = qty;
            this.harga = harga;
            this.subtotal = subtotal;
        }

        // constructoor untuk insert data djual
        public Djual(int hjual_id, int ikan_id, int qty, int harga, int subtotal)
        {
            this.hjual_id = hjual_id;
            this.ikan_id = ikan_id;
            this.qty = qty;
            this.harga = harga;
            this.subtotal = subtotal;

            string query = $"insert into djual (hjual_id, ikan_id, qty, harga, subtotal ) values('{hjual_id}','{ikan_id}','{qty}','{harga}','{subtotal}')";
            cmd = new MySqlCommand(query, DB.conn);
            cmd.ExecuteNonQuery();

            this.id = Convert.ToInt32(cmd.LastInsertedId);
        }

        // mendapatkan data djual pada database
        public static DataTable get(int hjual_id)
        {
            DataTable dt = new DataTable();
            MySqlCommand cmd = new MySqlCommand($"Select * from djual where hjual_id = {hjual_id}", DB.conn);
            MySqlDataAdapter adpt = new MySqlDataAdapter();
            adpt.SelectCommand = cmd;
            adpt.FillAsync(dt);

            if (dt.Rows.Count <= 0) 
            {
                return null;
            }

            return dt;

            //int id_jual = Convert.ToInt32(dt.Rows[0][1]);
            //int id_ikan = Convert.ToInt32(dt.Rows[0][2]);
            //int id_djual = Convert.ToInt32(dt.Rows[0][0]);
            //int qty = Convert.ToInt32(dt.Rows[0][3]);
            //int harga = Convert.ToInt32(dt.Rows[0][4]);
            //int subtotal = Convert.ToInt32(dt.Rows[0][5]);

            //return new Djual(id_jual, id_ikan, qty, harga, subtotal);
        }
    }
}
