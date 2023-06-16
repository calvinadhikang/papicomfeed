using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

using papicomfeed.Model;

namespace papicomfeed.Forms.Penjualan
{
    public partial class DetailPenjualan : Form
    {
        Hjual header;
        Karyawan karyawan;
        Customer customer;

        public DetailPenjualan(int id)
        {
            InitializeComponent();
            header = Hjual.get(id);
            karyawan = Karyawan.get(header.karyawan_id);
            customer = Customer.get(header.customer);

            showHeader();
        }

        void showHeader()
        {
            lbKode.Text = header.id.ToString();
            lbTanggal.Text = header.tanggal;
            lbAlamat.Text = header.alamat;
            lbTotal.Text = header.total.ToString();
            lbKaryawan.Text = karyawan.nama;
            lbNama.Text = customer.nama;

            showDetail();
        }

        void showDetail()
        {
            DataTable dt = Djual.get(header.id);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns["harga"].DefaultCellStyle.Format = "N2";
            dataGridView1.Columns["subtotal"].DefaultCellStyle.Format = "N2";
        }

        private void DetailPenjualan_Load(object sender, EventArgs e)
        {
            this.Paint += new PaintEventHandler(DetailPenjualan_Paint);
        }

        private void DetailPenjualan_Paint(object sender, PaintEventArgs e)
        {
            // membuat gradient background
            LinearGradientBrush gradient = new LinearGradientBrush(
                this.ClientRectangle,
                Color.FromArgb(255, 25, 25, 112), // biru tua
                Color.FromArgb(255, 135, 206, 250), // biru muda cerah
                -120f);
            e.Graphics.FillRectangle(gradient, this.ClientRectangle);
        }

        private void lbKaryawan_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lbKode_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void lbTotal_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void lbNama_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void lbAlamat_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void lbTanggal_Click(object sender, EventArgs e)
        {

        }
    }
}
