using papicomfeed.Model;
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
    public partial class FormMasterIkan : Form
    {
        public FormMasterIkan()
        {
            InitializeComponent();
            displayData();
        }

        public void displayData()
        {
            dataListIkan.DataSource = Ikan.getAll();
        }

        private void btnTambahIkan_Click(object sender, EventArgs e)
        {
            FormMasterIkanAdd Ti = new FormMasterIkanAdd(this);
            Ti.Show();
        }

        private void dataListIkan_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            DataTable dt = (DataTable)dataListIkan.DataSource;
            int ikanId = int.Parse(dt.Rows[row][0].ToString());

            FormMasterIkanDetail i = new FormMasterIkanDetail(ikanId, this);
            i.Show();
        }   
    }
}
