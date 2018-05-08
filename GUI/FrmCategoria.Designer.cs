namespace GUI {
    partial class FrmCategoria {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.txtCodigo = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtNome = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.modeloCategoriaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bDESTOQUEDataSet = new GUI.BDESTOQUEDataSet();
            this.categoriaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoriaTableAdapter = new GUI.BDESTOQUEDataSetTableAdapters.categoriaTableAdapter();
            this.catcodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.catnomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modeloCategoriaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDESTOQUEDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnIncluir
            // 
            this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(43, 94);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(57, 19);
            this.materialLabel1.TabIndex = 8;
            this.materialLabel1.Text = "Código";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(43, 184);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(50, 19);
            this.materialLabel2.TabIndex = 9;
            this.materialLabel2.Text = "Nome";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Depth = 0;
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Hint = "";
            this.txtCodigo.Location = new System.Drawing.Point(47, 116);
            this.txtCodigo.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.PasswordChar = '\0';
            this.txtCodigo.SelectedText = "";
            this.txtCodigo.SelectionLength = 0;
            this.txtCodigo.SelectionStart = 0;
            this.txtCodigo.Size = new System.Drawing.Size(96, 23);
            this.txtCodigo.TabIndex = 10;
            this.txtCodigo.UseSystemPasswordChar = false;
            // 
            // txtNome
            // 
            this.txtNome.Depth = 0;
            this.txtNome.Hint = "";
            this.txtNome.Location = new System.Drawing.Point(47, 206);
            this.txtNome.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNome.Name = "txtNome";
            this.txtNome.PasswordChar = '\0';
            this.txtNome.SelectedText = "";
            this.txtNome.SelectionLength = 0;
            this.txtNome.SelectionStart = 0;
            this.txtNome.Size = new System.Drawing.Size(572, 23);
            this.txtNome.TabIndex = 11;
            this.txtNome.UseSystemPasswordChar = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.catcodDataGridViewTextBoxColumn,
            this.catnomeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.categoriaBindingSource;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.Location = new System.Drawing.Point(47, 246);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(911, 249);
            this.dataGridView1.TabIndex = 12;
            // 
            // modeloCategoriaBindingSource
            // 
            this.modeloCategoriaBindingSource.DataSource = typeof(Modelo.ModeloCategoria);
            // 
            // bDESTOQUEDataSet
            // 
            this.bDESTOQUEDataSet.DataSetName = "BDESTOQUEDataSet";
            this.bDESTOQUEDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // categoriaBindingSource
            // 
            this.categoriaBindingSource.DataMember = "categoria";
            this.categoriaBindingSource.DataSource = this.bDESTOQUEDataSet;
            // 
            // categoriaTableAdapter
            // 
            this.categoriaTableAdapter.ClearBeforeFill = true;
            // 
            // catcodDataGridViewTextBoxColumn
            // 
            this.catcodDataGridViewTextBoxColumn.DataPropertyName = "cat_cod";
            this.catcodDataGridViewTextBoxColumn.HeaderText = "Código";
            this.catcodDataGridViewTextBoxColumn.Name = "catcodDataGridViewTextBoxColumn";
            this.catcodDataGridViewTextBoxColumn.ReadOnly = true;
            this.catcodDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.catcodDataGridViewTextBoxColumn.Width = 150;
            // 
            // catnomeDataGridViewTextBoxColumn
            // 
            this.catnomeDataGridViewTextBoxColumn.DataPropertyName = "cat_nome";
            this.catnomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.catnomeDataGridViewTextBoxColumn.Name = "catnomeDataGridViewTextBoxColumn";
            this.catnomeDataGridViewTextBoxColumn.ReadOnly = true;
            this.catnomeDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.catnomeDataGridViewTextBoxColumn.Width = 720;
            // 
            // FrmCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1125, 625);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Name = "FrmCategoria";
            this.Load += new System.EventHandler(this.FrmCategoria_Load);
            this.Controls.SetChildIndex(this.btnIncluir, 0);
            this.Controls.SetChildIndex(this.btnLocalizar, 0);
            this.Controls.SetChildIndex(this.btnAlterar, 0);
            this.Controls.SetChildIndex(this.btnExcluir, 0);
            this.Controls.SetChildIndex(this.btnSalvar, 0);
            this.Controls.SetChildIndex(this.btnCancelar, 0);
            this.Controls.SetChildIndex(this.materialLabel1, 0);
            this.Controls.SetChildIndex(this.materialLabel2, 0);
            this.Controls.SetChildIndex(this.txtCodigo, 0);
            this.Controls.SetChildIndex(this.txtNome, 0);
            this.Controls.SetChildIndex(this.dataGridView1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modeloCategoriaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDESTOQUEDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtCodigo;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtNome;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource modeloCategoriaBindingSource;
        private BDESTOQUEDataSet bDESTOQUEDataSet;
        private System.Windows.Forms.BindingSource categoriaBindingSource;
        private BDESTOQUEDataSetTableAdapters.categoriaTableAdapter categoriaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn catcodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn catnomeDataGridViewTextBoxColumn;
    }
}
