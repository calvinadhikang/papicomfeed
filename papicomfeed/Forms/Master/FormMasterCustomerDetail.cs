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
using papicomfeed.Forms.Master;
using System.Drawing.Drawing2D;

namespace papicomfeed.Forms.Master
{
    public partial class FormMasterCustomerDetail : Form
    {
        Customer c;
        FormMasterCustomer parent; 
        public FormMasterCustomerDetail(int id, FormMasterCustomer parent)
        {
            InitializeComponent();
            this.c = Customer.get(id);
            this.parent = parent;

            setValue();
        }

        void setValue() {
            txtId.Text = c.id.ToString();
            txtNamaCustomer.Text = c.nama;
            txtAlamatCustomer.Text = c.alamat;
            txtTelpCustomer.Text = c.telpon.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            c.id = int.Parse(txtId.Text);
            c.nama = txtNamaCustomer.Text;
            c.alamat = txtAlamatCustomer.Text;
            c.telpon = txtTelpCustomer.Text;

            c.save();

            this.parent.displayData();
            MessageBox.Show("Updated");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.parent.Show();
        }

        private void FormMasterCustomerDetail_Load(object sender, EventArgs e)
        {
            this.Paint += new PaintEventHandler(FormMasterCustomerDetail_Paint);
        }

        private void FormMasterCustomerDetail_Paint(object sender, PaintEventArgs e)
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
            button1.BackColor = Color.Red;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.GhostWhite;
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            button2.BackColor = Color.LightGreen;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = Color.GhostWhite;
        }
    }
}
