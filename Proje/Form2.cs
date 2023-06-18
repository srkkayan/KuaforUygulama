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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "özcan" && textBox2.Text == "12345")
            {
                Form4 frm4 = new Form4();
                frm4.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı veya Parola Hatalı", "DİKKAT");
                textBox1.Clear();
                textBox2.Clear();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
