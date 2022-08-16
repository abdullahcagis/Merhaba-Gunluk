using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MerhabaGunluk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //private void Form1_Load(object sender, EventArgs e)
        //{
        //    saveFileDialog1.Filter = "Zengin Metin Biçimi | *.rtf";
        //}
        private void TSMI_ac_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string path = openFileDialog1.FileName;
                richTextBox1.LoadFile(path);
            }
        }

        private void TSMI_kaydet_Click(object sender, EventArgs e)
        {
            if(saveFileDialog1.ShowDialog()== DialogResult.OK)
            {
                string path = saveFileDialog1.FileName;
                richTextBox1.SaveFile(path);
                MessageBox.Show("Kayıt İşlemi Başarılı Bir Şekilde Yapılmıştır", "Kayıt Başarılı");
            }
        }

        private void TSbtn_Yeni_Click(object sender, EventArgs e)
        {
            
        }

        private void TSbtn_ac_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string path = openFileDialog1.FileName;
                richTextBox1.LoadFile(path);
            }
        }

        private void TSbtn_kaydet_Click(object sender, EventArgs e)
        {
            if(saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string path = saveFileDialog1.FileName;
                richTextBox1.SaveFile(path);
            }
        }

        private void TSMI_font_Click(object sender, EventArgs e)
        {
            if(fontDialog1.ShowDialog() == DialogResult.OK)
            {
                //richTextBox1.Font = fontDialog1.Font;
                richTextBox1.SelectionFont = fontDialog1.Font;
            }
        }

        private void TSMI_renk_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                //richTextBox1.Font = fontDialog1.Font;
                richTextBox1.SelectionColor = colorDialog1.Color;
            }
        }
    }
}
