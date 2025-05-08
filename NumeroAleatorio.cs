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
    public partial class NumeroAleatorio : Form
    {
        int aleatorio = 0;
        Random rand = new Random();

        public NumeroAleatorio()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(TxtnumMax.Text, out int numMax))
            {
                if (numMax < 1)
                {
                    MessageBox.Show("ingrese un numero positivo");
                }
                else
                {

                 aleatorio = rand.Next(1, numMax);
                 MessageBox.Show($"Número:{aleatorio}");
                }
            }
            else
            {
                MessageBox.Show("ingrese un número válido");
            }
        }
    }
}
