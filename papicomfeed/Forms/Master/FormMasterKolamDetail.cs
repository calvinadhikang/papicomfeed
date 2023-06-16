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

        DataTable dbeli;
        Ikan ikan;
        int jumlahIkanDiBeli;
        int hargaPerIkan;

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

            //kolam data
            tbNama.Text = k.nama;
            numKapasitas.Value = k.kapasitas;
            string status = "Kosong";
            if (k.status == 1)
            {
                status = "Terisi";
            }
            else if (k.status == 2)
            {
                status = "Maintenance";
            }
            lbStatusKolam.Text = status;

            //ikan data
            if (k.dbeli != 0)
            {
                dbeli = DBeli.getByDBeliId(k.dbeli);
                ikan = Ikan.get(int.Parse(dbeli.Rows[0][3].ToString()));
                hargaPerIkan = int.Parse(dbeli.Rows[0][4].ToString());
                jumlahIkanDiBeli = int.Parse(dbeli.Rows[0][5].ToString());
            
                lbNotaPembelian.Text = dbeli.Rows[0][0].ToString();
                lbNamaIkan.Text = ikan.nama;
                lbWaktuIkan.Text = ikan.waktu.ToString() + " Bulan";
                lbStatusPanen.Text = ikan.waktu.ToString() + " Bulan hingga panen";
            }
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

        private void btnPanen_Click(object sender, EventArgs e)
        {
            if (ikan != null)
            {
                if (ikan.waktu != 0)
                {
                    MessageBox.Show("Tidak Dapat Panen");
                }
                else
                {
                    MessageBox.Show("Berhasil Panen");
                }
            }
        }
    }
}
