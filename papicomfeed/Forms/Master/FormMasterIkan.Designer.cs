
namespace papicomfeed.Forms.Master
{
    partial class FormMasterIkan
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
            this.btnTambahIkan = new System.Windows.Forms.Button();
            this.dataListIkan = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataListIkan)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTambahIkan
            // 
            this.btnTambahIkan.BackColor = System.Drawing.Color.GhostWhite;
            this.btnTambahIkan.Location = new System.Drawing.Point(601, 515);
            this.btnTambahIkan.Name = "btnTambahIkan";
            this.btnTambahIkan.Size = new System.Drawing.Size(171, 35);
            this.btnTambahIkan.TabIndex = 8;
            this.btnTambahIkan.Text = "Tambah Data";
            this.btnTambahIkan.UseVisualStyleBackColor = false;
            this.btnTambahIkan.Click += new System.EventHandler(this.btnTambahIkan_Click);
            this.btnTambahIkan.MouseLeave += new System.EventHandler(this.btnTambahIkan_MouseLeave);
            this.btnTambahIkan.MouseHover += new System.EventHandler(this.btnTambahIkan_MouseHover);
            // 
            // dataListIkan
            // 
            this.dataListIkan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataListIkan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataListIkan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataListIkan.Location = new System.Drawing.Point(12, 63);
            this.dataListIkan.Name = "dataListIkan";
            this.dataListIkan.RowHeadersWidth = 62;
            this.dataListIkan.Size = new System.Drawing.Size(760, 446);
            this.dataListIkan.TabIndex = 7;
            this.dataListIkan.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataListIkan_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(317, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Master Ikan";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // FormMasterIkan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.btnTambahIkan);
            this.Controls.Add(this.dataListIkan);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FormMasterIkan";
            this.Text = "FormMasterIkan";
            this.Load += new System.EventHandler(this.FormMasterIkan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataListIkan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTambahIkan;
        private System.Windows.Forms.DataGridView dataListIkan;
        private System.Windows.Forms.Label label1;
    }
}