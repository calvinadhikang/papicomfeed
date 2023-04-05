using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using papicomfeed.Database;
using papicomfeed.Model;
using papicomfeed.Forms.Master;
using papicomfeed.Forms.Penjualan;
using papicomfeed.Forms.Pembelian;

namespace papicomfeed
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            openConnectionDatabase();
        }

        public static int idKaryawan = -1;

        //untuk membuka koneksi ke database saat
        //program pertama kali jalan
        void openConnectionDatabase()
        {
            try
            {
                DB.Open();
            }
            catch (Exception e)
            {
                //MessageBox.Show("Error DB Connection :" + e.Message.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            if (username == "admin")
            {
                FormMasterMDI f = new FormMasterMDI();
                f.Show();
                this.Hide();
                return;
            }

            Karyawan k = Karyawan.get(username);
            if (k == null)
            {
                MessageBox.Show("Username tidak ditemukan");
                return;
            }

            idKaryawan = k.id;
            //cek role
            if (k.role == 0)
            {
                FormMasterMDI f = new FormMasterMDI();
                f.Show();
                this.Hide();
            }
            else if (k.role == 1) {
                MDIPenjualan m = new MDIPenjualan();
                m.Show();
                this.Hide();
            }
            else if (k.role == 2)
            {
                MDIPembelian f = new MDIPembelian();
                f.Show();
                this.Hide();
            }
        }
    }
}
