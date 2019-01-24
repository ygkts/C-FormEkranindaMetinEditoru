using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace grupCalismasiS4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string yazi;
        private void btnYaziTipi_Click(object sender, EventArgs e)
        { 
            FontDialog fontDialog1 = new FontDialog();
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Font = fontDialog1.Font;
            }
            
        }

        private void btnYazıRengi_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog1 = new ColorDialog();
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.ForeColor = colorDialog1.Color;
            }
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            if (textBox1.SelectionLength > 0)
            {
                textBox1.Copy();
            }
            else
            {
                MessageBox.Show("Şu anda seçili alan yok.");
            }
        }

        private void btnPaste_Click(object sender, EventArgs e)
        {
            textBox1.Paste();
        }

        private void btnDosyayaKaydet_Click(object sender, EventArgs e)
        {
            
            StreamWriter sw = new StreamWriter(@"C:\Users\iau\Desktop\KURS_11Aralık2018\dosya.txt", true);
            
            sw.WriteLine(textBox1.Text);
            MessageBox.Show("Kayıt Başarılı..");
            sw.Flush();
            sw.Close();

        }

        private void btnDosyadanAl_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader(@"C:\Users\iau\Desktop\KURS_11Aralık2018\dosya.txt", true);
            yazi = sr.ReadToEnd();
            sr.Close();
        }
    }
}
