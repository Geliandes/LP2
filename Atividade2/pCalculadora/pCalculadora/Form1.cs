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

        //botão fechar
        private void button5_Click(object sender, EventArgs e)
        {
            //comando para fechar o programa
            Close();
        }

        //botão limpar
        private void button6_Click(object sender, EventArgs e)
        {
            //limpando as textBox
            textBox1.Text = null;
            textBox2.Text = null;
            textBox3.Text = null;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Double num1, num2, Soma;

            //avisar se o número 1 estiver vazio e apagar o resultado caso tenha algum resultado anterior na textbox3
            if (textBox1.Text == "")
            {
                MessageBox.Show("Insira o 1º número");
                textBox1.Focus();
                textBox3.Text = "";
            }

            //avisar se o número 2 estiver vazio e apagar o resultado caso tenha algum resultado anterior na textbox3
            else if (textBox2.Text == "")
            {
                MessageBox.Show("Insira o 2º número");
                textBox2.Focus();
                textBox3.Text = "";
            }

            else
            {
                //convertendo de string para número e atribuir para variáveis double para poder fazer o calculo
                num1 = Convert.ToDouble(textBox1.Text);
                num2 = Convert.ToDouble(textBox2.Text);

                //calculo de adição
                Soma = num1 + num2;

                //convertendo o resultado da divisão para String para que possa ser exibido na textbox.text
                textBox3.Text = Soma.ToString();
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Double num1, num2, Subtracao;

            //avisar se o número 1 estiver vazio e apagar o resultado caso tenha algum resultado anterior na textbox3
            if (textBox1.Text == "")
            {
                MessageBox.Show("Insira o 1º número");
                textBox1.Focus();
                textBox3.Text = "";
            }

            //avisar se o número 2 estiver vazio e apagar o resultado caso tenha algum resultado anterior na textbox3
            else if (textBox2.Text == "")
            {
                MessageBox.Show("Insira o 2º número");
                textBox2.Focus();
                textBox3.Text = "";
            }

            else
            {
                //convertendo de string para número e atribuir para variáveis double para poder fazer o calculo
                num1 = Convert.ToDouble(textBox1.Text);
                num2 = Convert.ToDouble(textBox2.Text);

                //calculo de subtração
                Subtracao = num1 - num2;

                //convertendo o resultado da divisão para String para que possa ser exibido na textbox.text
                textBox3.Text = Subtracao.ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Double num1, num2, Multiplicacao;

            //avisar se o número 1 estiver vazio e apagar o resultado caso tenha algum resultado anterior na textbox3
            if (textBox1.Text == "")
            {
                MessageBox.Show("Insira o 1º número");
                textBox1.Focus();
                textBox3.Text = "";
            }

            //avisar se o número 2 estiver vazio e apagar o resultado caso tenha algum resultado anterior na textbox3
            else if (textBox2.Text == "")
            {
                MessageBox.Show("Insira o 2º número");
                textBox2.Focus();
                textBox3.Text = "";
            }

            else
            {
                //convertendo de string para número e atribuir para variáveis double para poder fazer o calculo
                num1 = Convert.ToDouble(textBox1.Text);
                num2 = Convert.ToDouble(textBox2.Text);

                //calculo de multiplicação
                Multiplicacao = num1 * num2;

                //convertendo o resultado da divisão para String para que possa ser exibido na textbox.text
                textBox3.Text = Multiplicacao.ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Double num1, num2, Divisao;

            //avisar se o número 1 estiver vazio e apagar o resultado caso tenha algum resultado anterior na textbox3
            if (textBox1.Text == "")
            {
                MessageBox.Show("Insira o 1º número");
                textBox1.Focus();
                textBox3.Text = "";
            }

            //avisar se o número 2 estiver vazio e apagar o resultado caso tenha algum resultado anterior na textbox3
            else if (textBox2.Text == "")
            {
                MessageBox.Show("Insira o 2º número");
                textBox2.Focus();
                textBox3.Text = "";
            }

            //convertendo de string para número e atribuindo para variáveis double para poder fazer o calculo
            else
            {
                num1 = Convert.ToDouble(textBox1.Text);
                num2 = Convert.ToDouble(textBox2.Text);

                //proíbido divisão por 0
                if (num2 == 0)
                {
                    MessageBox.Show("Não é possível dividir por 0");
                    textBox2.Focus();
                    textBox2.Text = null;
                    textBox3.Text = null;
                }

                //caso tudo esteja ok o calculo será feito
                else
                {
                    //divisão
                    Divisao = num1 / num2;
                    //convertendo o resultado da divisão para String para que possa ser exibido na textbox.text
                    textBox3.Text = Divisao.ToString();
                }
            }
        }

        //Validação para proibir letras na textbox do numero 2
        private void textBox1_Validated(object sender, EventArgs e)
        {
            //recurso utilizado para que quando acionado o botão limpar ou sair quando nenhum valor tiver sido digitado anteriormente, não aparecer os próximos avisos.
            if (textBox1.Text.Length == 0)
                textBox1.Text = "";

            //verificando se o caracter inserido é um número
            else if (!Double.TryParse(textBox1.Text, out _))
            {
                MessageBox.Show("Insira apenas números");

                //apagando a textbox caso o caracter inserido não seja um número e apagando também a textbox de resultados
                textBox1.Text = null;
                textBox3.Text = null;

                textBox1.Focus();
            }  
        }

        //Validação para proibir letras na textbox do numero 2
        private void textBox2_Validated(object sender, EventArgs e)
        {
            //recurso utilizado para que quando acionado o botão limpar ou sair quando nenhum valor tiver sido digitado anteriormente, não aparecer os próximos avisos.
            if (textBox2.Text.Length == 0)
                textBox2.Text = "";

            //verificando se o caracter inserido é um número
            else if (!Double.TryParse(textBox2.Text, out _))
            {
                MessageBox.Show("Insira apenas números");

                //apagando a textbox caso o caracter inserido não seja um número e apagando também a textbox de resultados
                textBox2.Text = null;
                textBox3.Text = null;

                textBox2.Focus();
            }
        }

        //Deixaando os labels com background transparente
        private void Form1_Load(object sender, EventArgs e)
        {
            label1.BackColor = Color.Transparent;
            label2.BackColor = Color.Transparent;
            label3.BackColor = Color.Transparent;
        }
    }
}
