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
using papicomfeed.Forms.Master;
using System.Drawing.Drawing2D;

namespace papicomfeed.Forms.Master
{
    public partial class FormMasterKolamAdd : Form
    {
        FormMasterKolam parent;
        public FormMasterKolamAdd(FormMasterKolam parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void btnBackTambahIkan_Click(object sender, EventArgs e)
        {
            int kapasitas = int.Parse(numKapasitas.Value.ToString());
            string nama = tbNama.Text;

            if (nama == "" || kapasitas == 0)
            {
                MessageBox.Show("Inputan tidak valid");
                return;
            }

            Kolam k = new Kolam(nama, kapasitas, 0);
            MessageBox.Show($"Berhasil tambah kolam {nama}");
            parent.displayData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void FormMasterKolamAdd_Load(object sender, EventArgs e)
        {
            this.Paint += new PaintEventHandler(FormMasterKolamAdd_Paint);
        }

        private void FormMasterKolamAdd_Paint(object sender, PaintEventArgs e)
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
            button1.BackColor = Color.Red;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.GhostWhite;
        }

        private void btnBackTambahIkan_MouseHover(object sender, EventArgs e)
        {
            btnBackTambahIkan.BackColor = Color.LightGreen;
        }

        private void btnBackTambahIkan_MouseLeave(object sender, EventArgs e)
        {
            btnBackTambahIkan.BackColor = Color.GhostWhite;
        }
    }
}
