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
    public partial class FormMasterCustomerAdd : Form
    {
        FormMasterCustomer parent;
        public FormMasterCustomerAdd(FormMasterCustomer c)
        {
            InitializeComponent();
            parent = c;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtNama.Text == "" || txtAlamat.Text == "" || txtTelp.Text == "") 
            {
                MessageBox.Show("Inputan tidak boleh kosong");
                return;
            }

            string nama = txtNama.Text;
            string alamat = txtAlamat.Text;
            string telp = txtTelp.Text.ToString();

            Customer c = new Customer(nama, alamat, telp);
            MessageBox.Show("Berhasil Menambahkan Customer");
            parent.displayData();
        }

        private void FormMasterCustomerAdd_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
