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
    public partial class FrmPrincipal : MaterialForm {
        public FrmPrincipal() {
            InitializeComponent();
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(
              Primary.Green600, Primary.BlueGrey900,
              Primary.Blue500, Accent.Orange700,
              TextShade.WHITE);
        }

        private void categoriaToolStripMenuItem_Click(object sender, EventArgs e) {
            FrmCadastroCategoria janelaCategoria = new FrmCadastroCategoria();
            janelaCategoria.ShowDialog();
            janelaCategoria.Dispose();
        }
    }
}
