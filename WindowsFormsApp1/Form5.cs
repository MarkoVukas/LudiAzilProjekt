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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        int i = 0;
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            List<string> lista = Admin.Ucitaj();
            foreach (string s in lista)
            {
                listBox1.Items.Add(s.Replace("|", " "));
            }
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            i = listBox1.SelectedIndex;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.RemoveAt(i);
            string zapis = dateTimePicker1.Value .ToString() + "|" + textBox1.Text +"|" + textBox2.Text + "|" + textBox3.Text + "|" + textBox4.Text;
            Admin.UnosUdomitelja(zapis);
        }

        
    }
}
