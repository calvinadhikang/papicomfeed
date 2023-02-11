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

namespace papicomfeed
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            openConnectionDatabase();

            FormMasterKaryawan f = new FormMasterKaryawan();
            f.Show();
        }

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
                MessageBox.Show("Error DB Connection :" + e.Message.ToString());
            }
        }
    }
}
