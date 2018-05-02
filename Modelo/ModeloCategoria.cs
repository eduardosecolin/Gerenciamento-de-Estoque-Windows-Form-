using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo {
    public class ModeloCategoria {

        // ATRIBUTOS
        private int cat_cod;
        private string cat_nome;

        // ENCAPSULAMENTO
        public int CatCod{
          get{ return cat_cod; }
          set{ cat_cod = value; }
        }
        public String CatNome{
          get{ return cat_nome; }
          set{ cat_nome = value; }
        }
    }
}
