using DAO;
using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using System.Data;

namespace BLL {
    public class BLLCategoria {

        // ATRIBUTOS
        public DAOConexao daoConexao;

        // CONSTRUTOR
        public BLLCategoria(DAOConexao conexao) {
            daoConexao = conexao;
        }

        public void incluir(ModeloCategoria mCategoria){
          if(mCategoria.CatNome.Trim().Length == 0){
                throw new Exception("O nome da categoria é obrigatório!");
          }

            mCategoria.CatNome = mCategoria.CatNome.ToUpper();
            DAOCategoria objeto = new DAOCategoria(daoConexao);
            objeto.incluir(mCategoria);
        }

        public void alterar(ModeloCategoria mCategoria){
            if(mCategoria.CatCod <= 0){
                throw new Exception("O código da categoria é obrigatório!");
            }
            if (mCategoria.CatNome.Trim().Length == 0) {
                throw new Exception("O nome da categoria é obrigatório!");
            }

            mCategoria.CatNome = mCategoria.CatNome.ToUpper();
            DAOCategoria objeto = new DAOCategoria(daoConexao);
            objeto.alterar(mCategoria);
        }

        public void excluir(int codigo){
            DAOCategoria objeto = new DAOCategoria(daoConexao);
            objeto.excluir(codigo);
        }

        public DataTable localizar(string valor){
            DAOCategoria objeto = new DAOCategoria(daoConexao);
            return objeto.localizar(valor);
        }

        public ModeloCategoria carregaModeloCategoria(int codigo){
            DAOCategoria objeto = new DAOCategoria(daoConexao);
            return objeto.carregaModeloCategoria(codigo);
        }
    }
}
