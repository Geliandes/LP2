using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pCalculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = null;
            textBox2.Text = null;
            textBox3.Text = null;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Double num1, num2, Soma;

            if (textBox1.Text == "")          
                MessageBox.Show("Insira o 1º número");
            
            else if(textBox2.Text == "")
                MessageBox.Show("Insira o 2º número");

                else
                {
                    num1 = Convert.ToDouble(textBox1.Text);
                    num2 = Convert.ToDouble(textBox2.Text);

                    Soma = num1 + num2;

                    textBox3.Text = Soma.ToString();
                }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Double num1, num2, Subtracao;

            if (textBox1.Text == "")
            { 
                MessageBox.Show("Insira o 1º número");
                textBox3.Text = null;
            }

            else if (textBox2.Text == "")
            {
                MessageBox.Show("Insira o 2º número");
                textBox3.Text = null;
            }

            else
            {
                num1 = Convert.ToDouble(textBox1.Text);
                num2 = Convert.ToDouble(textBox2.Text);

                Subtracao = num1 - num2;

                textBox3.Text = Subtracao.ToString();
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Double num1, num2, Multiplicacao;

            if (textBox1.Text == "")
                MessageBox.Show("Insira o 1º número");

            else if (textBox2.Text == "")
                MessageBox.Show("Insira o 2º número");

            else
            {
                num1 = Convert.ToDouble(textBox1.Text);
                num2 = Convert.ToDouble(textBox2.Text);

                Multiplicacao = num1 * num2;

                textBox3.Text = Multiplicacao.ToString();
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            Double num1, num2, Divisao;

            if (textBox1.Text == "")
                MessageBox.Show("Insira o 1º número");

            else if (textBox2.Text == "")
                MessageBox.Show("Insira o 2º número");

            else
            {
                num1 = Convert.ToDouble(textBox1.Text);
                num2 = Convert.ToDouble(textBox2.Text);

                if (num2 == 0)
                {
                    MessageBox.Show("Não é possível dividir por 0");
                    textBox2.Focus();
                    textBox2.Text = null;
                    textBox3.Text = null;
                }

                else
                {
                    Divisao = num1 / num2;

                    textBox3.Text = Divisao.ToString();
                }
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            label1.BackColor = Color.Transparent;
            label2.BackColor = Color.Transparent;
            label3.BackColor = Color.Transparent;
        }
        private void textBox1_Validated(object sender, EventArgs e)
        {
            double numero1;

            if (textBox1.Text.Length == 0)
                textBox1.Text = "";

            else if (!Double.TryParse(textBox1.Text, out numero1))
            {
                MessageBox.Show("Insira apenas números");

                textBox1.Text = null;
                textBox3.Text = null;

                textBox1.Focus();
            }  
        }
        private void textBox2_Validated(object sender, EventArgs e)
        {
            double numero2;

            if (textBox2.Text.Length == 0)
                textBox2.Text = "";

            else if (!Double.TryParse(textBox2.Text, out numero2))
            {
                MessageBox.Show("Insira apenas números");

                textBox2.Text = null;
                textBox3.Text = null;

                textBox2.Focus();
            }
        }
    }
}
