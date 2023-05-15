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
    public partial class FormMasterKolamDetail : Form
    {
        Kolam k;
        FormMasterKolam parent;
        int idKolam;
        public FormMasterKolamDetail(int id, FormMasterKolam parent)
        {
            InitializeComponent();
            this.idKolam = id;
            this.parent = parent;

            displayData();
        }

        void displayData()
        {
            k = Kolam.get(idKolam);

            tbNama.Text = k.nama;
            numKapasitas.Value = k.kapasitas;
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            k.nama = tbNama.Text;
            k.kapasitas = int.Parse(numKapasitas.Value.ToString());
            int result = k.save();

            if (result == 1)
            {
                MessageBox.Show($"Berhasil update data kolam {idKolam}");
                parent.displayData();
                displayData();
            }
        }

        private void FormMasterKolamDetail_Load(object sender, EventArgs e)
        {
            this.Paint += new PaintEventHandler(FormMasterKolamDetail_Paint);
        }

        private void FormMasterKolamDetail_Paint(object sender, PaintEventArgs e)
        {
            // membuat gradient background
            LinearGradientBrush gradient = new LinearGradientBrush(
                this.ClientRectangle,
                Color.FromArgb(255, 135, 206, 250), // biru muda
                Color.FromArgb(255, 20, 20, 105), // biru tua
                -120f);
            e.Graphics.FillRectangle(gradient, this.ClientRectangle);
        }

        private void btnKembali_MouseHover(object sender, EventArgs e)
        {
            btnKembali.BackColor = Color.Red;
        }

        private void btnKembali_MouseLeave(object sender, EventArgs e)
        {
            btnKembali.BackColor = Color.GhostWhite;
        }

        private void btnSimpan_MouseHover(object sender, EventArgs e)
        {
            btnSimpan.BackColor = Color.LightGreen;
        }

        private void btnSimpan_MouseLeave(object sender, EventArgs e)
        {
            btnSimpan.BackColor = Color.GhostWhite;
        }

        private void btnPanen_MouseHover(object sender, EventArgs e)
        {
            btnPanen.BackColor = Color.LightGreen;
        }

        private void btnPanen_MouseLeave(object sender, EventArgs e)
        {
            btnPanen.BackColor = Color.GhostWhite;
        }
    }
}
