
namespace papicomfeed.Forms.Pembelian
{
    partial class Tambah
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtAlamatSup = new System.Windows.Forms.TextBox();
            this.txtNamaSup = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvPembelian = new System.Windows.Forms.DataGridView();
            this.btnTambah = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.numJumlahIkan = new System.Windows.Forms.NumericUpDown();
            this.cmbKolam = new System.Windows.Forms.ComboBox();
            this.cmbIkan = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSelesai = new System.Windows.Forms.Button();
            this.labeltotal = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPembelian)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numJumlahIkan)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(258, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tambah Pembelian";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(12, 359);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 26);
            this.label2.TabIndex = 0;
            this.label2.Text = "Total : Rp";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.txtAlamatSup);
            this.groupBox1.Controls.Add(this.txtNamaSup);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(760, 128);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Header Pembelian";
            // 
            // txtAlamatSup
            // 
            this.txtAlamatSup.Location = new System.Drawing.Point(191, 84);
            this.txtAlamatSup.Name = "txtAlamatSup";
            this.txtAlamatSup.Size = new System.Drawing.Size(569, 32);
            this.txtAlamatSup.TabIndex = 3;
            // 
            // txtNamaSup
            // 
            this.txtNamaSup.Location = new System.Drawing.Point(191, 46);
            this.txtNamaSup.Name = "txtNamaSup";
            this.txtNamaSup.Size = new System.Drawing.Size(569, 32);
            this.txtNamaSup.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(179, 26);
            this.label4.TabIndex = 2;
            this.label4.Text = "Alamat Supplier :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nama Supplier :";
            // 
            // dgvPembelian
            // 
            this.dgvPembelian.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPembelian.Location = new System.Drawing.Point(12, 397);
            this.dgvPembelian.Name = "dgvPembelian";
            this.dgvPembelian.RowHeadersWidth = 62;
            this.dgvPembelian.Size = new System.Drawing.Size(760, 314);
            this.dgvPembelian.TabIndex = 2;
            this.dgvPembelian.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPembelian_CellContentClick);
            // 
            // btnTambah
            // 
            this.btnTambah.BackColor = System.Drawing.Color.GhostWhite;
            this.btnTambah.Location = new System.Drawing.Point(647, 100);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(107, 37);
            this.btnTambah.TabIndex = 3;
            this.btnTambah.Text = "Tambah";
            this.btnTambah.UseVisualStyleBackColor = false;
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
            this.btnTambah.MouseLeave += new System.EventHandler(this.btnTambah_MouseLeave);
            this.btnTambah.MouseHover += new System.EventHandler(this.btnTambah_MouseHover);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.numJumlahIkan);
            this.groupBox2.Controls.Add(this.cmbKolam);
            this.groupBox2.Controls.Add(this.cmbIkan);
            this.groupBox2.Controls.Add(this.btnTambah);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(12, 195);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(760, 143);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tambah Ikan";
            // 
            // numJumlahIkan
            // 
            this.numJumlahIkan.Location = new System.Drawing.Point(468, 38);
            this.numJumlahIkan.Name = "numJumlahIkan";
            this.numJumlahIkan.Size = new System.Drawing.Size(120, 32);
            this.numJumlahIkan.TabIndex = 5;
            // 
            // cmbKolam
            // 
            this.cmbKolam.FormattingEnabled = true;
            this.cmbKolam.Location = new System.Drawing.Point(99, 85);
            this.cmbKolam.Name = "cmbKolam";
            this.cmbKolam.Size = new System.Drawing.Size(247, 33);
            this.cmbKolam.TabIndex = 4;
            this.cmbKolam.SelectedIndexChanged += new System.EventHandler(this.cmbKolam_SelectedIndexChanged);
            // 
            // cmbIkan
            // 
            this.cmbIkan.FormattingEnabled = true;
            this.cmbIkan.Location = new System.Drawing.Point(99, 37);
            this.cmbIkan.Name = "cmbIkan";
            this.cmbIkan.Size = new System.Drawing.Size(247, 33);
            this.cmbIkan.TabIndex = 4;
            this.cmbIkan.SelectedIndexChanged += new System.EventHandler(this.cmbIkan_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 26);
            this.label6.TabIndex = 2;
            this.label6.Text = "Kolam :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(367, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 26);
            this.label7.TabIndex = 2;
            this.label7.Text = "Jumlah :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 26);
            this.label5.TabIndex = 2;
            this.label5.Text = "Ikan :";
            // 
            // btnSelesai
            // 
            this.btnSelesai.BackColor = System.Drawing.Color.GhostWhite;
            this.btnSelesai.Location = new System.Drawing.Point(610, 737);
            this.btnSelesai.Name = "btnSelesai";
            this.btnSelesai.Size = new System.Drawing.Size(156, 43);
            this.btnSelesai.TabIndex = 5;
            this.btnSelesai.Text = "Selesai";
            this.btnSelesai.UseVisualStyleBackColor = false;
            this.btnSelesai.Click += new System.EventHandler(this.btnSelesai_Click);
            this.btnSelesai.MouseLeave += new System.EventHandler(this.btnSelesai_MouseLeave);
            this.btnSelesai.MouseHover += new System.EventHandler(this.btnSelesai_MouseHover);
            // 
            // labeltotal
            // 
            this.labeltotal.AutoSize = true;
            this.labeltotal.BackColor = System.Drawing.Color.Transparent;
            this.labeltotal.Location = new System.Drawing.Point(174, 359);
            this.labeltotal.Name = "labeltotal";
            this.labeltotal.Size = new System.Drawing.Size(24, 26);
            this.labeltotal.TabIndex = 6;
            this.labeltotal.Text = "0";
            // 
            // Tambah
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 802);
            this.Controls.Add(this.labeltotal);
            this.Controls.Add(this.btnSelesai);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgvPembelian);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Tambah";
            this.Text = "Tambah";
            this.Load += new System.EventHandler(this.Tambah_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPembelian)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numJumlahIkan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtAlamatSup;
        private System.Windows.Forms.TextBox txtNamaSup;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvPembelian;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown numJumlahIkan;
        private System.Windows.Forms.ComboBox cmbKolam;
        private System.Windows.Forms.ComboBox cmbIkan;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSelesai;
        private System.Windows.Forms.Label labeltotal;
    }
}