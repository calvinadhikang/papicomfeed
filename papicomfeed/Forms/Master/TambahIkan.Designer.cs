namespace papicomfeed.Forms.Master
{
    partial class TambahIkan
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
            this.BtnAddIkan = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtnamaikan = new System.Windows.Forms.TextBox();
            this.txtWaktuIkan = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnAddIkan
            // 
            this.BtnAddIkan.Location = new System.Drawing.Point(333, 222);
            this.BtnAddIkan.Name = "BtnAddIkan";
            this.BtnAddIkan.Size = new System.Drawing.Size(97, 38);
            this.BtnAddIkan.TabIndex = 0;
            this.BtnAddIkan.Text = "Tambah";
            this.BtnAddIkan.UseVisualStyleBackColor = true;
            this.BtnAddIkan.Click += new System.EventHandler(this.BtnAddIkan_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nama";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Waktu";
            // 
            // txtnamaikan
            // 
            this.txtnamaikan.Location = new System.Drawing.Point(171, 83);
            this.txtnamaikan.Name = "txtnamaikan";
            this.txtnamaikan.Size = new System.Drawing.Size(187, 26);
            this.txtnamaikan.TabIndex = 3;
            // 
            // txtWaktuIkan
            // 
            this.txtWaktuIkan.Location = new System.Drawing.Point(171, 143);
            this.txtWaktuIkan.Name = "txtWaktuIkan";
            this.txtWaktuIkan.Size = new System.Drawing.Size(187, 26);
            this.txtWaktuIkan.TabIndex = 4;
            // 
            // TambahIkan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 375);
            this.Controls.Add(this.txtWaktuIkan);
            this.Controls.Add(this.txtnamaikan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnAddIkan);
            this.Name = "TambahIkan";
            this.Text = "TambahIkan";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnAddIkan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtnamaikan;
        private System.Windows.Forms.TextBox txtWaktuIkan;
    }
}