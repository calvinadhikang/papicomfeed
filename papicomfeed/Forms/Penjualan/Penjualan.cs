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
using System.Globalization;
using papicomfeed.Model;

namespace papicomfeed.Forms.Penjualan
{
    public partial class Penjualan : Form
    {
        DataTable dt;
        public Penjualan()
        {
            InitializeComponent();
            displayData();
        }

        public void displayData()
        {
            dt = Hjual.getAll();
            dataGridView1.DataSource = dt;
            dataGridView1.Columns["total"].DefaultCellStyle.Format = "C";
            
            dataGridView1.Columns["id"].Visible= false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;

            int id = int.Parse(dt.Rows[row][0].ToString());
            DetailPenjualan f = new DetailPenjualan(id);
            f.Show();
        }

        private void Penjualan_Load(object sender, EventArgs e)
        {
            this.Paint += new PaintEventHandler(Penjualan_Paint);
        }

        private void Penjualan_Paint(object sender, PaintEventArgs e)
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
