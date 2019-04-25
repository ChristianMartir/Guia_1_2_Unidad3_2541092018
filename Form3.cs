using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guia_2
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            double Fragmento, cr1;
            cr1 = Convert.ToDouble(textBox1.Text);
            Fragmento = cr1 * 1.8 + 32.0;
            textBox2.Text = Fragmento.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double Centigrados, ct1;
            ct1 = Convert.ToDouble(textBox1.Text);
            Centigrados = (ct1 - 32.0) / 1.8;
            textBox2.Text = Centigrados.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
