using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Double salarioBruto, numeroDeFilhos, nome;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void mskbxNomeFuncionario_Validated(object sender, EventArgs e)
        {
            if (!Double.TryParse(mskbxNomeFuncionario.Text, out nome))
                Convert.ToString(mskbxNomeFuncionario.Text);
            else
            {
                MessageBox.Show("Digite um nome válido");
                mskbxNomeFuncionario.Text = "";
            }
        }

        private void mskbxNumeroDeFilhos_Validated(object sender, EventArgs e)
        {
            if (mskbxNumeroDeFilhos.Text == "")
            {
                mskbxNumeroDeFilhos.Text = "0";
                numeroDeFilhos = 0;
            }
            else
            if (!Double.TryParse(mskbxNumeroDeFilhos.Text, out numeroDeFilhos))
            {
                MessageBox.Show("Digite um número de filhos válido");
                mskbxNumeroDeFilhos.Text = "";
                mskbxNumeroDeFilhos.Focus();
            }
        }

        private void mskbxSalarioBruto_Validated(object sender, EventArgs e)
        {
            if (mskbxSalarioBruto.Text == "")
                mskbxSalarioBruto.Text = null;

                else
                    if (!Double.TryParse(mskbxSalarioBruto.Text, out salarioBruto))
                    MessageBox.Show("Insira um Salário Válido");
            else
                if (salarioBruto == 0)
                MessageBox.Show("Digite um valor maior que 0");
        }

        private void btnVerificarDesconto_Click(object sender, EventArgs e)
        {
            double descontoInss, descontoIrpf, salarioFamilia, salarioLiquido;
            string estadoCivil = "", sexo = "";

            if (mskbxNomeFuncionario.Text == "")
            {
                MessageBox.Show("Digite o nome do funcionário");
                mskbxNomeFuncionario.Focus();
            }
            else
                if (mskbxSalarioBruto.Text == "")
            {
                MessageBox.Show("Digite um valor para o salário bruto");
                mskbxSalarioBruto.Focus();
            }
            else
            {
                //INSS

                if (salarioBruto <= 800.47)
                {
                    mskbxAliquotaInss.Text = "7,65%";
                    descontoInss = 0.0765 * salarioBruto;
                    mskbxDescontoInss.Text = "R$ " + Convert.ToString(descontoInss);
                }
                else
                    if (salarioBruto <= 1050)
                {
                    mskbxAliquotaInss.Text = "8,65%";
                    descontoInss = 0.0865 * salarioBruto;
                    mskbxDescontoInss.Text = "R$ " + Convert.ToString(descontoInss);
                }
                else
                    if (salarioBruto <= 1400.77)
                {
                    mskbxAliquotaInss.Text = "9,00%";
                    descontoInss = 0.09 * salarioBruto;
                    mskbxDescontoInss.Text = "R$ " + Convert.ToString(descontoInss);
                }
                else
                    if (salarioBruto <= 2801.56)
                {
                    mskbxAliquotaInss.Text = "11,00%";
                    descontoInss = 0.11 * salarioBruto;
                    mskbxDescontoInss.Text = "R$ " + Convert.ToString(descontoInss);
                }
                else
                {
                    mskbxAliquotaInss.Text = "Teto";
                    descontoInss = 308.17;
                    mskbxDescontoInss.Text = "R$ " + Convert.ToString(descontoInss);
                }
                //IRPF
                if (salarioBruto <= 1257.12)
                {
                    mskbxAliquotaIrpf.Text = "0,00%";
                    descontoIrpf = 0;
                    mskbxDescontoIrpf.Text = "Isento";
                }
                else
                    if (salarioBruto <= 2512.08)
                {
                    mskbxAliquotaIrpf.Text = "15,00%";
                    descontoIrpf = salarioBruto * 0.15;
                    mskbxDescontoIrpf.Text = "R$ " + Convert.ToString(descontoIrpf);
                }
                else
                {
                    mskbxAliquotaIrpf.Text = "27,50%";
                    descontoIrpf = salarioBruto * 0.275;
                    mskbxDescontoIrpf.Text = "R$ " + Convert.ToString(descontoIrpf);
                }

                //Salário Familia

                if (salarioBruto <= 435.52)
                {
                    salarioFamilia = 22.33 * numeroDeFilhos;
                    mskbxSalarioFamilia.Text = "R$ " + Convert.ToString(salarioFamilia);
                }
                else
                    if (salarioBruto <= 654.61)
                {
                    salarioFamilia = 15.74 * numeroDeFilhos;
                    mskbxSalarioFamilia.Text = "R$ " + Convert.ToString(salarioFamilia);
                }
                else
                {
                    salarioFamilia = 0 * numeroDeFilhos;
                    mskbxSalarioFamilia.Text = "R$ " + Convert.ToString(salarioFamilia);
                }

                salarioLiquido = salarioBruto - descontoInss - descontoIrpf + salarioFamilia;
                mskbxSalarioLiquido.Text = Convert.ToString(salarioLiquido);

                if (ckbxCasado.Checked)
                    estadoCivil = "Casado(a)";
                else
                    estadoCivil = "Solteiro(a)";

                if (rbtnFeminino.Checked)
                    sexo = "da Sra. ";
                else
                    sexo = "do Sr. ";

                lblDados.Text = "Os descontos do salário " + sexo + mskbxNomeFuncionario.Text + " que é " + estadoCivil + " e que tem " + Convert.ToString(numeroDeFilhos) + " filho(s) são:";
            }
        }     
            
    }
}
