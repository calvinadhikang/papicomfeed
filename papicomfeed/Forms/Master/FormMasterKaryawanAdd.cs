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
    public partial class FormMasterKaryawanAdd : Form
    {
        FormMasterKaryawan parent;
        public FormMasterKaryawanAdd(FormMasterKaryawan f)
        {
            InitializeComponent();
            parent = f;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string nama = tbNama.Text;
            string username = tbUsername.Text;
            string telp = tbTelp.Text;
            int role = cmbRole.SelectedIndex;
            int status = cbStatus.Checked ? 1 : 0;

            if (nama == "" || username == "" || telp == "" || cmbRole.SelectedIndex == -1)
            {
                MessageBox.Show("Inputan harus di isi");
                return;
            }

            Karyawan k = new Karyawan(nama, username, telp, role, status);
            MessageBox.Show($"Berhasil Tambah Karyawan {nama}");
            parent.displayData();
        }

        private void FormMasterKaryawanAdd_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
