﻿
namespace papicomfeed.Forms.Penjualan
{
    partial class DetailPenjualan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.labeldetailpenjualan = new System.Windows.Forms.Label();
            this.lbKaryawan = new System.Windows.Forms.Label();
            this.lbTotal = new System.Windows.Forms.Label();
            this.lbNama = new System.Windows.Forms.Label();
            this.lbAlamat = new System.Windows.Forms.Label();
            this.lbTanggal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(118, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 37);
            this.label4.TabIndex = 8;
            this.label4.Text = "Total : Rp";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(457, 144);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(152, 37);
            this.label7.TabIndex = 9;
            this.label7.Text = "Tanggal :";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(371, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(284, 37);
            this.label6.TabIndex = 10;
            this.label6.Text = "Alamat Customer :";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(381, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(270, 37);
            this.label5.TabIndex = 11;
            this.label5.Text = "Nama Customer :";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(10, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(273, 37);
            this.label3.TabIndex = 12;
            this.label3.Text = "Nama Karyawan :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 216);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(760, 335);
            this.dataGridView1.TabIndex = 7;
            // 
            // labeldetailpenjualan
            // 
            this.labeldetailpenjualan.AutoSize = true;
            this.labeldetailpenjualan.BackColor = System.Drawing.Color.Transparent;
            this.labeldetailpenjualan.Location = new System.Drawing.Point(206, 9);
            this.labeldetailpenjualan.Name = "labeldetailpenjualan";
            this.labeldetailpenjualan.Size = new System.Drawing.Size(249, 37);
            this.labeldetailpenjualan.TabIndex = 6;
            this.labeldetailpenjualan.Text = "Detail Penjualan";
            this.labeldetailpenjualan.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbKaryawan
            // 
            this.lbKaryawan.AutoSize = true;
            this.lbKaryawan.BackColor = System.Drawing.Color.Transparent;
            this.lbKaryawan.Location = new System.Drawing.Point(197, 70);
            this.lbKaryawan.Name = "lbKaryawan";
            this.lbKaryawan.Size = new System.Drawing.Size(109, 37);
            this.lbKaryawan.TabIndex = 13;
            this.lbKaryawan.Text = "Kode :";
            this.lbKaryawan.Click += new System.EventHandler(this.lbKaryawan_Click);
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.BackColor = System.Drawing.Color.Transparent;
            this.lbTotal.Location = new System.Drawing.Point(229, 108);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(109, 37);
            this.lbTotal.TabIndex = 13;
            this.lbTotal.Text = "Kode :";
            this.lbTotal.Click += new System.EventHandler(this.lbTotal_Click);
            // 
            // lbNama
            // 
            this.lbNama.AutoSize = true;
            this.lbNama.BackColor = System.Drawing.Color.Transparent;
            this.lbNama.Location = new System.Drawing.Point(565, 69);
            this.lbNama.Name = "lbNama";
            this.lbNama.Size = new System.Drawing.Size(109, 37);
            this.lbNama.TabIndex = 13;
            this.lbNama.Text = "Kode :";
            this.lbNama.Click += new System.EventHandler(this.lbNama_Click);
            // 
            // lbAlamat
            // 
            this.lbAlamat.AutoSize = true;
            this.lbAlamat.BackColor = System.Drawing.Color.Transparent;
            this.lbAlamat.Location = new System.Drawing.Point(565, 106);
            this.lbAlamat.Name = "lbAlamat";
            this.lbAlamat.Size = new System.Drawing.Size(109, 37);
            this.lbAlamat.TabIndex = 13;
            this.lbAlamat.Text = "Kode :";
            this.lbAlamat.Click += new System.EventHandler(this.lbAlamat_Click);
            // 
            // lbTanggal
            // 
            this.lbTanggal.AutoSize = true;
            this.lbTanggal.BackColor = System.Drawing.Color.Transparent;
            this.lbTanggal.Location = new System.Drawing.Point(565, 144);
            this.lbTanggal.Name = "lbTanggal";
            this.lbTanggal.Size = new System.Drawing.Size(109, 37);
            this.lbTanggal.TabIndex = 13;
            this.lbTanggal.Text = "Kode :";
            this.lbTanggal.Click += new System.EventHandler(this.lbTanggal_Click);
            // 
            // DetailPenjualan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbTanggal);
            this.Controls.Add(this.lbAlamat);
            this.Controls.Add(this.lbNama);
            this.Controls.Add(this.lbTotal);
            this.Controls.Add(this.lbKaryawan);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.labeldetailpenjualan);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "DetailPenjualan";
            this.Text = "DetailPenjualan";
            this.Load += new System.EventHandler(this.DetailPenjualan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label labeldetailpenjualan;
        private System.Windows.Forms.Label lbKaryawan;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.Label lbNama;
        private System.Windows.Forms.Label lbAlamat;
        private System.Windows.Forms.Label lbTanggal;
    }
}