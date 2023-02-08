using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Saat__kronometre_tarzı_uygulamalar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int saat;
        int dakika;
        int saniye;
        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.Hour.ToString();
            label2.Text = DateTime.Now.Minute.ToString();
            label3.Text = DateTime.Now.Second.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer2.Enabled = true;
            button2.Enabled = false;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (timer2.Enabled == true) { timer2.Enabled = false; }
            else { timer2.Enabled = true; }
        }
 
        private void timer2_Tick(object sender, EventArgs e)
        {
            saat = Convert.ToInt32(label4.Text);
            label4.Text = saat.ToString();
            dakika = Convert.ToInt32(label5.Text);
            label5.Text = dakika.ToString();
            saniye =Convert.ToInt32(label6.Text);  
            saniye++;
            label6.Text = saniye.ToString();
            if (saniye ==60 )
            {
                saniye =0;
                label6.Text =saniye.ToString();
                dakika++;
                label5.Text = dakika.ToString();
            }  
            if (dakika == 60)
            {
                dakika= 0;
                label5.Text = dakika.ToString();
                saat++;
                label4.Text = saat.ToString();
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            label4.Text = 0.ToString();
            label5.Text = 0.ToString();
            label6.Text = 0.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string a = saat + " " + dakika + " " + saniye;
            listBox1.Items.Add(a);
        }
    }
}
