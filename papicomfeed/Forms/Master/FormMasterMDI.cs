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
    public partial class FormMasterMDI : Form
    {
        public FormMasterMDI()
        {
            InitializeComponent();
        }

        private void karyawanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormMasterKaryawan f = new FormMasterKaryawan();
            f.MdiParent = this;
            f.Show();
        }

        private void ikanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormMasterIkan fi = new FormMasterIkan();
            fi.MdiParent = this;
            fi.Show();
        }

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormMasterCustomer fc = new FormMasterCustomer();
            fc.MdiParent = this;
            fc.Show();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }

        private void transaksiToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void penjualanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            papicomfeed.Forms.Penjualan.Penjualan f = new Penjualan.Penjualan();
            f.MdiParent = this;
            f.Show();
        }

        private void kolamToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormMasterKolam f = new FormMasterKolam();
            f.MdiParent = this;
            f.Show();
        }

        private void pembelianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormLaporanPembelian f = new FormLaporanPembelian();
            f.MdiParent = this;
            f.Show();
        }

        private void penjualanToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormLaporanPenjualan f = new FormLaporanPenjualan();
            f.MdiParent = this;
            f.Show();
        }

        private void supplierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormMasterSupplier f = new FormMasterSupplier();
            f.MdiParent = this;
            f.Show();
        }

        private void pembelianToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            papicomfeed.Forms.Pembelian.Pembelian f = new Pembelian.Pembelian();
            f.MdiParent = this;
            f.Show();
        }
    }
}
