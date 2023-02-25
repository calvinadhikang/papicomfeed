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
    public partial class FormMasterIkanAdd : Form
    {
        FormMasterIkan parent;
        public FormMasterIkanAdd(FormMasterIkan f)
        {
            InitializeComponent();
            parent = f;
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            if (tbNama.Text == "" || tbWaktu.Text == "")
            {
                MessageBox.Show("Inputan tidak boleh kosong");
                return;
            }

            string nama = tbNama.Text;
            int waktu = int.Parse(tbWaktu.Text);

            //cek duplicate
            if (Ikan.checkDuplicate(nama))
            {
                MessageBox.Show("Ikan sudah ada");
                return;
            }

            Ikan k = new Ikan(nama, waktu);
            MessageBox.Show("Berhasil Tambah Ikan " + nama);
            parent.displayData();
        }

        private void btnBackTambahIkan_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }
    }
}
