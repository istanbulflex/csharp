using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tgundogdu2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Merhaba Dünya");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Merhaba" + " " + textBox1.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Merhaba" + " " + textBox2.Text + " " + textBox3.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int sayi1 = Convert.ToInt32(textBox4.Text);
            int sayi2 = Convert.ToInt32(textBox5.Text);
            int toplam = sayi1 + sayi2;
            MessageBox.Show(textBox4.Text + "+" + textBox5.Text + "=" + " " + toplam);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox6.Text);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button7_MouseMove(object sender, MouseEventArgs e)
        {
            label1.Text = "Mouse Üzerinde";
            label1.BackColor = Color.Green;
        }

        private void button7_MouseLeave(object sender, EventArgs e)
        {
            label1.Text = "Mouse Dışarıda";
            label1.BackColor = Color.Red;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Visible = radioButton1.Checked;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox2.Visible = radioButton2.Checked;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox3.Visible = radioButton3.Checked;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            radioButton4.Checked = true;
            radioButton7.Checked = true;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            button8.Enabled = true;
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            button8.Enabled = false;
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            button8.Visible = true;
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            button8.Visible = false;
        }
    }
}
