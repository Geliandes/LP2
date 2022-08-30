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
    public partial class frmExercicio2 : Form
    {
        public frmExercicio2()
        {
            InitializeComponent();
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            double h = 0, n = 0, x;

            if (txtNumeroN.Text == "")
            {
                MessageBox.Show("Insira um número");
                txtNumeroN.Focus();
                txtNumeroH.Text = "";
                txtNumeroN.Text = "";
            }
            else if (!Double.TryParse(txtNumeroN.Text, out n))
            {
                MessageBox.Show("Insira apenas números");
                txtNumeroN.Focus();
                txtNumeroH.Text = "";
                txtNumeroN.Text = "";
            }
            else if (n == 0)
            {
                MessageBox.Show("Insira um número maior que 0");
                txtNumeroN.Focus();
                txtNumeroH.Text = "";
                txtNumeroN.Text = "";
            }

            else
            {
                n = Double.Parse(txtNumeroN.Text);

                for (x = 0; x < n; x++)
                {
                    h = (1 / (x + 1)) + h;
                }

                txtNumeroH.Text = h.ToString();

            }
        }
    }
}
