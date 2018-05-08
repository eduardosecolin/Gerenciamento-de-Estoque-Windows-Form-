using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO {
    public class DadosDaConexao {

      // CRIA A STRING DE CONEXAO
      public static String StringDeConexao{
        get {
                return "Data Source=EDUARDO-PC\\SQLEXPRESS;Initial Catalog=BDESTOQUE;Integrated Security=True";
        }
      }
    }
}
