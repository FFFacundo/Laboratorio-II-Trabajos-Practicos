using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPN1_Lab._2doCuartimestro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(textBox1.Text);
            int num2 = Convert.ToInt16(textBox2.Text);
            int resultado = num1 * num2;
            textBox3.Text = resultado.ToString();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string texto = textBox4.Text;
            string[] numeros = texto.Split('+');
            int nume1 = int.Parse(numeros[0]);
            int nume2 = int.Parse(numeros[1]);
            int nume3 = int.Parse(numeros[2]);
            int nume4 = int.Parse(numeros[3]);
            int resultado = nume1 + nume2 + nume3 + nume4;
            int promedio = resultado / 4;
            textBox5.Text = resultado.ToString();
            textBox6.Text = promedio.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }
    }
}
