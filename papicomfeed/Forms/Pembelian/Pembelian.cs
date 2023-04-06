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
            dt = hbeli.getAll();
            dgvPembelian.DataSource = dt;
        }

        private void dgvPembelian_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
