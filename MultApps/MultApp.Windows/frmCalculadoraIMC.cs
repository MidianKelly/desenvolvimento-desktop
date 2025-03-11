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
    public partial class frmCalculadoraIMC : Form
    {
        public frmCalculadoraIMC()
        {
            InitializeComponent();
        }

        private void chkCrianca_CheckedChanged(object sender, EventArgs e)
        {
            chkCrianca.ForeColor = Color.DarkOrange;
            chkAdulto.ForeColor = Color.DimGray;
            chkAdulto.Checked = false;

            lblIdade.Text = "Abaixo dos 19";
            lblImcAdulto.Text = "Z IMC para Criança";

            lblMenorIdade.Visible = true;
            cmbIdade.Visible = true;

        }

        private void chkAdulto_CheckedChanged(object sender, EventArgs e)
        {
            chkCrianca.ForeColor = Color.DimGray;
            chkAdulto.ForeColor = Color.DarkOrange;
            chkCrianca.Checked = false;

            lblIdade.Text = "Acima dos 19";
            lblImcAdulto.Text = "IMC para Adulto\n";

            lblMenorIdade.Visible = false;
            cmbIdade.Visible = false;  

        }

        private void chkMasc_CheckedChanged(object sender, EventArgs e)
        {
            chkMasc.ForeColor = Color.DarkOrange;
            chkFem.ForeColor = Color.DimGray;
            chkFem.Checked = false;

        }

        private void chkFem_CheckedChanged(object sender, EventArgs e)
        {
            chkFem.ForeColor = Color.DarkOrange;
            chkMasc.ForeColor = Color.DimGray;
            chkMasc.Checked = false;
        }

        private void btnCalcule_Click(object sender, EventArgs e)
        {
            // Primeiro passo: Obter os valores
            var peso = double.Parse(txtPeso.Text);
            var altura = double.Parse(txtAltura.Text);

            // Segundo passo: Calcular
            var imc = peso / (altura * altura);

            // Exibe o resultado
            lblResultadoImc.Text = imc.ToString("N2");

            var textoBase = $@"Seu IMC:{imc:N2}";

            if (imc <= 18.5)
            {
                lblResultadoImc.Text = $@"{textoBase} é abaixo do normal";

            }
            else if (imc < 24.9)
            {
                lblResultadoImc.Text = $@"{textoBase} é normal";
            }
            else if (imc < 29.9)
            {
                lblResultadoImc.Text = $@"{textoBase}, você está com sobrepeso";
            }
            else if (imc < 34.9)
            {
                lblResultadoImc.Text = $@"{textoBase}, você está com Obesidade grau I";
            }
            else if (imc < 39.9)
            {
                lblResultadoImc.Text = $@"{textoBase}, você está com Obesidade grau II";
            }
            else
            {
                lblResultadoImc.Text = $@"{textoBase}, você está com Obesidade grau III";
            }

        }
    }
}