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
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
