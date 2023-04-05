
namespace papicomfeed.Forms.Penjualan
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.nudJumlah = new System.Windows.Forms.NumericUpDown();
            this.cmbIkan = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvTambahJual = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblTelp = new System.Windows.Forms.Label();
            this.lblAlamat = new System.Windows.Forms.Label();
            this.cmbCustomer = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudJumlah)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTambahJual)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.nudJumlah);
            this.groupBox2.Controls.Add(this.cmbIkan);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(12, 195);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(784, 91);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tambah Ikan";
            // 
            // nudJumlah
            // 
            this.nudJumlah.Location = new System.Drawing.Point(468, 38);
            this.nudJumlah.Name = "nudJumlah";
            this.nudJumlah.Size = new System.Drawing.Size(120, 37);
            this.nudJumlah.TabIndex = 5;
            // 
            // cmbIkan
            // 
            this.cmbIkan.FormattingEnabled = true;
            this.cmbIkan.Location = new System.Drawing.Point(105, 37);
            this.cmbIkan.Name = "cmbIkan";
            this.cmbIkan.Size = new System.Drawing.Size(247, 38);
            this.cmbIkan.TabIndex = 4;
            this.cmbIkan.SelectedIndexChanged += new System.EventHandler(this.cmbIkan_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(647, 37);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 37);
            this.button1.TabIndex = 3;
            this.button1.Text = "Tambah";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(367, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 31);
            this.label7.TabIndex = 2;
            this.label7.Text = "Jumlah :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 31);
            this.label5.TabIndex = 2;
            this.label5.Text = "Ikan :";
            // 
            // dgvTambahJual
            // 
            this.dgvTambahJual.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTambahJual.Location = new System.Drawing.Point(12, 344);
            this.dgvTambahJual.Name = "dgvTambahJual";
            this.dgvTambahJual.RowHeadersWidth = 51;
            this.dgvTambahJual.Size = new System.Drawing.Size(784, 314);
            this.dgvTambahJual.TabIndex = 8;
            this.dgvTambahJual.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTambahJual_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblTelp);
            this.groupBox1.Controls.Add(this.lblAlamat);
            this.groupBox1.Controls.Add(this.cmbCustomer);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(784, 128);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Header Penjualan";
            // 
            // lblTelp
            // 
            this.lblTelp.AutoSize = true;
            this.lblTelp.Location = new System.Drawing.Point(502, 89);
            this.lblTelp.Name = "lblTelp";
            this.lblTelp.Size = new System.Drawing.Size(94, 31);
            this.lblTelp.TabIndex = 6;
            this.lblTelp.Text = "lblTelp";
            // 
            // lblAlamat
            // 
            this.lblAlamat.AutoSize = true;
            this.lblAlamat.Location = new System.Drawing.Point(147, 89);
            this.lblAlamat.Name = "lblAlamat";
            this.lblAlamat.Size = new System.Drawing.Size(0, 31);
            this.lblAlamat.TabIndex = 4;
            // 
            // cmbCustomer
            // 
            this.cmbCustomer.FormattingEnabled = true;
            this.cmbCustomer.Location = new System.Drawing.Point(222, 46);
            this.cmbCustomer.Name = "cmbCustomer";
            this.cmbCustomer.Size = new System.Drawing.Size(556, 38);
            this.cmbCustomer.TabIndex = 3;
            this.cmbCustomer.SelectedIndexChanged += new System.EventHandler(this.cmbCustomer_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(419, 87);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 31);
            this.label8.TabIndex = 2;
            this.label8.Text = "Telp :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 31);
            this.label4.TabIndex = 2;
            this.label4.Text = "Alamat :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(205, 31);
            this.label3.TabIndex = 2;
            this.label3.Text = "Pilih Customer :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 306);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 31);
            this.label2.TabIndex = 5;
            this.label2.Text = "Total : Rp";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(258, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 31);
            this.label1.TabIndex = 6;
            this.label1.Text = "Tambah Penjualan";
            // 
            // Tambah
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 672);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgvTambahJual);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Tambah";
            this.Text = "Tambah";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudJumlah)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTambahJual)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown nudJumlah;
        private System.Windows.Forms.ComboBox cmbIkan;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvTambahJual;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbCustomer;
        private System.Windows.Forms.Label lblTelp;
        private System.Windows.Forms.Label lblAlamat;
    }
}