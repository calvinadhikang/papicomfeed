namespace papicomfeed.Forms.Master
{
    partial class FormLaporanPenjualan
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
            this.dttglawalpenjualan = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dttglakhirpenjualan = new System.Windows.Forms.DateTimePicker();
            this.btngenerate = new System.Windows.Forms.Button();
            this.crystalReportvpenjualan = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tanggal Awal :";
            // 
            // dttglawalpenjualan
            // 
            this.dttglawalpenjualan.Location = new System.Drawing.Point(124, 12);
            this.dttglawalpenjualan.Name = "dttglawalpenjualan";
            this.dttglawalpenjualan.Size = new System.Drawing.Size(200, 26);
            this.dttglawalpenjualan.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(360, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tanggal Akhir :";
            // 
            // dttglakhirpenjualan
            // 
            this.dttglakhirpenjualan.Location = new System.Drawing.Point(481, 12);
            this.dttglakhirpenjualan.Name = "dttglakhirpenjualan";
            this.dttglakhirpenjualan.Size = new System.Drawing.Size(200, 26);
            this.dttglakhirpenjualan.TabIndex = 3;
            // 
            // btngenerate
            // 
            this.btngenerate.Location = new System.Drawing.Point(733, 4);
            this.btngenerate.Name = "btngenerate";
            this.btngenerate.Size = new System.Drawing.Size(155, 46);
            this.btngenerate.TabIndex = 4;
            this.btngenerate.Text = "Generate";
            this.btngenerate.UseVisualStyleBackColor = true;
            this.btngenerate.Click += new System.EventHandler(this.btngenerate_Click);
            // 
            // crystalReportvpenjualan
            // 
            this.crystalReportvpenjualan.ActiveViewIndex = -1;
            this.crystalReportvpenjualan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportvpenjualan.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportvpenjualan.Location = new System.Drawing.Point(1, 46);
            this.crystalReportvpenjualan.Name = "crystalReportvpenjualan";
            this.crystalReportvpenjualan.Size = new System.Drawing.Size(1167, 573);
            this.crystalReportvpenjualan.TabIndex = 5;
            // 
            // FormLaporanPenjualan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1172, 623);
            this.Controls.Add(this.crystalReportvpenjualan);
            this.Controls.Add(this.btngenerate);
            this.Controls.Add(this.dttglakhirpenjualan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dttglawalpenjualan);
            this.Controls.Add(this.label1);
            this.Name = "FormLaporanPenjualan";
            this.Text = "FormLaporanPenjualan";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dttglawalpenjualan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dttglakhirpenjualan;
        private System.Windows.Forms.Button btngenerate;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportvpenjualan;
    }
}