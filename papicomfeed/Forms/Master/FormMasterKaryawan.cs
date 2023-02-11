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
    public partial class FormMasterKaryawan : Form
    {
        public FormMasterKaryawan()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            dataGridView1.DataSource = Karyawan.getAll();
        }
    }
}
