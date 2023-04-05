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
    }
}
