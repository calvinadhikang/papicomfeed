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
    public partial class FormMasterSupplierDetail : Form
    {
        FormMasterSupplier parent;
        Supplier supplier;

        public FormMasterSupplierDetail(FormMasterSupplier parent, int id)
        {
            InitializeComponent();
            this.parent = parent;
            this.supplier = Supplier.get(id);

            showData();
        }

        void showData()
        {
            tbId.Text = supplier.id.ToString();
            tbNama.Text = supplier.nama;
            tbAlamat.Text = supplier.alamat;
            tbTelp.Text = supplier.telpon;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            supplier.nama = tbNama.Text;
            supplier.alamat = tbAlamat.Text;
            supplier.telpon = tbTelp.Text;
            supplier.save();

            MessageBox.Show("Berhasil Simpan Data");
            parent.displayData();
        }

        private void FormMasterSupplierDetail_Load(object sender, EventArgs e)
        {
            loadIkanSupplier();
            loadComboBoxIkan();
        }

        void loadComboBoxIkan()
        {
            DataTable dtIkan = Ikan.getAll();
            cmbIkan.DataSource = dtIkan;
            cmbIkan.ValueMember = "id";
            cmbIkan.DisplayMember = "nama";
        }

        void loadIkanSupplier()
        {
            this.supplier.getIkanSupplier();
            dgvIkan.DataSource = this.supplier.dtIkan;
        }

        private void btnAddIkan_Click(object sender, EventArgs e)
        {
            int idIkanSelected = int.Parse(cmbIkan.SelectedValue.ToString());
            bool result = this.supplier.addIkanSupplier(idIkanSelected);
            if (!result)
            {
                MessageBox.Show("Ikan sudah ada...");
            }
            else
            {
                MessageBox.Show("Berhasil tambah Ikan...");
            }
            loadIkanSupplier();
        }

        private void btnRemoveIkan_Click(object sender, EventArgs e)
        {
            int idIkanSelected = int.Parse(cmbIkan.SelectedValue.ToString());
            bool result = this.supplier.deleteIkanSupplier(idIkanSelected);
            if (!result)
            {
                MessageBox.Show("Ikan belum ditambahkan...");
            }
            else
            {
                MessageBox.Show("Berhasil hapus Ikan...");
            }
            loadIkanSupplier();
        }
    }
}
