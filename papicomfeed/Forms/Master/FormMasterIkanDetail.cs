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
    public partial class FormMasterIkanDetail : Form
    {
        Ikan i;
        FormMasterIkan parent;
        public FormMasterIkanDetail(int ikanId, FormMasterIkan parent)
        {
            InitializeComponent();
            this.i = Ikan.get(ikanId);
            this.parent = parent;

            isi();
        }

        void isi()
        {
            txtDetailIdIkan.Text = i.id.ToString();
            txtDetailNamaIkan.Text = i.nama.ToString();
            txtDetailWaktuIkan.Text = i.waktu.ToString();
            // onk error nde kene !
            numericUpDown1.Value = i.harga;
        }

        private void btnsaveikan_Click(object sender, EventArgs e)
        {
            i.nama = txtDetailNamaIkan.Text;
            i.waktu = int.Parse(txtDetailWaktuIkan.Text);
            i.harga = int.Parse(numericUpDown1.Value.ToString());

            i.save();

            parent.displayData();
            MessageBox.Show("Berhasil Update");
        }

        private void btnbackikan_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormMasterIkanDetail_Load(object sender, EventArgs e)
        {
            this.Paint += new PaintEventHandler(FormMasterIkanDetail_Paint);
        }

        private void FormMasterIkanDetail_Paint(object sender, PaintEventArgs e)
        {
            // membuat gradient background
            LinearGradientBrush gradient = new LinearGradientBrush(
                this.ClientRectangle,
                Color.FromArgb(255, 135, 206, 250), // biru muda
                Color.FromArgb(255, 25, 25, 112), // biru tua
                120f);
            e.Graphics.FillRectangle(gradient, this.ClientRectangle);
        }

        private void btnbackikan_MouseHover(object sender, EventArgs e)
        {
            btnbackikan.BackColor = Color.Red;
        }

        private void btnbackikan_MouseLeave(object sender, EventArgs e)
        {
            btnbackikan.BackColor = Color.GhostWhite;
        }

        private void btnsaveikan_MouseHover(object sender, EventArgs e)
        {
            btnsaveikan.BackColor = Color.LightGreen;
        }

        private void btnsaveikan_MouseLeave(object sender, EventArgs e)
        {
            btnsaveikan.BackColor = Color.GhostWhite;
        }
    }
}
