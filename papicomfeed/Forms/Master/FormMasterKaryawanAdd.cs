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
    public partial class FormMasterKaryawanAdd : Form
    {
        FormMasterKaryawan parent;
        public FormMasterKaryawanAdd(FormMasterKaryawan f)
        {
            InitializeComponent();
            parent = f;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string nama = tbNama.Text;
            string username = tbUsername.Text;
            string telp = tbTelp.Text;
            int role = cmbRole.SelectedIndex;
            int status = cbStatus.Checked ? 1 : 0;

            if (nama == "" || username == "" || telp == "" || cmbRole.SelectedIndex == -1)
            {
                MessageBox.Show("Inputan harus di isi");
                return;
            }

            Karyawan k = new Karyawan(nama, username, telp, role, status);
            MessageBox.Show($"Berhasil Tambah Karyawan {nama}");
            parent.displayData();
        }

        private void FormMasterKaryawanAdd_Load(object sender, EventArgs e)
        {
            this.Paint += new PaintEventHandler(FormMasterKaryawanAdd_Paint);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormMasterKaryawanAdd_Paint(object sender, PaintEventArgs e)
        {
            LinearGradientBrush gradient = new LinearGradientBrush(
                this.ClientRectangle,
                Color.FromArgb(255, 135, 206, 250), // biru muda
                Color.FromArgb(255, 25, 25, 112), // biru tua
                120f);
            e.Graphics.FillRectangle(gradient, this.ClientRectangle);
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            button2.BackColor = Color.LightGreen;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = Color.GhostWhite;
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.BackColor = Color.Red;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.GhostWhite;
        }
    }
}
