using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace PFerramentas
{
    internal class Ferramenta
    {
        public int Idferramenta { get; set; }
        public string Nome { get; set; }
        public string Fornecedor { get; set; }
        public char Distribuicao { get; set; }
        public DateTime Dtcadastro { get; set; }
        public string Siteoficial { get; set; }
        public int Categoria_idcategoria { get; set; }

        public DataTable Listar()
        {
            SqlDataAdapter daFerramenta;
            DataTable dtFerramenta = new DataTable();
            try
            {
                daFerramenta = new SqlDataAdapter("SELECT * FROM FERRAMENTA",
                    Form1.conexao);
                daFerramenta.Fill(dtFerramenta);
                daFerramenta.FillSchema(dtFerramenta, SchemaType.Source);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dtFerramenta;
        }

        public int Salvar()
        {
            int retorno = 0;

            try
            {
                SqlCommand mycommand;
                mycommand = new SqlCommand("INSERT INTO FERRAMENTA VALUES " +
                    " (@nome,@fornecedor,@distribuicao,@dtcadastro,@siteoficial," +
                    "@categoria_idcategoria)", Form1.conexao);

                mycommand.Parameters.Add(new SqlParameter("@nome", SqlDbType.VarChar));
                mycommand.Parameters.Add(new SqlParameter("@fornecedor", SqlDbType.VarChar));
                mycommand.Parameters.Add(new SqlParameter("@distribuicao", SqlDbType.Char));
                mycommand.Parameters.Add(new SqlParameter("@dtcadastro", SqlDbType.DateTime));
                mycommand.Parameters.Add(new SqlParameter("@siteoficial", SqlDbType.VarChar));
                mycommand.Parameters.Add(new SqlParameter("@categoria_idcategoria", SqlDbType.Int));

                mycommand.Parameters["@nome"].Value = Nome;
                mycommand.Parameters["@fornecedor"].Value = Fornecedor;
                mycommand.Parameters["@distribuicao"].Value = Distribuicao;
                mycommand.Parameters["@dtcadastro"].Value = Dtcadastro;
                mycommand.Parameters["@siteoficial"].Value = Siteoficial;
                mycommand.Parameters["@categoria_idcategoria"].Value = Categoria_idcategoria;

                retorno = mycommand.ExecuteNonQuery();


            }
            catch (Exception ex)
            {
                throw ex;
            }

            return retorno;
        }


        public int Alterar()
        {
            int retorno = 0;


            try
            {
                SqlCommand mycommand;

                mycommand = new SqlCommand("UPDATE FERRAMENTA SET nome = @nome,fornecedor=@fornecedor,distribuicao=@distribuicao," +
                    "dtcadastro=@dtcadastro, siteoficial=@siteoficial, categoria_idcategoria=@categoria_idcategoria " +
                    " WHERE idferramenta = @idferramenta", Form1.conexao);

                mycommand.Parameters.Add(new SqlParameter("@idferramenta", SqlDbType.Int));
                mycommand.Parameters.Add(new SqlParameter("@nome", SqlDbType.VarChar));
                mycommand.Parameters.Add(new SqlParameter("@fornecedor", SqlDbType.VarChar));
                mycommand.Parameters.Add(new SqlParameter("@distribuicao", SqlDbType.Char));
                mycommand.Parameters.Add(new SqlParameter("@dtcadastro", SqlDbType.DateTime));
                mycommand.Parameters.Add(new SqlParameter("@siteoficial", SqlDbType.VarChar));
                mycommand.Parameters.Add(new SqlParameter("@categoria_idcategoria", SqlDbType.Int));

                mycommand.Parameters["@idferramenta"].Value = Idferramenta;
                mycommand.Parameters["@nome"].Value = Nome;
                mycommand.Parameters["@fornecedor"].Value = Fornecedor;
                mycommand.Parameters["@distribuicao"].Value = Distribuicao;
                mycommand.Parameters["@dtcadastro"].Value = Dtcadastro;
                mycommand.Parameters["@siteoficial"].Value = Siteoficial;
                mycommand.Parameters["@categoria_idcategoria"].Value = Categoria_idcategoria;

                retorno = mycommand.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return retorno;
        }


        public int Excluir()
        {
            int retorno = 0;

            try
            {
                SqlCommand mycommand;

                mycommand = new SqlCommand("DELETE FROM FERRAMENTA WHERE idferramenta=@idferramenta", Form1.conexao);
                mycommand.Parameters.Add(new SqlParameter("@idferramenta", SqlDbType.Int));
                mycommand.Parameters["@idferramenta"].Value = Idferramenta;

                retorno = mycommand.ExecuteNonQuery();
            }

            catch (Exception ex)
            {
                throw ex;
            }

            return retorno;
        }

    }
}
