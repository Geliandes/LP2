using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pTesteMetodos
{
    public partial class frmExercicio5 : Form
    {
        public frmExercicio5()
        {
            InitializeComponent();
        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
            int numero1, numero2;
            Random random = new Random();
            double r = 0;

            if (txtNumero1.Text == "")
                MessageBox.Show("Insira o 1º número");

            else if (txtNumero2.Text == "")
                MessageBox.Show("Insira o 2º número");

            else if (!int.TryParse(txtNumero1.Text, out numero1) == true)
            {
                MessageBox.Show("Insira apenas números no campo 1");
                txtNumero1.Focus();
            }

            else if (!int.TryParse(txtNumero2.Text, out numero2) == true)
            {
                MessageBox.Show("Insira apenas números no campo 2");
                txtNumero2.Focus();
            }

            else if (numero1 > numero2)
                MessageBox.Show("1º Número deve ser menor que o 2º Número");

            else if (numero1 == numero2) 
                MessageBox.Show("Os números devem ser diferentes");

            else 
            {
                r = random.Next(numero1, numero2 + 1);
                MessageBox.Show("O número sorteado é: " + r.ToString());
            }
        }
    }
}
