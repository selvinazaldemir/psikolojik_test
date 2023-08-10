﻿using System;
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
    public partial class Ağac : Form
    {
        public Ağac()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd2 = new SaveFileDialog();
            sfd2.Title = "Farklı Kaydet";
            sfd2.Filter = "Png Dosyası|*.png; |Jpg Dosyası |*.jpg; |Tüm Dosyalar|*.*";
            if (sfd2.ShowDialog() == DialogResult.OK)
            {
                String path = Path.GetFullPath(sfd2.FileName);
                MessageBox.Show(path);
                pictureBox1.BackgroundImage.Save(path);
                Application.Exit ();
            }
                

        }

        private void kaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd2 = new SaveFileDialog();
            sfd2.Title = "Farklı Kaydet";
            sfd2.Filter = "Png Dosyası|*.png; |Jpg Dosyası |*.jpg; |Tüm Dosyalar|*.*";
            if (sfd2.ShowDialog() == DialogResult.OK)
            {
                String path = Path.GetFullPath(sfd2.FileName);
                MessageBox.Show(path);
                pictureBox1.BackgroundImage.Save(path);
                Application.Exit();
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
