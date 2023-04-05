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
    public partial class MDIPenjualan : Form
    {
        public MDIPenjualan()
        {
            InitializeComponent();
        }

        private void tambahToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tambah T = new Tambah();
            T.MdiParent = this;
            T.Show();
        }

        private void lihatDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Penjualan p = new Penjualan();
            p.MdiParent = this;
            p.Show();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }
    }
}
