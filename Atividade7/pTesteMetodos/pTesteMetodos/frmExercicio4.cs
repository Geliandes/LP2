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
    public partial class frmExercicio4 : Form
    {
        public frmExercicio4()
        {
            InitializeComponent();
        }
        private void btnContaNumeros_Click(object sender, EventArgs e)
        {
            int x = 0;
            if (rchtxtPalavra.Text == "")
                MessageBox.Show("O texto está vazio, insira um texto");
            else
            {
                for (int i = 0; i < rchtxtPalavra.Text.Length; i++)
                {
                    if (Char.IsNumber(rchtxtPalavra.Text, i))
                    {
                        x += 1;
                    }
                }

                if (x == 0)
                    MessageBox.Show("O texto >>> " + rchtxtPalavra.Text + " <<< não possui nenhum número");

                else
                    MessageBox.Show("O texto >>> " + rchtxtPalavra.Text + " <<< possui " + x.ToString() + " números");
            }
        }

        private void btnCaractereBranco_Click(object sender, EventArgs e)
        {
            int i = 0;
            int x = 0;

            if (rchtxtPalavra.Text == "")
                MessageBox.Show("O texto está vazio, insira um texto");
            else
            {

                while (i < rchtxtPalavra.Text.Length)
                {
                    if (Char.IsWhiteSpace(rchtxtPalavra.Text, i) == true)
                    {
                        x = i;
                        break;
                    }
                    i++;
                }

                if ((Char.IsWhiteSpace(rchtxtPalavra.Text, 0) == false) && x == 0)
                    MessageBox.Show("O texto não possui espaços em branco");
                else
                    MessageBox.Show("O texto >>> " + rchtxtPalavra.Text + " <<< possui o primeiro caractere em branco na posição: " + x.ToString());
            }
        }

        private void btnCaractereAlfabético_Click(object sender, EventArgs e)
        {
            int x = 0;
            int i = 0;

            if (rchtxtPalavra.Text == "")
                MessageBox.Show("O texto está vazio, insira um texto");

            else
            {
                foreach (char c in rchtxtPalavra.Text)
                {
                    if (Char.IsLetter(rchtxtPalavra.Text, i))
                    {
                        x += 1;
                    }
                    i++;
                }

                if (x == 0)
                    MessageBox.Show("O texto >>> " + rchtxtPalavra.Text + " <<< não possui nenhuma letra");

                else
                    MessageBox.Show("O texto >>> " + rchtxtPalavra.Text + " <<< possui " + x.ToString() + " letras");
            }
        }
    }
}



