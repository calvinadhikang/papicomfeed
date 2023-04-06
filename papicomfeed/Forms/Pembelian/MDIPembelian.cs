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
    public partial class MDIPembelian : Form
    {
        public MDIPembelian()
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
            Pembelian P = new Pembelian();
            P.MdiParent = this;
            P.Show();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }
    }
}
