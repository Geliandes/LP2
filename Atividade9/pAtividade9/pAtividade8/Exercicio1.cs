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
    public partial class frmExercicio1 : Form
    {
        public frmExercicio1()
        {
            InitializeComponent();
        }


    private void frmExercicio1_Load(object sender, EventArgs e)
        {
            string auxiliar=" ";
            int[] numeros = new int[20];    

            for (int i = 0; i < numeros.Length; i++)
            {
                
                auxiliar = Interaction.InputBox("Digite um numero para a posição: " + (i+1), "Entrada de Dados");
                if (auxiliar == "")
                    break;

                else if (!int.TryParse(auxiliar, out numeros[i]))
                    {
                        MessageBox.Show("Não é um número");
                        i--;
                    }
            }
          
            Array.Reverse(numeros);

            if (auxiliar != "")
            {
                MessageBox.Show(String.Join(", ", numeros));
            }
        }
    }
}
