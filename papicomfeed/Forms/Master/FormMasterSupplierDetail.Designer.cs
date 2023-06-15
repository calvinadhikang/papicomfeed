
namespace papicomfeed.Forms.Master
{
    partial class FormMasterSupplierDetail
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
            this.tbNama = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbId = new System.Windows.Forms.TextBox();
            this.tbTelp = new System.Windows.Forms.TextBox();
            this.tbAlamat = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbIkan = new System.Windows.Forms.ComboBox();
            this.btnAddIkan = new System.Windows.Forms.Button();
            this.dgvIkan = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.btnRemoveIkan = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIkan)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(280, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Detail Supplier";
            // 
            // tbNama
            // 
            this.tbNama.Location = new System.Drawing.Point(98, 99);
            this.tbNama.Name = "tbNama";
            this.tbNama.Size = new System.Drawing.Size(243, 31);
            this.tbNama.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nama :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(428, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Alamat :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(347, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(171, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "Nomor Telepon :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "ID :";
            // 
            // tbId
            // 
            this.tbId.Enabled = false;
            this.tbId.Location = new System.Drawing.Point(98, 59);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(243, 31);
            this.tbId.TabIndex = 3;
            // 
            // tbTelp
            // 
            this.tbTelp.Location = new System.Drawing.Point(524, 59);
            this.tbTelp.Name = "tbTelp";
            this.tbTelp.Size = new System.Drawing.Size(248, 31);
            this.tbTelp.TabIndex = 6;
            // 
            // tbAlamat
            // 
            this.tbAlamat.Location = new System.Drawing.Point(524, 99);
            this.tbAlamat.Name = "tbAlamat";
            this.tbAlamat.Size = new System.Drawing.Size(248, 31);
            this.tbAlamat.TabIndex = 5;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(677, 136);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(95, 35);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Simpan";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRemoveIkan);
            this.groupBox1.Controls.Add(this.btnAddIkan);
            this.groupBox1.Controls.Add(this.cmbIkan);
            this.groupBox1.Location = new System.Drawing.Point(17, 177);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(755, 77);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Ikan";
            // 
            // cmbIkan
            // 
            this.cmbIkan.FormattingEnabled = true;
            this.cmbIkan.Location = new System.Drawing.Point(6, 30);
            this.cmbIkan.Name = "cmbIkan";
            this.cmbIkan.Size = new System.Drawing.Size(241, 33);
            this.cmbIkan.TabIndex = 0;
            // 
            // btnAddIkan
            // 
            this.btnAddIkan.Location = new System.Drawing.Point(253, 30);
            this.btnAddIkan.Name = "btnAddIkan";
            this.btnAddIkan.Size = new System.Drawing.Size(60, 33);
            this.btnAddIkan.TabIndex = 1;
            this.btnAddIkan.Text = "+";
            this.btnAddIkan.UseVisualStyleBackColor = true;
            this.btnAddIkan.Click += new System.EventHandler(this.btnAddIkan_Click);
            // 
            // dgvIkan
            // 
            this.dgvIkan.AllowUserToAddRows = false;
            this.dgvIkan.AllowUserToDeleteRows = false;
            this.dgvIkan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvIkan.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvIkan.Location = new System.Drawing.Point(17, 316);
            this.dgvIkan.Name = "dgvIkan";
            this.dgvIkan.Size = new System.Drawing.Size(755, 233);
            this.dgvIkan.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 288);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(258, 25);
            this.label6.TabIndex = 2;
            this.label6.Text = "Data Ikan Yang Di Supply";
            // 
            // btnRemoveIkan
            // 
            this.btnRemoveIkan.Location = new System.Drawing.Point(319, 29);
            this.btnRemoveIkan.Name = "btnRemoveIkan";
            this.btnRemoveIkan.Size = new System.Drawing.Size(60, 33);
            this.btnRemoveIkan.TabIndex = 2;
            this.btnRemoveIkan.Text = "-";
            this.btnRemoveIkan.UseVisualStyleBackColor = true;
            this.btnRemoveIkan.Click += new System.EventHandler(this.btnRemoveIkan_Click);
            // 
            // FormMasterSupplierDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.dgvIkan);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tbTelp);
            this.Controls.Add(this.tbAlamat);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbId);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbNama);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FormMasterSupplierDetail";
            this.Text = "FormMasterSupplierDetail";
            this.Load += new System.EventHandler(this.FormMasterSupplierDetail_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIkan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNama;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.TextBox tbTelp;
        private System.Windows.Forms.TextBox tbAlamat;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbIkan;
        private System.Windows.Forms.Button btnAddIkan;
        private System.Windows.Forms.DataGridView dgvIkan;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnRemoveIkan;
    }
}