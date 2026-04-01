using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            string slika = openFileDialog1.FileName;
            pictureBox1.Load(slika);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            string slika = openFileDialog1.FileName;
            string spol = " ";
            string kastriran = " ";
            if (checkBox1.Checked == true)
            {
                kastriran = "kastriran";
            }
            else
            {
                kastriran = "nekastriran";
            }
            string cijepljen = " ";
            if (checkBox2.Checked == true)
            {
                cijepljen = "cijepljen";
            }
            else
            {
                cijepljen = "necijepljen";
            }
            if (radioButton1.Checked == true)
            {
                spol = "muško";
            }
            else
            {
                spol = "žensko";
            }
            string zapis = textBox1.Text + "|" + textBox2.Text + "|" + textBox3.Text + "|"  + spol + "|" + numericUpDown1.Text + "|" + dateTimePicker1.Text + "|" + cijepljen + "|" + kastriran + "|"+ textBox4.Text + "|"+ slika;
        }
    }
}
