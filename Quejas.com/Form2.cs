using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quejas.com
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Cirno" && textBox2.Text == "11037")
            {
                MessageBox.Show("Bienvenido");
                string value = textBox1.Text;
                Form3 form3 = new Form3(value);
                form3.Show();
                this.Hide();
            }
            else {
                MessageBox.Show("Nombre equivocado");
            }
        }
    }
}
