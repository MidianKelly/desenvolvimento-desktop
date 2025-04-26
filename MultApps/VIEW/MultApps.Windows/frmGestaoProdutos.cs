using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultApps.Windows
{
    public partial class frmGestaoProdutos : Form
    {
        public frmGestaoProdutos()
        {
            InitializeComponent();
        }

        private void radioBtnAtivo_CheckedChanged(object sender, EventArgs e)
        {
            radioBtnAtivo.ForeColor = Color.Blue;
            radioBtnInativo.ForeColor = Color.Gray;
            radioBtnAtivo.Checked = false;
        }

        private void radioBtnInativo_CheckedChanged(object sender, EventArgs e)
        {
            radioBtnInativo.ForeColor = Color.Blue;
            radioBtnAtivo.ForeColor = Color.Gray;
            radioBtnInativo.Checked = false;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtDescrição.Text = string.Empty;
            txtEstoque.Text = string.Empty;
            txtNomeProduto.Text = string.Empty;
            txtPreço.Text = string.Empty;
            cmbFiltro.SelectedIndex = -1;
            cmbCategoriaProduto.SelectedIndex = -1;
        }
    }
}
