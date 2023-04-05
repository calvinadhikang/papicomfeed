using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using papicomfeed.Model;
using System.Data;
using MySql.Data.MySqlClient;
using papicomfeed.Database;

namespace papicomfeed.Forms.Penjualan
{
    public partial class Tambah : Form
    {
        MySqlCommand cmd;
        MySqlDataReader reader;

        string alamat;
        int telp;
        public Tambah()
        {
            InitializeComponent();
            isiCmbCustomer();
            isiCmbIkan();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // untuk nambah penjualan
        }

        public void isiCmbCustomer() 
        {
            cmbCustomer.Items.Clear();
            try
            {
                MySqlCommand cmd = new MySqlCommand("select * from customer", DB.conn);
                reader = cmd.ExecuteReader();

                if (reader.HasRows) 
                {
                    while (reader.Read()) 
                    {
                        cmbCustomer.Items.Add(reader[1].ToString());
                    }
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + " ");
            }
        }

        public void isiCmbIkan() 
        {
            cmbIkan.Items.Clear();
            try
            {
                MySqlCommand cmd = new MySqlCommand("select * from ikan", DB.conn);
                reader = cmd.ExecuteReader();
                if (reader.HasRows) 
                {
                    while (reader.Read()) 
                    {
                        cmbIkan.Items.Add(reader[1].ToString());
                    }
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + " ");
            }
        }

        private void cmbCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCustomer.SelectedIndex > -1) 
            {
                MySqlCommand query = new MySqlCommand("select alamat from customer where nama = '" + cmbCustomer.Text + "'",DB.conn);
                alamat = query.ExecuteScalar().ToString();
                lblAlamat.Text = alamat;

                MySqlCommand query2 = new MySqlCommand("select telp from customer where nama = '"+cmbCustomer.Text+"'", DB.conn);
                telp = Convert.ToInt32(query2.ExecuteScalar());
                lblTelp.Text = telp.ToString();
            }
        }
    }
}
