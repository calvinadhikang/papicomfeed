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
using papicomfeed.Forms.Master;

namespace papicomfeed.Forms.Master
{
    public partial class FormMasterKaryawan : Form
    {
        public FormMasterKaryawan()
        {
            InitializeComponent();
            displayData();
        }

        public void displayData()
        {
            DataTable dtKaryawan = Karyawan.getAll();


            //untuk kostumisasi isi dari datatable
            //1. buat datatable, lalu clone dengan sumber data
            //2. ganti datatype columnnya
            //3. isi Datatable Baru dengan foreach dari Datatable Lama, dan lakukan pergantian value disini
            DataTable dt = dtKaryawan.Clone();
            dt.Columns[4].DataType = typeof(string);
            dt.Columns[5].DataType = typeof(string);
         
            foreach (DataRow item in dtKaryawan.Rows)
            {
                //change role text
                //harus punya variabel untuk nampung nilai, tidak bisa langsung ganti variabel item (dataRow)
                string role = "Pemeliharaan";
                if (item[4].ToString() == "0")
                {
                    role = "Admin";
                }
                else if (item[4].ToString() == "1")
                {
                    role = "Penjualan";
                }
                else if (item[4].ToString() == "2")
                {
                    role = "Pembelian";
                }

                //change status text
                string status = "Aktif";
                if (item[5].ToString() == "0")
                {
                    status = "Non - Aktif";
                }

                dt.Rows.Add(new Object[] { item[0], item[1], item[2], item[3], role, status });
            }

            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].HeaderText = "ID";
            dataGridView1.Columns[1].HeaderText = "Nama";
            dataGridView1.Columns[2].HeaderText = "Username";
            dataGridView1.Columns[3].HeaderText = "Nomor Telepon";
            dataGridView1.Columns[4].HeaderText = "Role";
            dataGridView1.Columns[5].HeaderText = "Status";
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            DataTable dt = (DataTable)dataGridView1.DataSource;
            int karyawanId = int.Parse(dt.Rows[row][0].ToString());

            FormMasterKaryawanDetail f = new FormMasterKaryawanDetail(karyawanId, this);
            f.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormMasterKaryawanAdd f = new FormMasterKaryawanAdd(this);
            f.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
