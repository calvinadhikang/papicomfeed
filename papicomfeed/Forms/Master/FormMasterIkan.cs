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
using System.Drawing.Drawing2D;

namespace papicomfeed.Forms.Master
{
    public partial class FormMasterIkan : Form
    {
        public FormMasterIkan()
        {
            InitializeComponent();
            displayData();
        }

        public void displayData(string key = "")
        {
            DataTable dt = Ikan.getAll(key);
            dataListIkan.DataSource = dt;
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

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void FormMasterIkan_Load(object sender, EventArgs e)
        {
            this.Paint += new PaintEventHandler(FormMasterIkan_Paint);
        }

        private void FormMasterIkan_Paint(object sender, PaintEventArgs e)
        {
            // membuat gradient background
            LinearGradientBrush gradient = new LinearGradientBrush(
                this.ClientRectangle,
                Color.FromArgb(255, 135, 206, 250), // biru muda
                Color.FromArgb(255, 25, 25, 112), // biru tua
                120f);
            e.Graphics.FillRectangle(gradient, this.ClientRectangle);
        }

        private void btnTambahIkan_MouseHover(object sender, EventArgs e)
        {
            btnTambahIkan.BackColor = Color.LightGreen;
        }

        private void btnTambahIkan_MouseLeave(object sender, EventArgs e)
        {
            btnTambahIkan.BackColor = Color.GhostWhite;
        }

        private void tbNamaSearch_TextChanged(object sender, EventArgs e)
        {
            string key = tbNamaSearch.Text;
            displayData(key);
        }
    }
}
