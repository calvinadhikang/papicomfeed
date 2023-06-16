using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using papicomfeed.Model;

namespace papicomfeed.Forms.Pemeliharaan
{
    public partial class ViewKolam : Form
    {
        public ViewKolam()
        {
            InitializeComponent();
            displayData();
        }
        DataTable dt;

        public void displayData(string key = "")
        {
            dt = Kolam.getAll(key);

            //add columns
            dataGridView1.Columns.Add("ID", "ID");
            dataGridView1.Columns.Add("NAMA", "NAMA");
            dataGridView1.Columns.Add("KAPASITAS", "KAPASITAS");
            dataGridView1.Columns.Add("STATUS", "STATUS");

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                int id = int.Parse(dt.Rows[i][0].ToString());
                string nama = dt.Rows[i][1].ToString();
                int kapasitas = int.Parse(dt.Rows[i][2].ToString());

                int status = int.Parse(dt.Rows[i][3].ToString());
                string statusText = "Kosong";
                if (status == 1)
                {
                    statusText = "Terisi";
                }
                else if (status == 2)
                {
                    statusText = "Maintenance";
                }
                dataGridView1.Rows.Add(id, nama, kapasitas, statusText);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string key = textBox1.Text;
            displayData(key);
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            int kolamId = int.Parse(dt.Rows[row][0].ToString());

            DetailKolam i = new DetailKolam(kolamId, this);
            i.Show();
        }

        private void ViewKolam_Paint(object sender, PaintEventArgs e)
        {
            // membuat gradient background
            LinearGradientBrush gradient = new LinearGradientBrush(
                this.ClientRectangle,
                Color.FromArgb(255, 25, 25, 112), // biru tua
                Color.FromArgb(255, 135, 206, 250), // biru muda cerah
                -120f);
            e.Graphics.FillRectangle(gradient, this.ClientRectangle);
        }
    }
}
