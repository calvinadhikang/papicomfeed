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
    }
}
