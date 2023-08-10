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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
           
        }
        int sure=25;

        private void timer1_Tick(object sender, EventArgs e)
        {
            
           

        }

        

        private void bt_yuz_Click(object sender, EventArgs e)
        {
            Yuz frm4 = new Yuz();
            frm4.ShowDialog();
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Ağac frm5 = new Ağac ();
            frm5.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form6 frm6 = new Form6();
            frm6.ShowDialog();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            sure--;
            label3.Text = "Süre =" + sure.ToString();

            if (sure == 0)
            {

                panel1.Visible = true;
                timer1.Enabled = false;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
