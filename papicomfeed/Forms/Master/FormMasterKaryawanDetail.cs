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
    public partial class FormMasterKaryawanDetail : Form
    {
        Karyawan k;
        FormMasterKaryawan parent;
        public FormMasterKaryawanDetail(int id, FormMasterKaryawan parent)
        {
            InitializeComponent();
            this.k = Karyawan.get(id);

            this.parent = parent;

            setValue();//mengisi value pada texbox, combobox, dan checkbox
        }

        void setValue()
        {
            tbId.Text = k.id.ToString();
            tbNama.Text = k.nama;
            tbUsername.Text = k.username;
            tbTelp.Text = k.telp.ToString();

            //combobox
            int idxCmb = k.role;
            cmbRole.SelectedIndex = idxCmb;

            //checkbox
            if (k.status == 1)
            {
                cbStatus.Checked = true;
            }
            else
            {
                cbStatus.Checked = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.parent.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            k.id = int.Parse(tbId.Text);
            k.nama = tbNama.Text;
            k.username = tbUsername.Text;
            k.telp = tbTelp.Text;
            
            //set status karyawan
            int status = 0;
            if (cbStatus.Checked)
            {
                status = 1;
            }
            k.status = status;

            //set role
            k.role = cmbRole.SelectedIndex;
            k.save();

            this.parent.displayData();
            MessageBox.Show("Updated");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormMasterKaryawanDetail_Load(object sender, EventArgs e)
        {
            this.Paint += new PaintEventHandler(FormMasterKaryawanDetail_Paint);
        }

        private void FormMasterKaryawanDetail_Paint(object sender, PaintEventArgs e)
        {
            LinearGradientBrush gradient = new LinearGradientBrush(
                this.ClientRectangle,
                Color.FromArgb(255, 135, 206, 250), // biru muda
                Color.FromArgb(255, 25, 25, 112), // biru tua
                90f);
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

        private void button2_MouseHover(object sender, EventArgs e)
        {
            button2.BackColor = Color.LightGreen;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = Color.GhostWhite;
        }
    }
}
