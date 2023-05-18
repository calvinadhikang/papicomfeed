namespace papicomfeed.Forms.Master
{
    partial class FormLaporanPembelian
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
            this.dttglawal = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dttglakhir = new System.Windows.Forms.DateTimePicker();
            this.btngenerate = new System.Windows.Forms.Button();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tanggal Awal :";
            // 
            // dttglawal
            // 
            this.dttglawal.Location = new System.Drawing.Point(135, 13);
            this.dttglawal.Name = "dttglawal";
            this.dttglawal.Size = new System.Drawing.Size(200, 26);
            this.dttglawal.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(380, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tanggal Akhir :";
            // 
            // dttglakhir
            // 
            this.dttglakhir.Location = new System.Drawing.Point(501, 13);
            this.dttglakhir.Name = "dttglakhir";
            this.dttglakhir.Size = new System.Drawing.Size(200, 26);
            this.dttglakhir.TabIndex = 3;
            // 
            // btngenerate
            // 
            this.btngenerate.Location = new System.Drawing.Point(743, 13);
            this.btngenerate.Name = "btngenerate";
            this.btngenerate.Size = new System.Drawing.Size(117, 34);
            this.btngenerate.TabIndex = 4;
            this.btngenerate.Text = "Generate";
            this.btngenerate.UseVisualStyleBackColor = true;
            this.btngenerate.Click += new System.EventHandler(this.btngenerate_Click);
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 53);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(1013, 483);
            this.crystalReportViewer1.TabIndex = 5;
            // 
            // FormLaporanPembelian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 536);
            this.Controls.Add(this.crystalReportViewer1);
            this.Controls.Add(this.btngenerate);
            this.Controls.Add(this.dttglakhir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dttglawal);
            this.Controls.Add(this.label1);
            this.Name = "FormLaporanPembelian";
            this.Text = "FormLaporanPembelian";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dttglawal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dttglakhir;
        private System.Windows.Forms.Button btngenerate;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
    }
}