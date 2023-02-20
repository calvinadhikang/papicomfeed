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
    }
}
