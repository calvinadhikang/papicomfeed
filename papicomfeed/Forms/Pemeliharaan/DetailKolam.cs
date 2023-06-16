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
    public partial class DetailKolam : Form
    {
        ViewKolam parent;
        Kolam kolam;
        public DetailKolam(int idKolam, ViewKolam form)
        {
            InitializeComponent();
            parent = form;
            kolam = Kolam.get(idKolam);

            displayDetail();
        }

        void displayDetail()
        {
            tbNama.Text = kolam.nama;
            numericUpDown1.Value = kolam.kapasitas;

            string status = "Kosong";
            if(kolam.status == 1)
            {
                status = "Terisi";
            }
            else if (kolam.status == 2)
            {
                status = "Maintenance";
            }
            lbStatus.Text = status;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            kolam.nama = tbNama.Text;
            kolam.kapasitas = int.Parse(numericUpDown1.Value.ToString());
            kolam.save();

            displayDetail();
            parent.displayData();
        }

        private void DetailKolam_Paint(object sender, PaintEventArgs e)
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
