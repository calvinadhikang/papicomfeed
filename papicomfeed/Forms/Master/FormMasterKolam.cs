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
using System.Drawing.Drawing2D;


namespace papicomfeed.Forms.Master
{
    public partial class FormMasterKolam : Form
    {
        DataTable dt;
        public FormMasterKolam()
        {
            InitializeComponent();
        }

        private void FormMasterKolam_Load(object sender, EventArgs e)
        {
            displayData();
            this.Paint += new PaintEventHandler(FormMasterKolam_Paint);
        }

        public void displayData()
        {
            dt = Kolam.getAll();
            dataGridView1.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormMasterKolamAdd f = new FormMasterKolamAdd(this);
            f.Show();
        }

        int idKolam = -1;
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int idxRow = e.RowIndex;
            idKolam = int.Parse(dt.Rows[idxRow][0].ToString());

            FormMasterKolamDetail f = new FormMasterKolamDetail(idKolam, this);
            f.Show();
        }

        private void FormMasterKolam_Paint(object sender, PaintEventArgs e)
        {
            // membuat gradient background
            LinearGradientBrush gradient = new LinearGradientBrush(
                this.ClientRectangle,
                Color.FromArgb(255, 135, 206, 250), // biru muda
                Color.FromArgb(255, 25, 25, 112), // biru tua
                120f);
            e.Graphics.FillRectangle(gradient, this.ClientRectangle);
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.BackColor = Color.LightGreen;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.GhostWhite;
        }
    }
}
