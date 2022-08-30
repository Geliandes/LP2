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

namespace PCampeonato
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        { 
            int[,] N = new int[8,3];
            int golsFeitos = 0, golsRecebidos = 0, saldoGols = 0, aux3 = 0, aux6=0;

            string aux1 = "", aux2 = "", aux4 = "", aux5="";

            lbxGols.Items.Clear();

            for (int j = 0; j < 8; j++) {

                for (int i = 0; i < 3; i++) {

                    for (int x = 0; x < 1; x++) {

                        aux1 = Interaction.InputBox("Digite o número de gols feitos do time " + (j + 1));

                        if(aux1 == "") {
                            break;
                        }

                        else if (int.TryParse(aux1, out golsFeitos))
                        {
                            if (golsFeitos < 0)
                            {
                                MessageBox.Show("Digite um número maior que 0");
                                x--;
                            }

                            else
                            {
                                N[j, i] = golsFeitos;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Digite apenas números inteiros");
                        }
                    }

                    if (aux1 == "")
                    {
                        break;
                    }

                    i++;

                    for (int x = 0; x < 1; x++)
                    {
                        aux2 = Interaction.InputBox("Digite o número de gols recebidos pelo time " + (j + 1));

                        if (aux2 == "")
                        {
                            break;
                        }

                        else if (int.TryParse(aux2, out golsRecebidos))
                        {
                            if (golsRecebidos < 0)
                            {
                                MessageBox.Show("Digite um número maior que 0");
                                x--;
                            }

                            else
                            {
                                N[j, i] = golsRecebidos;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Digite apenas números inteiros");
                        }
                    }

                    if (aux2 == "")
                    {
                        break;
                    }

                    i++;

                    saldoGols = golsFeitos - golsRecebidos;

                    N[j,i] = saldoGols;

                    if (saldoGols < aux6)
                    {
                        aux6 = saldoGols;
                        aux5 = "Pior(es) Time(s): Time: " + (j + 1) + " Pior(es) Saldo(s) de Gols: " + saldoGols;
                    }

                    if (saldoGols > aux3)
                    {
                        aux3 = saldoGols;
                        aux4 = "Melhor(es) Time(s): Time: " + (j+1) + " Melhore(es) Saldo(s) de Gols: " + saldoGols;
                    }

                    lbxGols.Items.Add("Time: " + (j + 1) + " Gols Feitos: " + golsFeitos + " Gols recebidos: " + golsRecebidos + " Saldo de Gols: " + saldoGols);
                }

                if (aux1 == "")
                {
                    break;
                }

                if (aux2 == "")
                {
                    break;
                }
            }

            lbxGols.Items.Add("--------------------------------------------------------");
            lbxGols.Items.Add(aux5);
            lbxGols.Items.Add(aux4);
        }
    }
}
