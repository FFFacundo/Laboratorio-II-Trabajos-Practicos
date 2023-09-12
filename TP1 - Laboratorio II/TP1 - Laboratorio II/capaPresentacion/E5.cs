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
    public partial class E5 : Form
    {
        public E5()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
        private void button3_Click(object sender, EventArgs e)
        {
            menu m = new menu();
            m.Visible = true;
            this.Close();
        }




        // Ignorar - missClick
        private void E5_Load(object sender, EventArgs e)
        {

        }

        
    }
}
