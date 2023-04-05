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
using MySql.Data.MySqlClient;
using papicomfeed.Database;

namespace papicomfeed.Forms.Penjualan
{
    public partial class Tambah : Form
    {
        MySqlCommand cmd;
        MySqlDataReader reader;

        string alamat;
        string customer;
        int telp;
        int total = 0;

        int selectedIkanIndex = -1;
        Customer selectedCustomer = null;

        DataTable dtIkan;
        DataTable dtCustomer;
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
            dt.Columns.Add("ID Ikan");
            dt.Columns.Add("Jenis Ikan");
            dt.Columns.Add("Quantity");
            dt.Columns.Add("Harga");
            dt.Columns.Add("SubTotal");

            //tambah button tambah
            DataGridViewButtonColumn btnAdd = new DataGridViewButtonColumn();
            btnAdd.Name = "Tambah";
            btnAdd.Text = "Tambah";
            if (dgvTambahJual.Columns["Tambah"] == null)
            {
                dgvTambahJual.Columns.Insert(5, btnAdd);
                //5 adalah columnIndex
            }
            //tambah button kurangi
            DataGridViewButtonColumn btnRemove = new DataGridViewButtonColumn();
            btnRemove.Name = "Kurangi";
            btnRemove.Text = "Kurangi";
            if (dgvTambahJual.Columns["Kurangi"] == null)
            {
                dgvTambahJual.Columns.Insert(6, btnRemove);
                //6 adalah columnIndex
            }
        }

        void countTotal()
        {
            total = 0;
            foreach (DataRow item in dt.Rows)
            {
                total += int.Parse(item[4].ToString());
            }
            lbTotal.Text = total.ToString();
        }

        private void btnTambah(object sender, EventArgs e)
        {
            if (selectedIkanIndex != -1)
            {
                int id = int.Parse(dtIkan.Rows[selectedIkanIndex][0].ToString());
                string nama = dtIkan.Rows[selectedIkanIndex][1].ToString();
                int qty = int.Parse(nudJumlah.Value.ToString());
                int harga = int.Parse(dtIkan.Rows[selectedIkanIndex][3].ToString());
                int subtotal = qty * harga;

                if (qty <= 0)
                {
                    MessageBox.Show("QTY tidak boleh kurang dari 1");
                    return;
                }

                DataRow dtR = dt.NewRow();
                dtR[0] = id;
                dtR[1] = nama;
                dtR[2] = qty;
                dtR[3] = harga;
                dtR[4] = subtotal;
                dt.Rows.Add(dtR);

                selectedIkanIndex = -1;
                countTotal();
            }
            else
            {
                MessageBox.Show("Pilih data");
            }
        }

        private void dgvTambahJual_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            int oldQty = int.Parse(dt.Rows[row][2].ToString());

            if (e.ColumnIndex == 0 && row > -1)
            {
                //lakukan tambah qty
                oldQty += 1;
            }
            else
            {
                //lakukan pengurangan qty
                oldQty -= 1;
                //kalau qty = 0
                if (oldQty == 0)
                {
                    dt.Rows.RemoveAt(row);
                    countTotal();
                    return;
                }
            }

            int harga = int.Parse(dt.Rows[row][3].ToString());
            int subtotal = oldQty * harga;

            //set value baru
            dt.Rows[row][2] = oldQty;
            dt.Rows[row][4] = subtotal;
            countTotal();
        }

        public void isiCmbCustomer() 
        {
            cmbCustomer.Items.Clear();
            try
            {
                dtCustomer = Customer.getAll();
                Dictionary<int, string> cmbCustomerSource = new Dictionary<int, string>();

                foreach (DataRow row in dtCustomer.Rows)
                {
                    cmbCustomerSource.Add(int.Parse(row[0].ToString()), row[1].ToString());
                }

                cmbCustomer.DataSource = new BindingSource(cmbCustomerSource, null);
                cmbCustomer.DisplayMember = "Value";
                cmbCustomer.ValueMember = "Key";

                //MySqlCommand cmd = new MySqlCommand("select * from customer", DB.conn);
                //reader = cmd.ExecuteReader();

                //if (reader.HasRows) 
                //{
                //    while (reader.Read()) 
                //    {
                //        cmbCustomer.Items.Add(reader[1].ToString());
                //    }
                //}
                //reader.Close();
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
                dtIkan = Ikan.getAll();
                Dictionary<int, string> cmbIkanSource = new Dictionary<int, string>();

                int i = 0;
                foreach (DataRow row in dtIkan.Rows)
                {
                    cmbIkanSource.Add(i, row[1].ToString());
                    i++;
                }

                cmbIkan.DataSource = new BindingSource(cmbIkanSource, null);
                cmbIkan.DisplayMember = "Value";
                cmbIkan.ValueMember = "Key";
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
                //MySqlCommand query = new MySqlCommand("select alamat from customer where nama = '" + cmbCustomer.Text + "'",DB.conn);
                //alamat = query.ExecuteScalar().ToString();
                //lblAlamat.Text = alamat;

                //MySqlCommand query2 = new MySqlCommand("select telp from customer where nama = '"+cmbCustomer.Text+"'", DB.conn);
                //telp = Convert.ToInt32(query2.ExecuteScalar());
                //lblTelp.Text = telp.ToString();

                //pilih_customer = true;
                //customer = cmbCustomer.Text;

                int key = ((KeyValuePair<int, string>)cmbCustomer.SelectedItem).Key;
                selectedCustomer = Customer.get(key);
                lblAlamat.Text = selectedCustomer.alamat;
                lblTelp.Text = selectedCustomer.telpon;
            }
        }

        private void cmbIkan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbIkan.SelectedIndex > -1)
            {
                int key = ((KeyValuePair<int, string>)cmbIkan.SelectedItem).Key;
                string value = ((KeyValuePair<int, string>)cmbIkan.SelectedItem).Value;
                selectedIkanIndex = key;
            }
        }

        private void btnAddPenjualan_Click(object sender, EventArgs e)
        {
            MySqlTransaction trans = null;

            try
            {
                trans = DB.conn.BeginTransaction();

                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = DB.conn;
                cmd.Transaction = trans;

                //insert header
                cmd.CommandText = $"INSERT INTO HJUAL (KARYAWAN_ID, TOTAL, CUSTOMER, ALAMAT) VALUES ({Form1.idKaryawan}, {total}, {selectedCustomer.id}, '{selectedCustomer.alamat}')";
                cmd.ExecuteNonQuery();
                int headerId = Convert.ToInt32(cmd.LastInsertedId);

                //insert detail
                foreach (DataRow item in dt.Rows)
                {
                    int ikanId = int.Parse(item[0].ToString());
                    int qty = int.Parse(item[2].ToString());
                    int harga = int.Parse(item[3].ToString());
                    int subtotal = int.Parse(item[4].ToString());

                    cmd.CommandText = $"INSERT INTO DJUAL (HJUAL_ID, IKAN_ID, QTY, HARGA, SUBTOTAL) VALUES ({headerId}, {ikanId}, {qty}, {harga}, {subtotal})";
                    cmd.ExecuteNonQuery();
                }

                trans.Commit();
                MessageBox.Show($"Berhasil Insert Penjualan {selectedCustomer.nama}");
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                trans.Rollback();
            }
        }
    }
}
