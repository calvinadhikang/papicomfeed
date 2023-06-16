using papicomfeed.Model;
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

namespace papicomfeed.Forms.Pembelian
{
    public partial class Pembelian : Form
    {

        DataTable dt;
        public Pembelian()
        {
            InitializeComponent();
            displaydata();
        }

        public void displaydata()
        {
            dt = Hbeli.getAll();
            
            dgvPembelian.DataSource = dt;

            dgvPembelian.Columns["total"].DefaultCellStyle.Format = "N2";


        }

        private void dgvPembelian_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvPembelian_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;

            int id = int.Parse(dt.Rows[row][0].ToString());
            DetailPembelian f = new DetailPembelian(id);
            f.Show();
        }
        //private void dgvPembelian_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    int header = int.Parse(dt.Rows[e.RowIndex][0].ToString());
        //    DetailPembelian f = new DetailPembelian(header);
        //    f.Show();
        //}

        private void Pembelian_Load(object sender, EventArgs e)
        {
            this.Paint += new PaintEventHandler(Pembelian_Paint);
        }

        private void Pembelian_Paint(object sender, PaintEventArgs e)
        {
            // membuat gradient background
            LinearGradientBrush gradient = new LinearGradientBrush(
                this.ClientRectangle,
                Color.FromArgb(255, 25, 25, 112), // biru tua
                Color.FromArgb(255, 135, 206, 250), // biru muda cerah
                -120f);
            e.Graphics.FillRectangle(gradient, this.ClientRectangle);
        }

        
    }
}
