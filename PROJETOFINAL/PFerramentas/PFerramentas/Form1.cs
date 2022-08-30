using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace PFerramentas
{
    public partial class Form1 : Form
    {
        public static SqlConnection conexao;

        public Form1()
        {
            InitializeComponent();

        }


        private void Form1_Load(object sender, EventArgs e)
        {


            try
            {//trocar aqui pela sua própria conexao de acordo com a sua
                conexao = new SqlConnection("Data Source=Apolo;Initial Catalog=LP2;Persist Security Info=True;User ID=BD2123033; Password = Arkilla7*");
                conexao.Open();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Erro de banco de dados = /" + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Outros Erros = /" + ex.Message);
            }

        }

        private void calculoFerramentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fc = Application.OpenForms["frmFerramenta"];

            if (fc != null)
                fc.Close();

            frmFerramenta frm1 = new frmFerramenta();
            frm1.MdiParent = this;
            frm1.WindowState = FormWindowState.Maximized;
            frm1.Show();
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fc = Application.OpenForms["frmAbout"];

            if (fc != null)
                fc.Close();

            frmAbout frm1 = new frmAbout();
            frm1.MdiParent = this;
            frm1.WindowState = FormWindowState.Maximized;
            frm1.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
    
}

