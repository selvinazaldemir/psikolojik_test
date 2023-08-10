using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Final
{
    public partial class Form1 : Form
    {
        private string filePath;
        private string fileContent;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tb_ad.Text == "")
                MessageBox.Show("Kullanıcı Adı Alanı Boş Geçilemez!!", " HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (tb_password.Text == "")
                MessageBox.Show("Parola Alanı Boş Geçilemez!!", " HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                MessageBox.Show("Hoşgeldiniz " + tb_ad.Text);
                Form3 frm3 = new Form3();
                frm3.ShowDialog();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form7 frm7 = new Form7();
            frm7.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            // open file dialog   
            OpenFileDialog open = new OpenFileDialog();
            // image filters  
            open.Filter = "Image Files(*.jpg; *.png; *.jpeg)|*.jpg; *.png; *.jpeg";
            if (open.ShowDialog() == DialogResult.OK)
            {
                // display image in picture box  
                pb_avatar.Image = new Bitmap(open.FileName);
                // image file path  
                textBox1.Text = open.FileName;

                /* var dialog = new OpenFileDialog();

                 dialog.Title = "Resmi Aç";
                 dialog.Filter = "Png Dosyaları (*.png)|*.png";

                 if (dialog.ShowDialog() == DialogResult.OK)
                 {
                     //var pb_avatar  = new PictureBox();
                     //pb_avatar.Image(dialog.FileName);

                 }

                 dialog.Dispose();/* 

                 /*OpenFileDialog ofd = new OpenFileDialog();
                 ofd.Title = "Lütfen Bir Dosya Seçiniz.";
                 ofd.Filter = "Png Dosyası|*.png|Jpg Dosyası|*.jpg|Tüm Dosyalar|*.*";
                 ofd.Multiselect = false;



                 if (ofd.ShowDialog() == DialogResult.OK)
                 {

                     ofd.InitialDirectory = "c:\\";
                     ofd.Filter = "Png files (*.png)|*.png|Tüm Dosyalar (*.*)|*.*";
                     ofd.FilterIndex = 2;
                     ofd.RestoreDirectory = true;


                     if (ofd.ShowDialog() == DialogResult.OK)
                     {
                         //Get the path of specified file
                         filePath = ofd.FileName;

                         //Read the contents of the file into a stream
                         var fileStream = ofd.OpenFile();

                         using (StreamReader reader = new StreamReader(fileStream))
                         {
                             fileContent = reader.ReadToEnd();
                         }
                     }*/

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}



