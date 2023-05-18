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
    public partial class FormMasterIkanAdd : Form
    {
        FormMasterIkan parent;
        public FormMasterIkanAdd(FormMasterIkan f)
        {
            InitializeComponent();
            parent = f;
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            if (tbNama.Text == "" || tbWaktu.Text == "" || numericUpDown1.Value == 0)
            {
                MessageBox.Show("Inputan tidak boleh kosong");
                return;
            }

            string nama = tbNama.Text;
            int waktu = int.Parse(tbWaktu.Text);
            int harga = int.Parse(numericUpDown1.Value.ToString());

            //cek duplicate
            if (Ikan.checkDuplicate(nama))
            {
                MessageBox.Show("Ikan sudah ada");
                return;
            }

            Ikan k = new Ikan(nama, waktu, harga);
            MessageBox.Show("Berhasil Tambah Ikan " + nama);
            parent.displayData();
        }

        private void tbWaktu_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbNama_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void FormMasterIkanAdd_Load(object sender, EventArgs e)
        {
            this.Paint += new PaintEventHandler(FormMasterIkanAdd_Paint);
        }

        private void FormMasterIkanAdd_Paint(object sender, PaintEventArgs e)
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

        private void btnTambah_MouseHover(object sender, EventArgs e)
        {
            btnTambah.BackColor = Color.LightGreen;
        }

        private void btnTambah_MouseLeave(object sender, EventArgs e)
        {
            btnTambah.BackColor = Color.GhostWhite;
        }
    }
}
