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
using Microsoft.VisualBasic;

namespace pAtividade8
{
    public partial class frmExercicio6 : Form
    {
        public frmExercicio6()
        {
            InitializeComponent();
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            lbxNomes.Items.Clear();

            string aux, nome;
            int N = 8;          

            for (int i = 0; i < N; i++)
            {
                aux = Interaction.InputBox("Digite o " + (i + 1) + "º nome:", "Entrada de dados");
                nome = aux;
                aux = aux.Replace(" ", "");

                if (aux == "")
                    break;

                while (!Regex.IsMatch(aux, @"^[a-zA-Z+ ' ' + '' + záéíóúàèìòùâêîôûãõç]+$"))
                {
                    MessageBox.Show("Insira apenas letras em Nome");
                    aux = Interaction.InputBox("Digite o " + (i + 1) + "º nome:", "Entrada de dados");
                    nome = aux;
                    if (aux == "")
                        break;
                }
                    if (aux == "")
                        break;

                    else
                        lbxNomes.Items.Add("O nome: " + nome + ", contém " + aux.Length + " caracteres");
            }
        }
    }
}
