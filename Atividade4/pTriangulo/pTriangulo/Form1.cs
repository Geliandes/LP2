using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pTriangulo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double ladoA, ladoB, ladoC;

        private void txtLadoA_Validated(object sender, EventArgs e)
        {
            if (txtLadoA.Text.Length == 0)
                txtLadoA.Text = "";

            else
                if (!Double.TryParse(txtLadoA.Text, out ladoA))
                MessageBox.Show("Insira um número válido");

            else
                if (ladoA <= 0)
            {
                MessageBox.Show("Valor deve ser maior que zero");
                txtLadoA.Text = null;
                txtLadoA.Focus();
            }
        }

        private void txtLadoB_Validated(object sender, EventArgs e)
        {
            if (txtLadoB.Text.Length == 0)
                txtLadoB.Text = "";
            else
                if (!Double.TryParse(txtLadoB.Text, out ladoB))
                MessageBox.Show("Insira um número válido");

            else
                if (ladoB <= 0)
            {
                MessageBox.Show("Valor deve ser maior que zero");
                txtLadoB.Text = null;
                txtLadoB.Focus();
            }
        }
        private void txtLadoC_Validated(object sender, EventArgs e)
        {
            if (txtLadoC.Text.Length == 0)
                txtLadoC.Text = "";
            else
                if (!Double.TryParse(txtLadoC.Text, out ladoC))
                MessageBox.Show("Insira um número válido");

            else
                if (ladoC <= 0)
            {
                MessageBox.Show("Valor deve ser maior que zero");
                txtLadoC.Text = null;
                txtLadoC.Focus();
            }
        }

        private void btn_Click(object sender, EventArgs e)
        {
            if (txtLadoA.Text.Length == 0 || txtLadoB.Text.Length == 0 || txtLadoC.Text.Length == 0)
                MessageBox.Show("Insira um número");
            else
                if ((ladoA < ladoB + ladoC) && (ladoA > ladoB - ladoC) && (ladoB < ladoA + ladoC) && (ladoB > ladoA - ladoC) && (ladoC < ladoA + ladoB) && (ladoC > ladoA - ladoB))
                {

                    if ((ladoA == ladoB) && (ladoB == ladoC))
                        MessageBox.Show("Triângulo Equilatero");
                    else
                        if (ladoA == ladoB || ladoA == ladoC || ladoB == ladoC)
                        MessageBox.Show("Triângulo Isósceles");
                    
                        else
                        MessageBox.Show("Triângulo Escaleno");
                }

                else
                {
                    MessageBox.Show("Não é Triângulo");
                    txtLadoA.Text = null;
                    txtLadoB.Text = null;
                    txtLadoC.Text = null;
                    txtLadoA.Focus();
                }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblTitulo.BackColor = Color.Transparent;
            lblLadoA.BackColor = Color.Transparent;
            lblLadoB.BackColor = Color.Transparent;
            lblLadoC.BackColor = Color.Transparent;
        }
    }
}
