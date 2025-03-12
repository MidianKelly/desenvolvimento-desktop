using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

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

            if (chkAdulto.Checked && chkMasc.Checked)
            {
                #region Adulto Masculino
                if (chkAdulto.Checked == true)
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
                        picboxImc.Load(ImcImagens.MasculinoAbaixoDoNormal);

                    }
                    else if (imc < 24.9)
                    {
                        lblResultadoImc.Text = $@"{textoBase} é normal";
                        picboxImc.Load(ImcImagens.MasculinoNormal);
                    }
                    else if (imc < 29.9)
                    {
                        lblResultadoImc.Text = $@"{textoBase}, você está com sobrepeso";
                        picboxImc.Load(ImcImagens.MasculinoSobrepeso);
                    }
                    else if (imc < 34.9)
                    {
                        lblResultadoImc.Text = $@"{textoBase}, você está com Obesidade grau I";
                        picboxImc.Load(ImcImagens.MasculinoObesidade1);
                    }
                    else if (imc < 39.9)
                    {
                        lblResultadoImc.Text = $@"{textoBase}, você está com Obesidade grau II";
                        picboxImc.Load(ImcImagens.MasculinoObesidade2);
                    }
                    else
                    {
                        lblResultadoImc.Text = $@"{textoBase}, você está com Obesidade grau III";
                        picboxImc.Load(ImcImagens.MasculinoObesidade3);
                    }

                }
                #endregion

            } else if (chkAdulto.Checked && chkFem.Checked)
            {
                #region Feminino Adulto 

                // Primeiro passo: Obter os valores
                var peso = double.Parse(txtPeso.Text);
                var altura = double.Parse(txtAltura.Text);

                // Segundo passo: Calcular
                var imc = peso / (altura * altura);

                // Exibe o resultado
                lblResultadoImc.Text = imc.ToString("N2");

                var textoBase = $@"Seu IMC:{imc:N2}";

                if (imc <= 18.6)
                {
                    lblResultadoImc.Text = $@"{textoBase} é abaixo do normal";
                    picboxImc.Load(ImcImagens.FemininoAbaixoDoNormal);

                }
                else if (imc < 24.9)
                {
                    lblResultadoImc.Text = $@"{textoBase} é normal";
                    picboxImc.Load(ImcImagens.FemininoNormal);
                }
                else if (imc < 29.9)
                {
                    lblResultadoImc.Text = $@"{textoBase}, você está com sobrepeso";
                    picboxImc.Load(ImcImagens.FemininoSobrepeso);
                }
                else if (imc < 34.9)
                {
                    lblResultadoImc.Text = $@"{textoBase}, você está com Obesidade grau I";
                    picboxImc.Load(ImcImagens.FemininoObesidade1);
                }
                else if (imc < 39.9)
                {
                    lblResultadoImc.Text = $@"{textoBase}, você está com Obesidade grau II";
                    picboxImc.Load(ImcImagens.FemininoObesidade2);
                }
                else
                {
                    lblResultadoImc.Text = $@"{textoBase}, você está com Obesidade grau III";
                    picboxImc.Load(ImcImagens.FemininoObesidade3);
                }

                #endregion
            }
        }
    } 
}