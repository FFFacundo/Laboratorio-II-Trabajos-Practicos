using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TP1___Laboratorio_II.capaPresentacion
{
    public partial class E1 : Form
    {
        public E1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(textBox1.Text);
            int num2 = Convert.ToInt16(textBox2.Text);
            int resultado = num1 * num2;
            label3.Text = resultado.ToString();
            label3.Visible = true;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text=String.Empty;
            textBox2.Text=String.Empty;
            label3.Visible=false;
            label3.Text=String.Empty;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            menu m = new menu();
            m.Visible = true;
            this.Close();
        }
    }
}
