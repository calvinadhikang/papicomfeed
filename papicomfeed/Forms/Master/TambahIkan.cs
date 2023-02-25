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

namespace papicomfeed.Forms.Master
{
    public partial class TambahIkan : Form
    {
        FormMasterIkan parent;
        public TambahIkan(FormMasterIkan parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void BtnAddIkan_Click(object sender, EventArgs e)
        {
            Ikan ni = new Ikan(txtnamaikan.Text.ToString(), int.Parse(txtWaktuIkan.Text.ToString()));

            parent.displayData();

        }
    }
}
