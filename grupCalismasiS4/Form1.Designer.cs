namespace grupCalismasiS4
{
    partial class Form1
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
            this.btnYaziTipi = new System.Windows.Forms.Button();
            this.btnYazıRengi = new System.Windows.Forms.Button();
            this.btnPaste = new System.Windows.Forms.Button();
            this.btnCopy = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnDosyayaKaydet = new System.Windows.Forms.Button();
            this.btnDosyadanAl = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnYaziTipi
            // 
            this.btnYaziTipi.Location = new System.Drawing.Point(12, 52);
            this.btnYaziTipi.Name = "btnYaziTipi";
            this.btnYaziTipi.Size = new System.Drawing.Size(75, 23);
            this.btnYaziTipi.TabIndex = 0;
            this.btnYaziTipi.Text = "Yazı Tipi";
            this.btnYaziTipi.UseVisualStyleBackColor = true;
            this.btnYaziTipi.Click += new System.EventHandler(this.btnYaziTipi_Click);
            // 
            // btnYazıRengi
            // 
            this.btnYazıRengi.Location = new System.Drawing.Point(12, 101);
            this.btnYazıRengi.Name = "btnYazıRengi";
            this.btnYazıRengi.Size = new System.Drawing.Size(75, 23);
            this.btnYazıRengi.TabIndex = 0;
            this.btnYazıRengi.Text = "Yazı Rengi";
            this.btnYazıRengi.UseVisualStyleBackColor = true;
            this.btnYazıRengi.Click += new System.EventHandler(this.btnYazıRengi_Click);
            // 
            // btnPaste
            // 
            this.btnPaste.Location = new System.Drawing.Point(12, 202);
            this.btnPaste.Name = "btnPaste";
            this.btnPaste.Size = new System.Drawing.Size(75, 23);
            this.btnPaste.TabIndex = 0;
            this.btnPaste.Text = "Paste";
            this.btnPaste.UseVisualStyleBackColor = true;
            this.btnPaste.Click += new System.EventHandler(this.btnPaste_Click);
            // 
            // btnCopy
            // 
            this.btnCopy.Location = new System.Drawing.Point(12, 150);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(75, 23);
            this.btnCopy.TabIndex = 0;
            this.btnCopy.Text = "Copy";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(114, 52);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(254, 173);
            this.textBox1.TabIndex = 1;
            // 
            // btnDosyayaKaydet
            // 
            this.btnDosyayaKaydet.Location = new System.Drawing.Point(397, 73);
            this.btnDosyayaKaydet.Name = "btnDosyayaKaydet";
            this.btnDosyayaKaydet.Size = new System.Drawing.Size(67, 51);
            this.btnDosyayaKaydet.TabIndex = 0;
            this.btnDosyayaKaydet.Text = "Dosyaya Kaydet";
            this.btnDosyayaKaydet.UseVisualStyleBackColor = true;
            this.btnDosyayaKaydet.Click += new System.EventHandler(this.btnDosyayaKaydet_Click);
            // 
            // btnDosyadanAl
            // 
            this.btnDosyadanAl.Location = new System.Drawing.Point(397, 150);
            this.btnDosyadanAl.Name = "btnDosyadanAl";
            this.btnDosyadanAl.Size = new System.Drawing.Size(67, 51);
            this.btnDosyadanAl.TabIndex = 0;
            this.btnDosyadanAl.Text = "Dosyadan Al";
            this.btnDosyadanAl.UseVisualStyleBackColor = true;
            this.btnDosyadanAl.Click += new System.EventHandler(this.btnDosyadanAl_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 325);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.btnPaste);
            this.Controls.Add(this.btnYazıRengi);
            this.Controls.Add(this.btnDosyadanAl);
            this.Controls.Add(this.btnDosyayaKaydet);
            this.Controls.Add(this.btnYaziTipi);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnYaziTipi;
        private System.Windows.Forms.Button btnYazıRengi;
        private System.Windows.Forms.Button btnPaste;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnDosyayaKaydet;
        private System.Windows.Forms.Button btnDosyadanAl;
    }
}

