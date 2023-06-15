using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
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

        private void FormMasterSupplier_Load(object sender, EventArgs e)
        {
            this.Paint += new PaintEventHandler(FormMasterSupplier_Paint);
        }

        private void FormMasterSupplier_Paint(object sender, PaintEventArgs e)
        {
            // membuat gradient background
            LinearGradientBrush gradient = new LinearGradientBrush(
                this.ClientRectangle,
                Color.FromArgb(255, 135, 206, 250), // biru muda
                Color.FromArgb(255, 25, 25, 112), // biru tua
                120f);
            e.Graphics.FillRectangle(gradient, this.ClientRectangle);
        }
    }
}
