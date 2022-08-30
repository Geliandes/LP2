using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pAtividade8
{
    public partial class frmExercicio4 : Form
    {
        public frmExercicio4()
        {
            InitializeComponent();
        }

        private void txtNome_Validated(object sender, EventArgs e)
        {
            txtNome.Text = txtNome.Text.Trim();

            string nome = txtNome.Text;
            
            
            if (txtNome.Text == "")
                txtNome.Text = "";

            else if (!Regex.IsMatch(nome, @"^[a-zA-Z+' ']+$"))
            {
                MessageBox.Show("Insira apenas letras em Nome");
                txtNome.Focus();
             }
        }

        private void txtMatricula_Validated(object sender, EventArgs e)
        {
            txtMatricula.Text = txtMatricula.Text.Trim();

            if (txtMatricula.Text == "")
                txtMatricula.Text = "";

            else if (!Double.TryParse(txtMatricula.Text, out double matricula))
            {
                MessageBox.Show("Insira apenas números em Matricula");
                txtMatricula.Focus();
            }
        }

        private void txtProducao_Validated(object sender, EventArgs e)
        {
            txtProducao.Text = txtProducao.Text.Trim();

            if (txtProducao.Text == "")
                txtProducao.Text = "";

            else if (!Double.TryParse(txtProducao.Text, out double producao))
            {
                MessageBox.Show("Insira apenas números em Produção");
                txtProducao.Focus();
            }
        }

        private void txtSalario_Validated(object sender, EventArgs e)
        {
            txtSalario.Text = txtSalario.Text.Trim();

            if (txtSalario.Text == "")
                txtSalario.Text = "";

            else if (!Double.TryParse(txtSalario.Text, out double Salario))
            {
                MessageBox.Show("Insira apenas números em Salario");
                txtSalario.Focus();
            }
        }

        private void txtGratificacao_Validated(object sender, EventArgs e)
        {
            txtGratificacao.Text = txtGratificacao.Text.Trim();

            if (txtGratificacao.Text == "")
                txtGratificacao.Text = "0";

            else if (!Double.TryParse(txtGratificacao.Text, out double Gratificacao))
            {
                MessageBox.Show("Insira apenas números em Gratificacao");
                txtGratificacao.Focus();
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double a = 0, b = 0, c = 0, d = 0, producao, gratificacao, salarioBruto;


            if ((txtNome.Text == "") || (txtCargo.Text == "") || (txtMatricula.Text == "") || (txtProducao.Text == "") || (txtSalario.Text == ""))
                MessageBox.Show("Existem campos vazios, preencha todos os campos");
            else {

                producao = Convert.ToDouble(txtProducao.Text);
                gratificacao = Convert.ToDouble(txtGratificacao.Text);
                a = Convert.ToDouble(txtSalario.Text);

                if (producao >= 150)
                {
                    b = 1;
                    c = 1;
                    d = 1;
                }
                else if (producao >= 120)
                {
                    b = 1;
                    c = 1;
                }
                else if (producao >= 100)
                    b = 1;

                salarioBruto = a + a * (0.05 * b + 0.1 * c + 0.1 * d) + gratificacao;

                if (salarioBruto > 7000)
                {
                    if ((producao >= 150) && (gratificacao > 0))
                    { }
                    else
                        salarioBruto = 7000;
                }

                txtSalarioBruto.Text = salarioBruto.ToString();
            }
        }
    }
}
