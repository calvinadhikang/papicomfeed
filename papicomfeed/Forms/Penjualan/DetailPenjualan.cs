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

namespace papicomfeed.Forms.Penjualan
{
    public partial class DetailPenjualan : Form
    {
        Hjual header;
        Karyawan karyawan;
        Customer customer;

        public DetailPenjualan(int id)
        {
            InitializeComponent();
            header = Hjual.get(id);
            karyawan = Karyawan.get(header.karyawan_id);
            customer = Customer.get(header.customer);

            showHeader();
        }

        void showHeader()
        {
            lbKode.Text = header.id.ToString();
            lbTanggal.Text = header.tanggal;
            lbAlamat.Text = header.alamat;
            lbTotal.Text = header.total.ToString();
            lbKaryawan.Text = karyawan.nama;
            lbNama.Text = customer.nama;

            showDetail();
        }

        void showDetail()
        {
            DataTable dt = Djual.get(header.id);
            dataGridView1.DataSource = dt;
        }
    }
}
