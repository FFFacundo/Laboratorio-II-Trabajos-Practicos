﻿using System;
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
    public partial class E3 : Form
    {
        public E3()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double prom = 0;

            prom += Convert.ToDouble(textBox1.Text);
            prom += Convert.ToDouble(textBox2.Text);
            prom += Convert.ToDouble(textBox3.Text);

            prom = prom / 3;

            if (prom >= 7)
                MessageBox.Show("Promocionado");
            else
                MessageBox.Show("No Promociono");

            textBox1.Text = String.Empty;
            textBox2.Text = String.Empty;
            textBox3.Text = String.Empty;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            menu m = new menu();
            m.Visible = true;
            this.Close();
        }
    }
}
