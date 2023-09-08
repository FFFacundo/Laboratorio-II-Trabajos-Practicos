using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Punto3___TP1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double prom = 0;

            prom += Convert.ToDouble(textBox1.Text);
            prom += Convert.ToDouble(textBox2.Text);
            prom += Convert.ToDouble(textBox3.Text);

            prom = prom/3;

            if (prom >= 7)
                MessageBox.Show("Promocionado");
            else
                MessageBox.Show("Te toco entregar el chikitito.");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
