using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace pAtividade8
{
    public partial class frmExercicio2 : Form
    {
        public frmExercicio2()
        {
            InitializeComponent();
        }

        private void frmExercicio2_Load(object sender, EventArgs e)
        {
            double preco, faturamento = 0, total, produto = 1;
            string auxQuantidade, auxPreco, espacos = "            ";

            lbxPrincipal.Items.Add("Produto      Qtde            Preço                  Total");

            for (int i = 0; i < 10; i++)
            {

                auxQuantidade = Interaction.InputBox("Digite a quantidade do " + (i + 1) + "º produto", "Entrada de Dados");
                if (auxQuantidade == "")
                    break;

                auxPreco = Interaction.InputBox("Digite o preco do " + (i + 1) + "º produto", "Entrada de Dados");
                if (auxQuantidade == "")
                    break;

                else
                {
                    preco = Convert.ToDouble(auxPreco);

                    total = Convert.ToDouble(auxQuantidade) * Convert.ToDouble(auxPreco);

                    if (preco >= 1000)
                        espacos = "      |   ";
                    else if (preco >= 100)
                        espacos = "        |   ";
                    else if (preco >= 10)
                        espacos = "          |   ";
                    else
                        espacos = "            |   ";

                    lbxPrincipal.Items.Add(produto.ToString("00") + "           |    " + auxQuantidade.PadLeft(2, '0') + "           |    " + "R$ " + preco.ToString("F") + espacos + "R$ " + total.ToString("F"));

                    auxQuantidade = "";
                    auxPreco = "";
                    produto++;

                    faturamento += total;
                }
            }
            txtFaturamento.Text = faturamento.ToString();

        }
    }
}
