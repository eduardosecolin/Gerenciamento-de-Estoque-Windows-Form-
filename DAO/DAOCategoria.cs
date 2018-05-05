using Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO {
    public class DAOCategoria {

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

        // EXCLUIR DO BANCO
        public void excluir(int codigo){
            SqlCommand cdm = new SqlCommand();
            cdm.Connection = daoConexao.Conexao;
            cdm.CommandText = "delete from categoria where cat_cod = @codigo";
            cdm.Parameters.AddWithValue("codigo", codigo);
            daoConexao.conectar();
            cdm.ExecuteNonQuery();
            daoConexao.desconectar();
        }


        // LOCALIZAR NO BANCO
        public DataTable localizar(string valor){
            DataTable tabela = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter("selec * from categoria where cat_nome like '%" + valor + "%'", daoConexao.StringConexao);
            sda.Fill(tabela);
            return tabela;
        }

        //     </>
        public ModeloCategoria carregaModeloCategoria(int codigo){
            ModeloCategoria categoria = new ModeloCategoria();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = daoConexao.Conexao;
            cmd.CommandText = "select * from categoria where cat_cod = @codigo";
            cmd.Parameters.AddWithValue("@codigo", codigo);
            daoConexao.conectar();
            SqlDataReader reader = cmd.ExecuteReader();
            if(reader.HasRows){
                reader.Read();
                categoria.CatCod = Convert.ToInt32(reader["cat_cod"]);
                categoria.CatNome = reader["cat_nome"].ToString();
            }
            daoConexao.desconectar();
            return categoria;
        }
    }
}
