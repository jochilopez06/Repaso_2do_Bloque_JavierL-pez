using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Repaso_2do_Bloque_JavierLópez
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NumeroAleatorio repaso1 = new NumeroAleatorio();
            repaso1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AlumnoAleatorio repaso2 = new AlumnoAleatorio();
            repaso2.Show();
        }
    }
}
