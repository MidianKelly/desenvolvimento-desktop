using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultApp.Windows
{
    public partial class frmCarteirinha: Form
    {
        public frmCarteirinha()
        {
            InitializeComponent();
        }

        private void btnGerarCarteirinha_Click(object sender, EventArgs e)
        {
            #region Inserir nome na carteirinha

            var nome = txtNome.Text;
            lblNomeResultado.Text = $@"Nome:{nome}"; ;

            #endregion

            #region Definir idade
            var nascimento = DateTime.Parse(dateTimePicker1.Text);
            var hoje = DateTime.Now.Year;

            var idade = hoje - nascimento.Year;

            lblIdade.Text = $@"Idade:{idade} anos";
            

            if (idade < 12)
            {
              
               pictureBox1.Load (CarteirinhaImagens.Criança);
               lblInformacao.Text = $@"CRIANÇA";
               lblInformacao.Visible = true;
               panel1.BackColor = Color.Azure;


            }




            #endregion
        }

       
    }
}
