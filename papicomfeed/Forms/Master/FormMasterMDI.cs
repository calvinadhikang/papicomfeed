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
    }
}
