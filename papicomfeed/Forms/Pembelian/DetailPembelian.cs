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
using System.Drawing.Drawing2D;

namespace papicomfeed.Forms.Pembelian
{
    public partial class DetailPembelian : Form
    {
        Hbeli header;
        Karyawan karyawan;
        
        public DetailPembelian(int id)
        {
            InitializeComponent();
            header = Hbeli.get(id);
            karyawan = Karyawan.get(header.karyawan_id);

            showHeader();
        }

        void showHeader()
        {
            
            lbTotal.Text = header.total.ToString();
            lbTanggal.Text = header.tanggal.ToString();
            lbNama.Text = header.penjual.ToString();
            lbAlamat.Text = header.alamat.ToString();
            lbKaryawan.Text = karyawan.nama.ToString();

            labeldetailpembelian.Text = "Detail Pembelian  "+ header.id.ToString();

            showDetail();
        }

        void showDetail()
        {
            dataGridView1.DataSource = DBeli.get(header.id);

            dataGridView1.Columns["nama_ikan"].DisplayIndex = 0;
            dataGridView1.Columns["nama_ikan"].HeaderText = "Ikan";

            dataGridView1.Columns["id"].Visible = false;
            dataGridView1.Columns["hbeli_id"].Visible = false;
            dataGridView1.Columns["kolam_id"].Visible = false;
            dataGridView1.Columns["ikan_id"].Visible = false;
            
            

            dataGridView1.Columns["harga"].DefaultCellStyle.Format = "C";
            dataGridView1.Columns["subtotal"].DefaultCellStyle.Format = "C";
        }

        private void DetailPembelian_Load(object sender, EventArgs e)
        {
            this.Paint += new PaintEventHandler(DetailPembelian_Paint);
        }

        private void DetailPembelian_Paint(object sender, PaintEventArgs e)
        {
            // membuat gradient background
            LinearGradientBrush gradient = new LinearGradientBrush(
                this.ClientRectangle,
                Color.FromArgb(255, 25, 25, 112), // biru tua
                Color.FromArgb(255, 135, 206, 250), // biru muda cerah
                -120f);
            e.Graphics.FillRectangle(gradient, this.ClientRectangle);
        }

        private void lbNama_Click(object sender, EventArgs e)
        {

        }
    }
}
