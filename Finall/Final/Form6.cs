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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd3 = new SaveFileDialog();
            sfd3.Title = "Farklı Kaydet";
            sfd3.Filter = "Png Dosyası|*.png; |Jpg Dosyası|*.jpg; |Tüm Dosyalar|*.*";
            if (sfd3.ShowDialog() == DialogResult.OK)
            {
                String path = Path.GetFullPath(sfd3.FileName);
                MessageBox.Show(path);
                pictureBox1.BackgroundImage.Save(path);
                Application.Exit ();
            }
        }

        private void kaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd3 = new SaveFileDialog();
            sfd3.Title = "Farklı Kaydet";
            sfd3.Filter = "Png Dosyası|*.png; |Jpg Dosyası|*.jpg; |Tüm Dosyalar|*.*";
            if (sfd3.ShowDialog() == DialogResult.OK)
            {
                String path = Path.GetFullPath(sfd3.FileName);
                MessageBox.Show(path);
                pictureBox1.BackgroundImage.Save(path);
                Application.Exit ();
            }
        }

        private void hakkındaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form7 frm7 = new Form7();
            frm7.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
