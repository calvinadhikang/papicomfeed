
namespace papicomfeed.Forms.Master
{
    partial class FormMasterKolamAdd
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
            this.tbNama = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numKapasitas = new System.Windows.Forms.NumericUpDown();
            this.btnBackTambahIkan = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numKapasitas)).BeginInit();
            this.SuspendLayout();
            // 
            // tbNama
            // 
            this.tbNama.Location = new System.Drawing.Point(100, 56);
            this.tbNama.Name = "tbNama";
            this.tbNama.Size = new System.Drawing.Size(298, 31);
            this.tbNama.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 25);
            this.label3.TabIndex = 15;
            this.label3.Text = "Nama :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 25);
            this.label1.TabIndex = 16;
            this.label1.Text = "Tambah Kolam";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 25);
            this.label2.TabIndex = 20;
            this.label2.Text = "Kapasitas :";
            // 
            // numKapasitas
            // 
            this.numKapasitas.Location = new System.Drawing.Point(139, 94);
            this.numKapasitas.Name = "numKapasitas";
            this.numKapasitas.Size = new System.Drawing.Size(259, 31);
            this.numKapasitas.TabIndex = 21;
            // 
            // btnBackTambahIkan
            // 
            this.btnBackTambahIkan.Location = new System.Drawing.Point(290, 131);
            this.btnBackTambahIkan.Name = "btnBackTambahIkan";
            this.btnBackTambahIkan.Size = new System.Drawing.Size(108, 35);
            this.btnBackTambahIkan.TabIndex = 19;
            this.btnBackTambahIkan.Text = "Tambah";
            this.btnBackTambahIkan.UseVisualStyleBackColor = true;
            this.btnBackTambahIkan.Click += new System.EventHandler(this.btnBackTambahIkan_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(290, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 35);
            this.button1.TabIndex = 22;
            this.button1.Text = "Kembali";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormMasterKolamAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 186);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.numKapasitas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBackTambahIkan);
            this.Controls.Add(this.tbNama);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FormMasterKolamAdd";
            this.Text = "FormMasterKolamAdd";
            ((System.ComponentModel.ISupportInitialize)(this.numKapasitas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbNama;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numKapasitas;
        private System.Windows.Forms.Button btnBackTambahIkan;
        private System.Windows.Forms.Button button1;
    }
}