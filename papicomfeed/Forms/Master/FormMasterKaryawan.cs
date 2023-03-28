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
            dataGridView1.DataSource = Karyawan.getAll();
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
    }
}
