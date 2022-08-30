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
    public partial class frmExercicio5 : Form
    {
        public frmExercicio5()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {

            string auxNota1, auxNota2, auxNota3;
            double media, aux, aluno=1;

            lbxNotas.Items.Clear();

            for(int i = 0; i < 20; i++)
            {
                //----------------------------------- Validação nota 1 ----------------------------------------
                auxNota1 = Interaction.InputBox("Digite a nota 1 do " + (i + 1) + "º aluno", "Entrada de Dados");

                if (auxNota1 == "")
                    break;

                while (!Double.TryParse(auxNota1, out aux) || (Convert.ToDouble(auxNota1) > 10))
                {
                    MessageBox.Show("Insira apenas caracteres numéricos entre 0 e 10");
                    auxNota1 = Interaction.InputBox("Digite a nota 1 do " + (i + 1) + "º aluno", "Entrada de Dados");
                    if (auxNota1 == "")
                        break;
                }

                if (auxNota1 == "")
                    break;


                //----------------------------------- Validação nota 2 ----------------------------------------
                auxNota2 = Interaction.InputBox("Digite a nota 2 do " + (i + 1) + "º aluno", "Entrada de Dados");

                if (auxNota2 == "")
                    break;

                while (!Double.TryParse(auxNota2, out aux) || (Convert.ToDouble(auxNota2) > 10))
                {
                    MessageBox.Show("Insira apenas caracteres numéricos entre 0 e 10");
                    auxNota2 = Interaction.InputBox("Digite a nota 2 do " + (i + 1) + "º aluno", "Entrada de Dados");
                    if (auxNota2 == "")
                        break;
                }

                if (auxNota2 == "")
                    break;

                //----------------------------------- Validação nota 3 ----------------------------------------
                auxNota3 = Interaction.InputBox("Digite a nota 3 do " + (i + 1) + "º aluno", "Entrada de Dados");

                if (auxNota3 == "")
                    break;

                while (!Double.TryParse(auxNota3, out aux) || (Convert.ToDouble(auxNota3) > 10))
                {
                    MessageBox.Show("Insira apenas caracteres numéricos entre 0 e 10");
                    auxNota3 = Interaction.InputBox("Digite a nota 3 do " + (i + 1) + "º aluno", "Entrada de Dados");
                    if (auxNota3 == "")
                        break;
                }

                if (auxNota3 == "")
                    break;
                         
                media = (Convert.ToDouble(auxNota1) + Convert.ToDouble(auxNota2) + Convert.ToDouble(auxNota3)) / 3;

                lbxNotas.Items.Add("Aluno " + aluno.ToString().PadLeft(2, '0') + ": média: " + media.ToString("N1"));

                aluno++;
            }
        }
    }
}
