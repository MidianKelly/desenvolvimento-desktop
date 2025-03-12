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
                #region Adulto
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
                        picboxImc.Load(ManipuladorDeImagem("abaixo do normal"));

                    }
                    else if (imc < 24.9)
                    {
                        lblResultadoImc.Text = $@"{textoBase} é normal";
                        picboxImc.Load(ManipuladorDeImagem("normal"));
                    }
                    else if (imc < 29.9)
                    {
                        lblResultadoImc.Text = $@"{textoBase}, você está com sobrepeso";
                        picboxImc.Load(ManipuladorDeImagem("sobrepeso"));
                    }
                    else if (imc < 34.9)
                    {
                        lblResultadoImc.Text = $@"{textoBase}, você está com Obesidade grau I";
                        picboxImc.Load(ManipuladorDeImagem("Obesidade grau I"));
                    }
                    else if (imc < 39.9)
                    {
                        lblResultadoImc.Text = $@"{textoBase}, você está com Obesidade grau II";
                        picboxImc.Load(ManipuladorDeImagem("Obesidade grau II"));
                    }
                    else
                    {
                        lblResultadoImc.Text = $@"{textoBase}, você está com Obesidade grau III";
                        picboxImc.Load(ManipuladorDeImagem("Obesidade grau III"));
                    }

                }
                #endregion
            }
          
        }

        private string ManipuladorDeImagem(string grau)
        {
            switch (grau)
            {
                case "abaixo do normal":
                    return "https://abeso.org.br/wp-content/uploads/2019/12/imc_06.png.webp";

                case "normal":
                    return "https://abeso.org.br/wp-content/uploads/2019/12/imc_05.png.webp";
                case "sobrepeso":
                    return "https://abeso.org.br/wp-content/uploads/2019/12/imc_04.png.webp";
                case "Obesidade grau I":
                    return "https://abeso.org.br/wp-content/uploads/2019/12/imc_03.png.webp";
                case "Obesidade grau II":
                    return "https://abeso.org.br/wp-content/uploads/2019/12/imc_02.png.webp";
                case "Obesidade grau III":
                    return "https://abeso.org.br/wp-content/uploads/2019/12/imc_01.png.webp";
                   default ""
            }
        }
    }

   
}