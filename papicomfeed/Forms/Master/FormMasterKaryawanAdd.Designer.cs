
namespace papicomfeed.Forms.Master
{
    partial class FormMasterKaryawanAdd
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
            this.button1 = new System.Windows.Forms.Button();
            this.cbStatus = new System.Windows.Forms.CheckBox();
            this.cmbRole = new System.Windows.Forms.ComboBox();
            this.tbTelp = new System.Windows.Forms.TextBox();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.tbNama = new System.Windows.Forms.TextBox();
            this.tbId = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(400, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 36);
            this.button1.TabIndex = 20;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // cbStatus
            // 
            this.cbStatus.AutoSize = true;
            this.cbStatus.Location = new System.Drawing.Point(146, 249);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(90, 35);
            this.cbStatus.TabIndex = 19;
            this.cbStatus.Text = "Aktif";
            this.cbStatus.UseVisualStyleBackColor = true;
            // 
            // cmbRole
            // 
            this.cmbRole.FormattingEnabled = true;
            this.cmbRole.Items.AddRange(new object[] {
            "Admin",
            "Penjualan",
            "Pembelian",
            "Pemeliharaan"});
            this.cmbRole.Location = new System.Drawing.Point(146, 210);
            this.cmbRole.Name = "cmbRole";
            this.cmbRole.Size = new System.Drawing.Size(347, 38);
            this.cmbRole.TabIndex = 18;
            // 
            // tbTelp
            // 
            this.tbTelp.Location = new System.Drawing.Point(146, 173);
            this.tbTelp.Name = "tbTelp";
            this.tbTelp.Size = new System.Drawing.Size(347, 37);
            this.tbTelp.TabIndex = 14;
            // 
            // tbUsername
            // 
            this.tbUsername.Location = new System.Drawing.Point(146, 136);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(347, 37);
            this.tbUsername.TabIndex = 15;
            // 
            // tbNama
            // 
            this.tbNama.Location = new System.Drawing.Point(146, 99);
            this.tbNama.Name = "tbNama";
            this.tbNama.Size = new System.Drawing.Size(347, 37);
            this.tbNama.TabIndex = 16;
            // 
            // tbId
            // 
            this.tbId.Enabled = false;
            this.tbId.Location = new System.Drawing.Point(146, 62);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(347, 37);
            this.tbId.TabIndex = 17;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(400, 295);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(93, 36);
            this.button2.TabIndex = 13;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(55, 250);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 31);
            this.label7.TabIndex = 6;
            this.label7.Text = "Status :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(72, 213);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 31);
            this.label6.TabIndex = 7;
            this.label6.Text = "Role :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(74, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 31);
            this.label5.TabIndex = 8;
            this.label5.Text = "Telp :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 31);
            this.label4.TabIndex = 9;
            this.label4.Text = "Username :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 31);
            this.label3.TabIndex = 10;
            this.label3.Text = "Nama :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(96, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 31);
            this.label2.TabIndex = 11;
            this.label2.Text = "ID :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(141, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 31);
            this.label1.TabIndex = 12;
            this.label1.Text = "Tambah Karyawan";
            // 
            // FormMasterKaryawanAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 340);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbStatus);
            this.Controls.Add(this.cmbRole);
            this.Controls.Add(this.tbTelp);
            this.Controls.Add(this.tbUsername);
            this.Controls.Add(this.tbNama);
            this.Controls.Add(this.tbId);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FormMasterKaryawanAdd";
            this.Text = "FormMasterKaryawanAdd";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox cbStatus;
        private System.Windows.Forms.ComboBox cmbRole;
        private System.Windows.Forms.TextBox tbTelp;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.TextBox tbNama;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}