using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using papicomfeed.Forms.Master;

namespace papicomfeed.Forms.Pemeliharaan
{
    public partial class MDI : Form
    {
        public MDI()
        {
            InitializeComponent();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f = new Form1();
            f.Show();
        }

        private void lihatKolamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormMasterKolam f = new FormMasterKolam();
            f.MdiParent = this;
            f.Show();
        }

        private void lihatGudangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //ViewGudang f = new ViewGudang();
            FormMasterIkan f = new FormMasterIkan();
            f.MdiParent = this;
            f.Show();
        }
    }
}
