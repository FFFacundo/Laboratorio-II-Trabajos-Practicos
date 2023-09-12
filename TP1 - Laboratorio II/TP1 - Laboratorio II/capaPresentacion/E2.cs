using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP1___Laboratorio_II.capaPresentacion
{
    public partial class E2 : Form
    {
        public E2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int suma=0;
            double promedio=0;

            suma += (Convert.ToInt32(textBox1.Text) +
                    Convert.ToInt32(textBox2.Text) +
                    Convert.ToInt32(textBox3.Text) +
                    Convert.ToInt32(textBox4.Text) );

            promedio = (suma / 4) ;

            label3.Text = "Promedio: " + promedio.ToString();
            label2.Text = "Suma: " + suma.ToString();

            label3.Visible = true;
            label2.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = String.Empty;
            textBox2.Text = String.Empty;
            textBox3.Text = String.Empty;
            textBox4.Text = String.Empty;

            label2.Visible = false;
            label2.Text = String.Empty;
            label3.Visible = false;
            label3.Text = String.Empty;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            menu m = new menu();
            m.Visible = true;
            this.Close();
        }
    }
}
