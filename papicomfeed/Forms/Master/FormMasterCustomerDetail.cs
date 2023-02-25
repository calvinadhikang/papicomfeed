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
    }
}
