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
    public partial class FormMasterSupplierAdd : Form
    {
        FormMasterSupplier parent;
        public FormMasterSupplierAdd(FormMasterSupplier parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            string nama = txtNama.Text;
            string alamat = txtAlamat.Text;
            string telp = txtTelp.Text;

            if (nama == "" || alamat == "" || telp == "")
            {
                MessageBox.Show("Inputan tidak boleh kosong");
                return;
            }

            Supplier s = new Supplier(nama, alamat, telp);
            MessageBox.Show("Berhasil tambah supplier");
            parent.displayData();
        }
    }
}
