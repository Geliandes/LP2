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
    public partial class frmFerramenta : Form
    {
        private BindingSource bnFerramenta = new BindingSource();
        private bool bInclusao = false;
        private DataSet dsFerramenta = new DataSet();
        private DataSet dsCategoria = new DataSet();
        public frmFerramenta()
        {
            InitializeComponent();
        }

        private void frmFerramenta_Load(object sender, EventArgs e)
        {
            try

            {
                Ferramenta Ferr = new Ferramenta();

                dsFerramenta.Tables.Add(Ferr.Listar());

                bnFerramenta.DataSource = dsFerramenta.Tables["Ferramenta"];

                dgvFerramenta.DataSource = bnFerramenta;

                bnvFerramenta.BindingSource = bnFerramenta;

                txtIdFerramenta.DataBindings.Add("TEXT", bnFerramenta, "idFerramenta");

                txtNome.DataBindings.Add("TEXT", bnFerramenta, "nome");

                txtFornecedor.DataBindings.Add("TEXT", bnFerramenta, "fornecedor");

                txtSiteOficial.DataBindings.Add("TEXT", bnFerramenta, "siteoficial");

                cbxDistribuicao.DataBindings.Add("SelectedItem", bnFerramenta, "distribuicao");

                dtpDtCadastro.DataBindings.Add("TEXT", bnFerramenta, "dtcadastro");

                // carrega dados da Categoria

                Categoria Cat = new Categoria();

                dsCategoria.Tables.Add(Cat.Listar());

                cbxCategoria.DataSource = dsCategoria.Tables["Categoria"];

                //CAMPO QUE SERÁ MOSTRADO PARA O USUÁRIO

                cbxCategoria.DisplayMember = "descricao";

                //CAMPO QUE É A CHAVE DA TABELA Categoria E QUE LIGA COM A TABELA DE ALUNO

                cbxCategoria.ValueMember = "idCategoria";

                //No momento de linkar os componentes com o Binding Source linkar também o combox da Categoria

                cbxCategoria.DataBindings.Add("SelectedValue", bnFerramenta, "categoria_idCategoria"); // AJUSTAR DROPDOWNSTYLE PARA DropDownList PARA NAO DEIXAR

            }

            catch (Exception ex)

            {

                MessageBox.Show(ex.Message);

            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "")
            {
                MessageBox.Show("Nome inválido!");
            }
            else if (txtFornecedor.Text == "")
            {
                MessageBox.Show("Fornecedor inválido!");
            }
            else if (cbxDistribuicao.SelectedIndex == -1)
            {
                MessageBox.Show("Distribuição inválida!");
            }
            else if (txtSiteOficial.Text == "")
            {
                MessageBox.Show("Site oficial inválido!");
            }
            else if (cbxCategoria.SelectedIndex == -1)
            {
                MessageBox.Show("Categoria inválida!");
            }
            else
            {
                Ferramenta RegFerr = new Ferramenta();

                RegFerr.Nome = txtNome.Text;
                RegFerr.Fornecedor = txtFornecedor.Text;
                RegFerr.Distribuicao = Convert.ToChar(cbxDistribuicao.SelectedItem);
                RegFerr.Dtcadastro = dtpDtCadastro.Value;
                RegFerr.Siteoficial = txtSiteOficial.Text;
                RegFerr.Categoria_idcategoria = Convert.ToInt32(cbxCategoria.SelectedValue.ToString());

                if (bInclusao)
                {
                    if (RegFerr.Salvar() > 0)
                    {
                        MessageBox.Show("Ferramenta adicionada com sucesso!");

                        txtNome.Enabled = false;
                        txtFornecedor.Enabled = false;
                        txtSiteOficial.Enabled = false;
                        cbxDistribuicao.Enabled = false;
                        dtpDtCadastro.Enabled = false;
                        cbxCategoria.Enabled = false;
                        cbxDistribuicao.Enabled = false;

                        cbxCategoria.SelectedIndex = 0;
                        cbxDistribuicao.SelectedIndex = 0;

                        btnNovo.Enabled = true;
                        btnAlterar.Enabled = true;
                        btnExcluir.Enabled = true;
                        btnSalvar.Enabled = false;
                        btnCancelar.Enabled = false;
                        bInclusao = false;

                        // recarrega o grid
                        dsFerramenta.Tables.Clear();
                        dsFerramenta.Tables.Add(RegFerr.Listar());
                        bnFerramenta.DataSource = dsFerramenta.Tables["Ferramenta"];
                    }
                    else
                    {
                        MessageBox.Show("Erro ao gravar Ferramenta!");
                    }
                }
                else
                {
                    RegFerr.Idferramenta = Convert.ToInt32(txtIdFerramenta.Text);

                    if (RegFerr.Alterar() > 0)
                    {
                        MessageBox.Show("Ferramenta alterado com sucesso!");

                        txtNome.Enabled = false;
                        txtFornecedor.Enabled = false;
                        txtSiteOficial.Enabled = false;
                        cbxDistribuicao.Enabled = false;
                        dtpDtCadastro.Enabled = false;
                        cbxCategoria.Enabled = false;
                        cbxDistribuicao.Enabled = false;

                        cbxCategoria.SelectedIndex = 0;
                        cbxDistribuicao.SelectedIndex = 0;

                        btnNovo.Enabled = true;
                        btnAlterar.Enabled = true;
                        btnExcluir.Enabled = true;
                        btnSalvar.Enabled = false;
                        btnCancelar.Enabled = false;
                        bInclusao = false;

                        // recarrega o grid
                        dsFerramenta.Tables.Clear();
                        dsFerramenta.Tables.Add(RegFerr.Listar());
                        bnFerramenta.DataSource = dsFerramenta.Tables["Ferramenta"];
                    }
                    else
                    {
                        MessageBox.Show("Erro ao alterar ferramenta!");
                    }

                }
            }

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (tbFerramentas.SelectedIndex == 0)
            {
                tbFerramentas.SelectTab(1);
            }

            txtNome.Enabled = true;
            txtFornecedor.Enabled = true;
            txtSiteOficial.Enabled = true;
            cbxDistribuicao.Enabled = true;
            dtpDtCadastro.Enabled = true;
            cbxDistribuicao.Enabled = true;
            cbxCategoria.Enabled = true;

            cbxCategoria.SelectedIndex = 0;
            cbxDistribuicao.SelectedIndex = 0;

            btnNovo.Enabled = false;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnSalvar.Enabled = true;
            btnCancelar.Enabled = true;

            bInclusao = false;

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (tbFerramentas.SelectedIndex == 0)
            {
                tbFerramentas.SelectTab(1);
            }
            if (MessageBox.Show("Confirma exclusão?", "Yes or No", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                Ferramenta RegFerr = new Ferramenta();
                RegFerr.Idferramenta = Convert.ToInt32(txtIdFerramenta.Text);

                if (RegFerr.Excluir() > 0)
                {
                    MessageBox.Show("Ferramenta excluída com sucesso!");

                    // recarrega o grid
                    dsFerramenta.Tables.Clear();
                    dsFerramenta.Tables.Add(RegFerr.Listar());
                    bnFerramenta.DataSource = dsFerramenta.Tables["Ferramenta"];
                }
                else
                {
                    MessageBox.Show("Erro ao excluir Ferramenta!");
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            bnFerramenta.CancelEdit();

            txtNome.Enabled = false;
            txtFornecedor.Enabled = false;
            txtSiteOficial.Enabled = false;
            cbxDistribuicao.Enabled = false;
            dtpDtCadastro.Enabled = false;
            cbxCategoria.Enabled = false;
            cbxDistribuicao.Enabled = false;

            btnNovo.Enabled = true;
            btnAlterar.Enabled = true;
            btnExcluir.Enabled = true;
            btnSalvar.Enabled = false;
            btnCancelar.Enabled = false;

            bInclusao = false;

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            if (tbFerramentas.SelectedIndex == 0)
            {
                tbFerramentas.SelectTab(1);
            }

            bnFerramenta.AddNew();

            txtNome.Enabled = true;
            txtFornecedor.Enabled = true;
            txtSiteOficial.Enabled = true;
            cbxDistribuicao.Enabled = true;
            dtpDtCadastro.Enabled = true;
            cbxDistribuicao.Enabled = true;
            cbxCategoria.Enabled = true;

            cbxCategoria.SelectedIndex = 0;
            cbxDistribuicao.SelectedIndex = 0;

            btnNovo.Enabled = false;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnSalvar.Enabled = true;
            btnCancelar.Enabled = true;

            bInclusao = true;
        }
    }
}
