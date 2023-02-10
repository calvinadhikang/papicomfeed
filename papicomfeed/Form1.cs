using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MySql.Data.MySqlClient;
using papicomfeed.Database;

namespace papicomfeed
{
    public partial class Form1 : Form
    {
        MySqlConnection conn;
        MySqlCommand cmd;

        public Form1()
        {
            InitializeComponent();

            try
            {
                conn = new MySqlConnection(Connection.connString);
                conn.Open();

                cmd = new MySqlCommand("select count(*) from karyawan", conn);
                string data = cmd.ExecuteScalar().ToString();
                MessageBox.Show(data);
            }
            catch (Exception e)
            {
                MessageBox.Show("Error :" + e.Message.ToString());
            }
        }
    }
}
