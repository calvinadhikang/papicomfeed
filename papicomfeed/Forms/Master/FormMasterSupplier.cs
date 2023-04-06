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

namespace papicomfeed.Forms.Master
{
    public partial class FormMasterSupplier : Form
    {
        public FormMasterSupplier()
        {
            InitializeComponent();
            displayData();
        }
        string key = "";

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            key = textBox1.Text;
            displayData();
        }

        public void displayData()
        {
            dgvSupplier.DataSource = Supplier.getAll(key);
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            FormMasterSupplierAdd f = new FormMasterSupplierAdd(this);
            f.Show();
        }

        private void dgvSupplier_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataTable dt = (DataTable)dgvSupplier.DataSource;
            int idx = e.RowIndex;
            int id = int.Parse(dt.Rows[idx][0].ToString());

            FormMasterSupplierDetail f = new FormMasterSupplierDetail(this, id);
            f.Show();
        }
    }
}
