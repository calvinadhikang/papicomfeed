﻿
namespace papicomfeed.Forms.Master
{
    partial class FormMasterIkanDetail
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDetailIdIkan = new System.Windows.Forms.TextBox();
            this.txtDetailNamaIkan = new System.Windows.Forms.TextBox();
            this.txtDetailWaktuIkan = new System.Windows.Forms.TextBox();
            this.btnsaveikan = new System.Windows.Forms.Button();
            this.btnbackikan = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(170, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Detail Ikan";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "ID :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nama :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Waktu :";
            // 
            // txtDetailIdIkan
            // 
            this.txtDetailIdIkan.Enabled = false;
            this.txtDetailIdIkan.Location = new System.Drawing.Point(103, 49);
            this.txtDetailIdIkan.Name = "txtDetailIdIkan";
            this.txtDetailIdIkan.Size = new System.Drawing.Size(298, 31);
            this.txtDetailIdIkan.TabIndex = 1;
            // 
            // txtDetailNamaIkan
            // 
            this.txtDetailNamaIkan.Location = new System.Drawing.Point(103, 86);
            this.txtDetailNamaIkan.Name = "txtDetailNamaIkan";
            this.txtDetailNamaIkan.Size = new System.Drawing.Size(298, 31);
            this.txtDetailNamaIkan.TabIndex = 1;
            // 
            // txtDetailWaktuIkan
            // 
            this.txtDetailWaktuIkan.Location = new System.Drawing.Point(103, 123);
            this.txtDetailWaktuIkan.Name = "txtDetailWaktuIkan";
            this.txtDetailWaktuIkan.Size = new System.Drawing.Size(225, 31);
            this.txtDetailWaktuIkan.TabIndex = 1;
            // 
            // btnsaveikan
            // 
            this.btnsaveikan.Location = new System.Drawing.Point(302, 197);
            this.btnsaveikan.Name = "btnsaveikan";
            this.btnsaveikan.Size = new System.Drawing.Size(99, 35);
            this.btnsaveikan.TabIndex = 2;
            this.btnsaveikan.Text = "Simpan";
            this.btnsaveikan.UseVisualStyleBackColor = true;
            this.btnsaveikan.Click += new System.EventHandler(this.btnsaveikan_Click);
            // 
            // btnbackikan
            // 
            this.btnbackikan.Location = new System.Drawing.Point(302, 4);
            this.btnbackikan.Name = "btnbackikan";
            this.btnbackikan.Size = new System.Drawing.Size(99, 35);
            this.btnbackikan.TabIndex = 2;
            this.btnbackikan.Text = "Kembali";
            this.btnbackikan.UseVisualStyleBackColor = true;
            this.btnbackikan.Click += new System.EventHandler(this.btnbackikan_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(334, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "Bulan";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 162);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 25);
            this.label6.TabIndex = 3;
            this.label6.Text = "Harga :";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(103, 160);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(298, 31);
            this.numericUpDown1.TabIndex = 5;
            // 
            // FormMasterIkanDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 243);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnbackikan);
            this.Controls.Add(this.btnsaveikan);
            this.Controls.Add(this.txtDetailWaktuIkan);
            this.Controls.Add(this.txtDetailNamaIkan);
            this.Controls.Add(this.txtDetailIdIkan);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FormMasterIkanDetail";
            this.Text = "FormMasterIkanDetail";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDetailIdIkan;
        private System.Windows.Forms.TextBox txtDetailNamaIkan;
        private System.Windows.Forms.TextBox txtDetailWaktuIkan;
        private System.Windows.Forms.Button btnsaveikan;
        private System.Windows.Forms.Button btnbackikan;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}