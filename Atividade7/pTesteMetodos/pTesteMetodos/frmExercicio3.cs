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
    public partial class frmExercicio3 : Form
    {
        public frmExercicio3()
        {
            InitializeComponent();
        }

        private void btnOcorrencias_Click(object sender, EventArgs e)
        {
            int posicao = 0;

            txtPalavra1.Text = txtPalavra1.Text.ToUpper();
            txtPalavra2.Text = txtPalavra2.Text.ToUpper();

            posicao = txtPalavra2.Text.IndexOf(txtPalavra1.Text);

            while(posicao >= 0)
            {
                txtPalavra2.Text = txtPalavra2.Text.Substring(0, posicao)+
                txtPalavra2.Text.Substring(posicao + txtPalavra1.TextLength,
                txtPalavra2.Text.Length - posicao - txtPalavra1.TextLength);

                posicao = txtPalavra2.Text.IndexOf(txtPalavra1.Text);

            }
        }

        private void btnReplace_Click(object sender, EventArgs e)
        {
            txtPalavra1.Text = txtPalavra1.Text.ToUpper();
            txtPalavra2.Text = txtPalavra2.Text.ToUpper();

            txtPalavra2.Text = txtPalavra2.Text.Replace(txtPalavra1.Text, "");
        }

        private void btnInverte_Click(object sender, EventArgs e)
        {
            string s = txtPalavra1.Text;
            char[] arr = s.ToCharArray();
            Array.Reverse(arr);

            s = "";

            foreach (char cara in arr)
            {
                s = s + cara.ToString();
            }

            MessageBox.Show(s);
        }
    }
}
