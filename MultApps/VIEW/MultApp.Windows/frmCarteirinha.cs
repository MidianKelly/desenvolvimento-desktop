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
            lblNomeResultado.Text = $@"Nome:{nome}";

            #endregion

            #region Definir idade
            var nascimento = DateTime.Parse(dateTimePicker1.Text);
            var hoje = DateTime.Now.Year;

            var idade = hoje - nascimento.Year;

            lblIdade.Text = $@"Idade:{idade} anos";


            if (idade < 12)
            {

                pictureBox1.Load(CarteirinhaImagens.Criança);
                lblInformacao.Text = $@"CRIANÇA";
                lblInformacao.Visible = true;
                panel1.BackColor = Color.Azure;
                pictureBox1.BackColor = Color.Azure;

                var cpf = txtCpf.Text;
                string cpfOfuscado = OfuscarCPF(cpf);
                lblResultadoCpf.Text = $"CPF: {cpfOfuscado}";
            }
            else if (idade <= 18)
            {

                pictureBox1.Load(CarteirinhaImagens.Jovens);
                lblInformacao.Text = $@"JOVENS";
                lblInformacao.Visible = true;
                panel1.BackColor = Color.LemonChiffon;
                pictureBox1.BackColor = Color.LemonChiffon;

                var cpf = txtCpf.Text;
                string cpfOfuscado = OfuscarCPF(cpf);
                lblResultadoCpf.Text = $"CPF: {cpfOfuscado}";
            }
            else if ( idade <= 60)
            {
                pictureBox1.Load(CarteirinhaImagens.Adultos);
                lblInformacao.Text = $@"ADULTOS";
                lblInformacao.Visible = true;
                panel1.BackColor = Color.Plum;
                pictureBox1.BackColor = Color.Plum;

                var cpf = txtCpf.Text;
                string cpfOfuscado = OfuscarCPF(cpf);
                lblResultadoCpf.Text = $"CPF: {cpfOfuscado}";
            }
            else
            {
                pictureBox1.Load(CarteirinhaImagens.Idosos);
                lblInformacao.Text = $@"IDOSOS";
                lblInformacao.Visible = true;
                panel1.BackColor = Color.Honeydew;
                pictureBox1.BackColor = Color.Honeydew;


                var cpf = txtCpf.Text;
                string cpfOfuscado = OfuscarCPF(cpf);
                lblResultadoCpf.Text = $"CPF: {cpfOfuscado}";
            }
            #endregion
        }
        private string OfuscarCPF(string cpf)
        {
           
            // Garante que o CPF tem 11 caracteres
            if (cpf.Length != 11)
                return "CPF inválido";

            // Pega os números do meio
            string parte1 = cpf.Substring(3, 3);
            string parte2 = cpf.Substring(6, 3);

            // Retorna o CPF ofuscado
            return $"***.{parte1}.{parte2}.***";
        }
    }
}
