﻿using papicomfeed.Model;
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
        }
    }
}
