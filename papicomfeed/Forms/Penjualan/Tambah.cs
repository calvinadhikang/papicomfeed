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
        string jenis_ikan;
        string customer;
        int telp;
        bool pilih_customer = false;
        bool pilih_ikan = false;
        DataTable dt;
        public Tambah()
        {
            InitializeComponent();
            isiCmbCustomer();
            isiCmbIkan();
            siap2();
        }
        public void siap2() 
        {
            dt = new DataTable();
            dgvTambahJual.DataSource = dt;
            //dgvTambahJual.Columns[0].HeaderText = "Customer";
            //dgvTambahJual.Columns[1].HeaderText = "Jenis Ikan";
            //dgvTambahJual.Columns[2].HeaderText = "Quantity";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int qty = Convert.ToInt32(nudJumlah.Value);
            if (pilih_customer == false) {
                MessageBox.Show("Pilih customer terlebih dahulu");
            }
            else {
                if (pilih_ikan == false)
                {
                    MessageBox.Show("Pilih jenis ikan terlebih dahulu");
                }
                else {
                    if (qty < 1)
                    {
                        MessageBox.Show("Input quantity tidak valid");
                    }
                    else 
                    {
                        int idx = -1;
                        // untuk nambah penjualan
                        for (int i = 0; i < dgvTambahJual.Rows.Count; i++)
                        {
                            if (dgvTambahJual.Rows[i].Cells[1].Value.ToString() == jenis_ikan)
                            {
                                idx = i;
                            }
                        }

                        if (idx == -1)
                        {
                            DataRow dtbaru = dt.NewRow();
                            dtbaru[0] = customer;
                            dtbaru[1] = jenis_ikan;
                            dtbaru[2] = qty;

                            dt.Rows.Add(dtbaru);
                            MessageBox.Show("Berhasil menambahkan item");
                        }
                        else {
                            dt.Rows[idx][2] = Convert.ToInt32(dt.Rows[idx][2]) + qty;
                            MessageBox.Show("Berhasil update quantity");
                        }
                    }

                }
            }
        }

        public void isiCmbCustomer() 
        {
            cmbCustomer.Items.Clear();
            cmbCustomer.Items.Add("None");
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

                pilih_customer = true;
                customer = cmbCustomer.Text;
            }
        }

        private void dgvTambahJual_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cmbIkan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbIkan.SelectedIndex > -1)
            {
                jenis_ikan = cmbIkan.Text;
                pilih_ikan = true;
            }
        }
    }
}
