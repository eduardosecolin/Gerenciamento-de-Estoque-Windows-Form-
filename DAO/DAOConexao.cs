using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO {
    public class DAOConexao {

        // ATRIBUTROS
        private string _stringConexao;
        private SqlConnection _conexao;

        // CONSTRUTOR QUE RECEBE UMA STRING DE CONEXAO
        public DAOConexao(string dadosConexao){
            _conexao = new SqlConnection();
            StringConexao = dadosConexao;
            _conexao.ConnectionString = dadosConexao;
        }

        // ENCAPSULAMENTO
        public String StringConexao{
          get { return _stringConexao; }
          set { _stringConexao = value; }
        }
        public SqlConnection Conexao{
          get { return _conexao; }
          set { _conexao = value; }
        }

        // CONECTAR AO BANCO
        public void conectar(){
            _conexao.Open();
        }

        // DESCONECTAR DO BANCO
        public void desconectar(){
            _conexao.Close();
        }
    }
}
