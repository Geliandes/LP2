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
    internal class Categoria
    {
        private int idcategoria;
        private string descricao;

        public int Idcategoria
        {
            get
            {
                return idcategoria;
            }
            set
            {
                idcategoria = value;
            }
        }

        public string Descricao
        {
            get
            {
                return descricao;
            }
            set
            {
                descricao = value;
            }
        }


        public DataTable Listar()
        {
            SqlDataAdapter daCategoria;
            DataTable dtCategoria = new DataTable();
            try
            {
                daCategoria = new SqlDataAdapter("SELECT * FROM CATEGORIA",
                    Form1.conexao);
                daCategoria.Fill(dtCategoria);
                daCategoria.FillSchema(dtCategoria, SchemaType.Source);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dtCategoria;
        }

    }
}

