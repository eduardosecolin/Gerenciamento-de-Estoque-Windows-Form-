namespace GUI {
    partial class FrmModeloCadastro {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.btnIncluir = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnLocalizar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnAlterar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnExcluir = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnSalvar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnCancelar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.panelDados = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btnIncluir
            // 
            this.btnIncluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIncluir.Depth = 0;
            this.btnIncluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIncluir.Location = new System.Drawing.Point(23, 565);
            this.btnIncluir.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Primary = true;
            this.btnIncluir.Size = new System.Drawing.Size(180, 40);
            this.btnIncluir.TabIndex = 2;
            this.btnIncluir.Text = "Incluir";
            this.btnIncluir.UseVisualStyleBackColor = true;
            // 
            // btnLocalizar
            // 
            this.btnLocalizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLocalizar.Depth = 0;
            this.btnLocalizar.Location = new System.Drawing.Point(202, 565);
            this.btnLocalizar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLocalizar.Name = "btnLocalizar";
            this.btnLocalizar.Primary = true;
            this.btnLocalizar.Size = new System.Drawing.Size(180, 40);
            this.btnLocalizar.TabIndex = 3;
            this.btnLocalizar.Text = "Localizar";
            this.btnLocalizar.UseVisualStyleBackColor = true;
            // 
            // btnAlterar
            // 
            this.btnAlterar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAlterar.Depth = 0;
            this.btnAlterar.Location = new System.Drawing.Point(381, 565);
            this.btnAlterar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Primary = true;
            this.btnAlterar.Size = new System.Drawing.Size(180, 40);
            this.btnAlterar.TabIndex = 4;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcluir.Depth = 0;
            this.btnExcluir.Location = new System.Drawing.Point(560, 565);
            this.btnExcluir.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Primary = true;
            this.btnExcluir.Size = new System.Drawing.Size(180, 40);
            this.btnExcluir.TabIndex = 5;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalvar.Depth = 0;
            this.btnSalvar.Location = new System.Drawing.Point(739, 565);
            this.btnSalvar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Primary = true;
            this.btnSalvar.Size = new System.Drawing.Size(180, 40);
            this.btnSalvar.TabIndex = 6;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.Depth = 0;
            this.btnCancelar.Location = new System.Drawing.Point(918, 565);
            this.btnCancelar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Primary = true;
            this.btnCancelar.Size = new System.Drawing.Size(180, 40);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // panelDados
            // 
            this.panelDados.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panelDados.Location = new System.Drawing.Point(23, 75);
            this.panelDados.Name = "panelDados";
            this.panelDados.Size = new System.Drawing.Size(1075, 469);
            this.panelDados.TabIndex = 8;
            // 
            // FrmModeloCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1125, 625);
            this.Controls.Add(this.panelDados);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnLocalizar);
            this.Controls.Add(this.btnIncluir);
            this.Name = "FrmModeloCadastro";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modelo de Formulario de Cadastro ";
            this.Load += new System.EventHandler(this.FrmModeloCadastro_Load);
            this.ResumeLayout(false);

        }

        #endregion
        protected MaterialSkin.Controls.MaterialRaisedButton btnIncluir;
        protected MaterialSkin.Controls.MaterialRaisedButton btnLocalizar;
        protected MaterialSkin.Controls.MaterialRaisedButton btnAlterar;
        protected MaterialSkin.Controls.MaterialRaisedButton btnExcluir;
        protected MaterialSkin.Controls.MaterialRaisedButton btnSalvar;
        protected MaterialSkin.Controls.MaterialRaisedButton btnCancelar;
        private System.Windows.Forms.Panel panelDados;
    }
}