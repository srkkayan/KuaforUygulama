using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            int toplam;
            if(checkBox1.Checked)
            {
                listBox1.Items.Add(checkBox1.Text + " " + label1.Text);
                toplam = Convert.ToInt32(textBox1.Text) + Convert.ToInt32(label1.Text);
                textBox1.Text = toplam.ToString();
            }
            else
            {
                listBox1.Items.Remove(checkBox1.Text + " " + label1.Text);
                toplam = Convert.ToInt32(textBox1.Text) - Convert.ToInt32(label1.Text);
                textBox1.Text = toplam.ToString();
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            int toplam;
            if (checkBox2.Checked)
            {
                listBox1.Items.Add(checkBox2.Text + " " + label2.Text);
                toplam = Convert.ToInt32(textBox1.Text) + Convert.ToInt32(label2.Text);
                textBox1.Text = toplam.ToString();
            }
            else
            {
                listBox1.Items.Remove(checkBox2.Text + " " + label2.Text);
                toplam = Convert.ToInt32(textBox1.Text) - Convert.ToInt32(label2.Text);
                textBox1.Text = toplam.ToString();
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            int toplam;
            if (checkBox3.Checked)
            {
                listBox1.Items.Add(checkBox3.Text + " " + label3.Text);
                toplam = Convert.ToInt32(textBox1.Text) + Convert.ToInt32(label3.Text);
                textBox1.Text = toplam.ToString();
            }
            else
            {
                listBox1.Items.Remove(checkBox3.Text + " " + label3.Text);
                toplam = Convert.ToInt32(textBox1.Text) - Convert.ToInt32(label3.Text);
                textBox1.Text = toplam.ToString();
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            int toplam;
            if (checkBox4.Checked)
            {
                listBox1.Items.Add(checkBox4.Text + " " + label4.Text);
                toplam = Convert.ToInt32(textBox1.Text) + Convert.ToInt32(label4.Text);
                textBox1.Text = toplam.ToString();
            }
            else
            {
                listBox1.Items.Remove(checkBox4.Text + " " + label4.Text);
                toplam = Convert.ToInt32(textBox1.Text) - Convert.ToInt32(label4.Text);
                textBox1.Text = toplam.ToString();
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            int toplam;
            if (checkBox5.Checked)
            {
                listBox1.Items.Add(checkBox5.Text + " " + label5.Text);
                toplam = Convert.ToInt32(textBox1.Text) + Convert.ToInt32(label5.Text);
                textBox1.Text = toplam.ToString();
            }
            else
            {
                listBox1.Items.Remove(checkBox5.Text + " " + label5.Text);
                toplam = Convert.ToInt32(textBox1.Text) - Convert.ToInt32(label5.Text);
                textBox1.Text = toplam.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double toplam, uye, indirim,odenecektutar;
            toplam = double.Parse(textBox1.Text);

            if (checkBox6.Checked)
                uye = toplam / 20;
            else
                uye = 0;
            if (toplam >= 100)
                indirim = toplam / 10;
            else
                indirim = 0;

            odenecektutar = toplam - indirim - uye;
            richTextBox1.Text = "";
            richTextBox1.Text += "TOPLAM TUTAR = " + toplam + "\n";
            richTextBox1.Text += "İNDİRİM TUTARI = " + indirim + "\n";
            richTextBox1.Text += "ÜYE İNDİRİMİ = " + uye + "\n";
            richTextBox1.Text += "______________________ \n";
            richTextBox1.Text += "ÖDENECEK TUTAR = " + odenecektutar + "\n";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.Show();
            Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
