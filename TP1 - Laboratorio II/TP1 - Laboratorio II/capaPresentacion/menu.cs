using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP1___Laboratorio_II.capaPresentacion;

namespace TP1___Laboratorio_II
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form f = new E1();
            this.Visible = false;
            f.Visible = true;

            if (f.Visible == false)
                this.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form f2 = new E2();
            this.Visible = false;
            f2.Visible = true;

            if (f2.Visible == false)
                this.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form f3 = new E3();
            this.Visible = false;
            f3.Visible = true;
            
            if (f3.Visible == false)
                this.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form f4 = new E4();
            this.Visible = false;
            f4.Visible = true;

            if (f4.Visible == false)
                this.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form f5 = new E5();
            this.Visible = false;
            f5.Visible = true;

            if (f5.Visible == false)
                this.Visible = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //MissClick
        private void menu_Load(object sender, EventArgs e)
        {

        }
    }
}
