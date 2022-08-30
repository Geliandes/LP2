using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pAtividade8
{
    public partial class frmExercicio1 : Form
    {
        public frmExercicio1()
        {
            InitializeComponent();
        }

        private void btnEspacos_Click(object sender, EventArgs e)
        {
            int x = 0;
            int y = 0;

            if (rchtxtFrase1.Text == "")
            {
                MessageBox.Show("Insira um texto");
                rchtxtFrase1.Focus();
            }
            else
            {
                while (x < rchtxtFrase1.Text.Length)
                {
                    if (Char.IsWhiteSpace(rchtxtFrase1.Text, x) == true)
                    {
                        y += 1;
                    }
                    x++;
                }
                if (y > 0)
                    MessageBox.Show("O texto >>> " + rchtxtFrase1.Text + " <<< possui " + y.ToString() + " espaços em branco");

                else
                    MessageBox.Show("Este texto não possui nenhum espaço em branco");
            }
        }

        private void btnContaR_Click(object sender, EventArgs e)
        {
            int letrasR = 0;

            if (rchtxtFrase1.Text == "")
            {
                MessageBox.Show("Insira um texto");
            }

            else
            {
                foreach (char c in rchtxtFrase1.Text)
                {
                    if (Char.ToUpper(c) == 'R')
                        letrasR++;
                }
                if (letrasR > 0)
                    MessageBox.Show("O número de letras R é: " + letrasR.ToString());
                else
                    MessageBox.Show("Esse texto não pussui nenhuma letra R");
            }
        }

        private void btnOcorrencias_Click(object sender, EventArgs e)
        {
            int letrasRep = 0;
            string auxiliar = rchtxtFrase1.Text.Replace(" ","");

            if (rchtxtFrase1.Text == "")
            {
                MessageBox.Show("Insira um texto");
                rchtxtFrase1.Focus();
            }
            else
            {
                for (int i = 1; i < auxiliar.Length; i++)
                {
                    if (auxiliar.ToUpper()[i] == auxiliar.ToUpper()[i - 1])
                        letrasRep++;
                }

                MessageBox.Show("Pares de letras repetidas: " + letrasRep.ToString());
            }
        }
    }
}
