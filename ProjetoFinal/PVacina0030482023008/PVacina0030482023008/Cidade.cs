using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace PVacina0030482023008
{
    class Cidade
    {
        //atributos
        private int idCidade;
        private string nomeCidade;
        private string ufCidade;

        //properties

        public int IdCidade // aqui não pode o mesmo nome do atributo
        {
            get
            {
                return idCidade;
            }
            set
            {
                idCidade = value;
            }
        }
        public string NomeCidade
        {
            get
            {
                return nomeCidade;
            }
            set
            {
                nomeCidade = value;
            }
        }
        public string UfCidade
        {
            get
            {
                return ufCidade;
            }
            set
            {
                ufCidade = value;
            }
        }
        //metodos

        public DataTable Listar()
        {
            SqlDataAdapter daCidade;
            DataTable dtCidade = new DataTable();
            try
            {
                daCidade = new SqlDataAdapter("SELECT * FROM Cidade", frmPrincipal.conexao); // * significa todos os campos
                daCidade.Fill(dtCidade);//preencha o datatable
                daCidade.FillSchema(dtCidade, SchemaType.Source);//preencha as info de chave primaria e tal
            }
            catch (Exception ex)
            {
                throw ex; //nao da p usar mbox me metodo, por isso o throw ex
            }
            return dtCidade;
        }
    }
}
