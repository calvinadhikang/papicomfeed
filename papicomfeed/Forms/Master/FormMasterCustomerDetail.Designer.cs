
namespace papicomfeed.Forms.Master
{
    partial class FormMasterCustomerDetail
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
            this.txtId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNamaCustomer = new System.Windows.Forms.TextBox();
            this.txtAlamatCustomer = new System.Windows.Forms.TextBox();
            this.txtTelpCustomer = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(111, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Detail Customer";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(116, 55);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(298, 37);
            this.txtId.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 31);
            this.label2.TabIndex = 0;
            this.label2.Text = "ID :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 31);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nama :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 31);
            this.label4.TabIndex = 0;
            this.label4.Text = "Alamat :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 31);
            this.label5.TabIndex = 0;
            this.label5.Text = "Telp :";
            // 
            // txtNamaCustomer
            // 
            this.txtNamaCustomer.Location = new System.Drawing.Point(116, 92);
            this.txtNamaCustomer.Name = "txtNamaCustomer";
            this.txtNamaCustomer.Size = new System.Drawing.Size(298, 37);
            this.txtNamaCustomer.TabIndex = 1;
            // 
            // txtAlamatCustomer
            // 
            this.txtAlamatCustomer.Location = new System.Drawing.Point(116, 129);
            this.txtAlamatCustomer.Name = "txtAlamatCustomer";
            this.txtAlamatCustomer.Size = new System.Drawing.Size(298, 37);
            this.txtAlamatCustomer.TabIndex = 1;
            // 
            // txtTelpCustomer
            // 
            this.txtTelpCustomer.Location = new System.Drawing.Point(116, 166);
            this.txtTelpCustomer.Name = "txtTelpCustomer";
            this.txtTelpCustomer.Size = new System.Drawing.Size(298, 37);
            this.txtTelpCustomer.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(325, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 37);
            this.button1.TabIndex = 2;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(325, 203);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(89, 37);
            this.button2.TabIndex = 2;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FormMasterCustomerDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 262);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtTelpCustomer);
            this.Controls.Add(this.txtAlamatCustomer);
            this.Controls.Add(this.txtNamaCustomer);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FormMasterCustomerDetail";
            this.Text = "FormMasterCustomerDetail";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNamaCustomer;
        private System.Windows.Forms.TextBox txtAlamatCustomer;
        private System.Windows.Forms.TextBox txtTelpCustomer;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}