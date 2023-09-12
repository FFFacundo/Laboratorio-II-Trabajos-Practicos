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
    public partial class E4 : Form
    {
        public E4()
        {
            InitializeComponent();
        }

        int contMenor = 0, contMayor = 0;
        double importe=0;


        private void button1_Click(object sender, EventArgs e)
        {
            double sueldo = Convert.ToDouble(textBox1.Text);
            if (sueldo>=100 && sueldo<=300)
            {
                importe += sueldo;
                contMenor++; // Cobra entre 100 y 300
            } else if (sueldo>300 && sueldo <= 500)
            {
                importe += sueldo;
                contMayor++; //Cobra mas de 300
            }
            else
            {
                MessageBox.Show("El sueldo ingresado fue incorrecto");
            }
            textBox1.Text=String.Empty;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            menu m = new menu();
            m.Visible = true;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            string sueldo1, sueldo2, total;
            sueldo1 = contMenor.ToString();
            sueldo2 = contMayor.ToString();
            total = importe.ToString();

            MessageBox.Show(sueldo1 + " empleados cobran entre $100 y $300\n"
                          + sueldo2 + " empleados cobran mas de $300\n"
                          + "La empresa debe pagar un total de: $" + total);
        }
    }
}
