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
using System.Drawing.Drawing2D;

namespace papicomfeed.Forms.Master
{
    public partial class FormMasterCustomer : Form
    {
        public FormMasterCustomer()
        {
            InitializeComponent();
            displayData();
        }

        public void displayData(string key = "") {
            dataGridView1.DataSource = Customer.getAll(key);
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            DataTable dt = (DataTable)dataGridView1.DataSource;
            int customerId = int.Parse(dt.Rows[row][0].ToString());

            FormMasterCustomerDetail f = new FormMasterCustomerDetail(customerId, this);
            f.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormMasterCustomerAdd fadd = new FormMasterCustomerAdd(this);
            fadd.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormMasterCustomer_Load(object sender, EventArgs e)
        {
            this.Paint += new PaintEventHandler(FormMasterCustomer_Paint);
        }

        private void FormMasterCustomer_Paint(object sender, PaintEventArgs e)
        {
            // membuat gradient background
            LinearGradientBrush gradient = new LinearGradientBrush(
                this.ClientRectangle,
                Color.FromArgb(255, 135, 206, 250), // biru muda
                Color.FromArgb(255, 25, 25, 112), // biru tua
                120f);
            e.Graphics.FillRectangle(gradient, this.ClientRectangle);
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.BackColor = Color.LightGreen;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.GhostWhite;
        }

        private void tbNamaSearch_TextChanged(object sender, EventArgs e)
        {
            displayData(tbNamaSearch.Text);
        }
    }
}
