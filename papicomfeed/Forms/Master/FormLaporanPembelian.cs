using MySql.Data.MySqlClient;
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
using CrystalDecisions.Shared;
using papicomfeed.Database;
using System.Runtime.InteropServices.ComTypes;

namespace papicomfeed.Forms.Master
{
    public partial class FormLaporanPembelian : Form
    {

        String dtawal;
        String dtakhir;


        public FormLaporanPembelian()
        {
            InitializeComponent();
            
        }

        public void generate()
        {


            
            dtawal = dttglawal.Value.ToString("dd-MM-yyyy");
            dtakhir = dttglakhir.Value.ToString("dd-MM-yyyy");





            DataSetpembelian dspembelian = new DataSetpembelian();

            MySqlCommand query = new MySqlCommand();

            query.Connection = DB.conn;

            MySqlDataAdapter adapter = new MySqlDataAdapter(query);

            query.CommandText = $"Select * from Dbeli where tanggal >= STR_TO_DATE('{dtawal}', '%d-%m-%Y') and tanggal <= STR_TO_DATE('{dtakhir}', '%d-%m-%Y')";
            adapter.Fill(dspembelian, "DBeli");


            reportpembelian report = new reportpembelian();



            //report.Load("E:\\FOLDER_KULIAH\\SEMESTER_6\\Proyek_Bisnis\\papicomfeed\\papicomfeed\\Forms\\Master\\reportpembelian.rpt");
            //report.SetDataSource(DBeli.getAll());

            report.SetDataSource(dspembelian);
            report.SetParameterValue("tanggalawal", dttglawal.Value.ToString("dd-MMMM-yyyy"));
            report.SetParameterValue("tanggalakhir", dttglakhir.Value.ToString("dd-MMMM-yyyy"));
            







            crystalReportViewer1.ReportSource = report;
            

            

                
        }

        private void btngenerate_Click(object sender, EventArgs e)
        {

            generate();
        }
    }
}
