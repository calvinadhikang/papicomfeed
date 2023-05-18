using MySql.Data.MySqlClient;
using papicomfeed.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace papicomfeed.Forms.Master
{
    public partial class FormLaporanPenjualan : Form
        

    {

        String dtawal;
        String dtakhir;
        public FormLaporanPenjualan()
        {
            InitializeComponent();
        }


        public void generate()
        {
            dtawal = dttglawalpenjualan.Value.ToString("dd-MM-yyyy");
            dtakhir = dttglakhirpenjualan.Value.ToString("dd-MM-yyyy");


            DataSetpenjualan dspenjualan = new DataSetpenjualan(); 

            MySqlCommand query  = new MySqlCommand();

            query.Connection = DB.conn;

            MySqlDataAdapter adapter = new MySqlDataAdapter(query);

            query.CommandText = $"Select * from DJual where tanggal >= STR_TO_DATE('{dtawal}', '%d-%m-%Y') and tanggal <= STR_TO_DATE('{dtakhir}', '%d-%m-%Y')";
            adapter.Fill(dspenjualan, "DJual");


            ReportPenjualan report = new ReportPenjualan(); 

            report.SetDataSource(dspenjualan);
            report.SetParameterValue("tglawal", dttglawalpenjualan.Value.ToString("dd-MMMM-yyyy"));
            report.SetParameterValue("tglakhir", dttglakhirpenjualan.Value.ToString("dd-MMMM-yyyy"));



            crystalReportvpenjualan.ReportSource= report;




        }

        private void btngenerate_Click(object sender, EventArgs e)
        {

            generate();
        }
    }
}
