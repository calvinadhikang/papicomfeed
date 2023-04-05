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
    public partial class FormMasterKolam : Form
    {
        DataTable dt;
        public FormMasterKolam()
        {
            InitializeComponent();
        }

        private void FormMasterKolam_Load(object sender, EventArgs e)
        {
            displayData();
        }

        public void displayData()
        {
            dt = Kolam.getAll();
            dataGridView1.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormMasterKolamAdd f = new FormMasterKolamAdd(this);
            f.Show();
        }

        int idKolam = -1;
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int idxRow = e.RowIndex;
            idKolam = int.Parse(dt.Rows[idxRow][0].ToString());

            FormMasterKolamDetail f = new FormMasterKolamDetail(idKolam, this);
            f.Show();
        }
    }
}
