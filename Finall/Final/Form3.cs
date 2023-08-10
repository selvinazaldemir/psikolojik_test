using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Final
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void bt_kisiliktest_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.ShowDialog();
            timer1.Enabled = true;
        }

        private void lb_hg_Click(object sender, EventArgs e)
        {
            //lb_hg.Text = "Hoşgeldiniz " + tb_ad.text;
        }
       
        private void lb_hg_Click_1(object sender, EventArgs e)
        {
           // lb_hg.Text = "Hoşgeldiniz";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        /*private void bt_muzik_Click(object sender, EventArgs e)
        {
            sarki frm8 = new sarki();
            frm8.ShowDialog();
        }*/
    }
}
