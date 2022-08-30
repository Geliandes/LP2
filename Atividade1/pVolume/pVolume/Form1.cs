using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pVolume
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_Validated(object sender, EventArgs e)
        {
            double raio;

            if (!Double.TryParse(textBox1.Text, out raio))
                MessageBox.Show("Raio inválido");
            else
                if (raio <= 0)
                MessageBox.Show("Raio deve ser maior que zero");
        }

        private void textBox2_Validated(object sender, EventArgs e)
        {
            double altura;

            if (!Double.TryParse(textBox2.Text, out altura))
                MessageBox.Show("Altura inválido");
            else
                if (altura <= 0)
                MessageBox.Show("Altura deve ser maior que zero");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double raio;

            if (!Double.TryParse(textBox1.Text, out raio))
            {
                MessageBox.Show("Raio inválido");
                textBox1.Focus();
            }
            else
                if (raio <= 0)
            {
                MessageBox.Show("Raio deve ser maior que zero");
                textBox1.Focus();
            }
            else
            {
                double altura;

                if (!Double.TryParse(textBox2.Text, out altura))
                {
                    MessageBox.Show("Altura inválido");
                    textBox2.Focus();
                }
                else
                    if (altura <= 0)
                {
                    MessageBox.Show("Altura deve ser maior que zero");
                    textBox2.Focus();
                }
                else
                {
                    // calculo
                    //volume = pi * raio * raio * altura
                    double volume;
                    volume = Math.PI * Math.Pow(raio, 2) * altura;
                    textBox3.Text = volume.ToString("N2");
                }
            }
        }
    }
}
