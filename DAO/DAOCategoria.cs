using Modelo;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO {
    class DAOCategoria {

        // ATRIBUTOS
        public DAOConexao daoConexao;

        // CONSTRUTOR
        public DAOCategoria(DAOConexao conexao){
            daoConexao = conexao;
        }

        // INCLUIR NO BANCO
        public void incluir(ModeloCategoria mCategoria){
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = daoConexao.Conexao;
            cmd.CommandText = "insert into categoria(cat_nome) values(@nome); select @@IDENTITY;";
            cmd.Parameters.AddWithValue("@nome", mCategoria.CatNome);
            daoConexao.conectar();
            mCategoria.CatCod = Convert.ToInt32(cmd.ExecuteScalar());
            daoConexao.desconectar();
        }

        // ALTERA NO BANCO
        public void alterar(ModeloCategoria mCategoria) {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = daoConexao.Conexao;
            cmd.CommandText = "update categoria set cat_nome =  @nome where cat_cod = @codigo;";
            cmd.Parameters.AddWithValue("@nome", mCategoria.CatNome);
            cmd.Parameters.AddWithValue("@codigo", mCategoria.CatCod);
            daoConexao.conectar();
            cmd.ExecuteNonQuery();
            daoConexao.desconectar();
        }
    }
}
