using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace GUI {
    public partial class FrmModeloCadastro : MaterialForm {

        public String operacao;

        public FrmModeloCadastro() {
            InitializeComponent();
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(
              Primary.Green600, Primary.BlueGrey900,
              Primary.Blue500, Accent.Orange700,
              TextShade.WHITE);
        }

        public void alteraBotoes(int op){
            // op = operaçoes que serão feitas com os botões
            // 1  = preparar os botões para inserir e localizar
            // 2  = preparar os botões para inserir/alterar
            // 3  = preparar a tela para excluir/alterar

            btnIncluir.Enabled = false;
            btnLocalizar.Enabled = false;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnSalvar.Enabled = false;
            btnCancelar.Enabled = false;

            if(op == 1){
                btnIncluir.Enabled = true;
                btnLocalizar.Enabled = true;
            }
            if(op == 2){
                btnSalvar.Enabled = true;
                btnCancelar.Enabled = true;
            }
            if(op == 3){
                btnAlterar.Enabled = true;
                btnExcluir.Enabled = true;
                btnCancelar.Enabled = true;
            }
        }

        private void FrmModeloCadastro_Load(object sender, EventArgs e) {
            alteraBotoes(1);
        }
    }
}
