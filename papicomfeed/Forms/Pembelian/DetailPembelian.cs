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

namespace papicomfeed.Forms.Pembelian
{
    public partial class DetailPembelian : Form
    {
        Hbeli header;
        Karyawan karyawan;
        DBeli detail;
        public DetailPembelian(int id)
        {
            InitializeComponent();
            header = Hbeli.get(id);
            karyawan = Karyawan.get(header.karyawan_id);

            showHeader();
        }

        void showHeader()
        {
            lbKode.Text = header.id.ToString();
            lbTotal.Text = header.total.ToString();
            lbTanggal.Text = header.tanggal.ToString();
            lbNama.Text = header.penjual.ToString();
            lbAlamat.Text = header.penjual.ToString();
            lbKaryawan.Text = karyawan.nama.ToString();

            showDetail();
        }

        void showDetail()
        {
            dataGridView1.DataSource = DBeli.get(header.id);
        }
    }
}
