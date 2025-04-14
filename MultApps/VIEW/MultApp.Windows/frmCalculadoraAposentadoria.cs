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
    public partial class frmCalculadoraAposentadoria : Form
    {
        public frmCalculadoraAposentadoria()
        {
            InitializeComponent();
        }
        
        private void btnAposentadoria_Click(object sender, EventArgs e)
        {
            var  nascimento = DateTime.Parse(dateTimePicker1.Text);
            var hoje = DateTime.Now.Year;

            // Pegar as variáveis 
            var idade = hoje - nascimento.Year;
            var anoscontribuicao = int.Parse(txtContribuiçao.Text);

            // Fazer o calculo
            var aposentadoria =  idade - anoscontribuicao;
            #region Por tempo de contribuição
            if (cmbGenero.SelectedIndex == 0)
            {
               
                if (aposentadoria < 91)
                {

                    lblResultado.Text = "Você não pode se aposentar";
                }
                else
                {
                    lblResultado.Text = "Você pode se aposentar";
                }
            }
            else 
            {
                if (aposentadoria < 101)
                {

                    lblResultado.Text = "Você não pode se aposentar";
                }
                else
                {
                    lblResultado.Text = "Você pode se aposentar";
                } 
            }
            #endregion

            #region Aposentadoria idade

            if (cmbGenero.SelectedIndex == 0 && idade > 62)
            {
                lblResultado.Text = "Você pode se aposentar";
            }
            else if (cmbGenero.SelectedIndex == 1 && idade > 65)
            {
                lblResultado.Text = "Você pode se aposentar";
            }
            else
            {
                lblResultado.Text = "Você não pode se aposentar";
            }
            #endregion
        }
    }
}
