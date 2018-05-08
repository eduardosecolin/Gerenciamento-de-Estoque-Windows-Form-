using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Modelo;
using DAO;
using BLL;

namespace GUI {
    public partial class FrmCategoria : GUI.FrmModeloCadastro {
        public FrmCategoria() {
            InitializeComponent();
        }

        private void limpaCampos(){
            txtCodigo.Clear();
            txtNome.Clear();
        }

        private void FrmCategoria_Load(object sender, EventArgs e) {
            // TODO: esta linha de código carrega dados na tabela 'bDESTOQUEDataSet.categoria'. Você pode movê-la ou removê-la conforme necessário.
            this.categoriaTableAdapter.Fill(this.bDESTOQUEDataSet.categoria);
            alteraBotoes(1);
        }

        private void btnIncluir_Click(object sender, EventArgs e) {
            operacao = "Incluir";
            alteraBotoes(2);
        }

        private void btnCancelar_Click(object sender, EventArgs e) {
            limpaCampos();
            alteraBotoes(1);
        }

        private void btnSalvar_Click(object sender, EventArgs e) {
            try {
                ModeloCategoria mCategoria = new ModeloCategoria();
                mCategoria.CatNome = txtNome.Text;
                DAOConexao daoConexao = new DAOConexao(DadosDaConexao.StringDeConexao);
                BLLCategoria bll = new BLLCategoria(daoConexao);
                if (operacao == "Incluir") {
                    // cadastrar uma categoria
                    bll.incluir(mCategoria);
                    MessageBox.Show("Cadastro efetuado - codigo: " + mCategoria.CatCod.ToString());
                }
                else {
                    // alterar uma categoria
                    mCategoria.CatCod = int.Parse(txtCodigo.Text);
                    bll.alterar(mCategoria);
                    MessageBox.Show("Cadastro alterado");
                }
                limpaCampos();
                alteraBotoes(1);

            }catch(Exception a){
                MessageBox.Show(a.Message);
            }
        }
    }
}
