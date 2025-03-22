using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultApp.Windows
{
    public partial class frmLojaAcai : Form
    {
        public frmLojaAcai()
        {
            InitializeComponent();
        }
        #region Tamanhos dos açaís
        private void btnAcaiPequeno_Click(object sender, EventArgs e)
        {
            listBoxTamanhoAcai.Items.Add("Açaí 300ml");
            listBoxTotal.Items.Add("R$15,00");
            btnAcaiPequeno.ForeColor = Color.MediumPurple;

            btnAcaiMedio.ForeColor = SystemColors.ControlText; 
            btnAcaiGrande.ForeColor = SystemColors.ControlText;
            btnAcaiFamilia.ForeColor = SystemColors.ControlText;

        }

        private void btnAcaiMedio_Click(object sender, EventArgs e)
        {
            listBoxTamanhoAcai.Items.Add("Açaí 500ml");
            listBoxTotal.Items.Add("R$20,00");
            btnAcaiMedio.ForeColor = Color.MediumPurple;

            btnAcaiPequeno.ForeColor = SystemColors.ControlText;
            btnAcaiGrande.ForeColor = SystemColors.ControlText;
            btnAcaiFamilia.ForeColor = SystemColors.ControlText;
        }

        private void btnAcaiGrande_Click(object sender, EventArgs e)
        {
            listBoxTamanhoAcai.Items.Add("Açaí 700ml");
            listBoxTotal.Items.Add("R$25,00");
            btnAcaiGrande.ForeColor = Color.MediumPurple;

            btnAcaiPequeno.ForeColor = SystemColors.ControlText;
            btnAcaiMedio.ForeColor = SystemColors.ControlText;
            btnAcaiFamilia.ForeColor = SystemColors.ControlText;
        }

        private void btnAcaiFamilia_Click(object sender, EventArgs e)
        {
            listBoxTamanhoAcai.Items.Add("Açaí 1,5l");
            listBoxTotal.Items.Add("R$35,00");
            btnAcaiFamilia.ForeColor = Color.MediumPurple;

            btnAcaiPequeno.ForeColor = SystemColors.ControlText;
            btnAcaiMedio.ForeColor = SystemColors.ControlText;
            btnAcaiGrande.ForeColor = SystemColors.ControlText;
        }

        #endregion

        #region Complementos
        private void NumericGranola_ValueChanged(object sender, EventArgs e)
        {
            if (LimitarComplementos()) return;

            if (NumericGranola.Value > 0)
            {
                listBoxComplementos.Items.Add($"Granola - {NumericGranola.Value}");
                listBoxTotal.Items.Add("Granola - R$1,50");
            }
            else
            {
                listBoxComplementos.Items.Remove($"Granola - {NumericGranola.Value + 1}");
                listBoxTotal.Items.Remove("Granola - R$1,50");
            }           
        }

        private void numericLeiteEmPo_ValueChanged(object sender, EventArgs e)
        {
            if (LimitarComplementos()) return;
            if (numericLeiteEmPo.Value > 0)
            {
                listBoxComplementos.Items.Add($"Leite em Pó - {numericLeiteEmPo.Value}");
                listBoxTotal.Items.Add("Leite em pó - R$2,50");
            }
            else
            {
                listBoxComplementos.Items.Remove($"Leite em Pó - {numericLeiteEmPo.Value + 1}");
                listBoxTotal.Items.Remove("Leite em pó - R$2,50");
            }
        }

        private void numericChocobol_ValueChanged(object sender, EventArgs e)
        {
            if (LimitarComplementos()) return;
            if (numericChocobol.Value > 0 )
            {
                listBoxComplementos.Items.Add($"Chocobol - {numericChocobol.Value}");
                listBoxTotal.Items.Add("Chocobol - R$ 1,00");
            }
            else
            {
                listBoxComplementos.Items.Remove($"Chocobol - {numericChocobol.Value + 1}");
                listBoxTotal.Items.Remove("Chocobol - R$ 1,00");
            }
        }

        private void numericGotasChocolate_ValueChanged(object sender, EventArgs e)
        {
            if (LimitarComplementos()) return;
            if (numericGotasChocolate.Value > 0)
            {
                listBoxComplementos.Items.Add($"Gotas de Chocolate - {numericGotasChocolate.Value}");
                listBoxTotal.Items.Add("Chocobol - R$ 1,60");
            }
            else
            {
                listBoxComplementos.Items.Remove($"Gotas de Chocolate - {numericGotasChocolate.Value + 1}");
                listBoxTotal.Items.Remove("Chocobol - R$ 1,60");

            }
        }
        #endregion

        #region Frutas
        private void numericBanana_ValueChanged(object sender, EventArgs e)
        {
           if (LimitarFrutas()) return;
       
            if (numericBanana.Value > 0)
            {
                listBoxFrutas.Items.Add($"Banana - {numericBanana.Value}");
                listBoxTotal.Items.Add("Banana - R$1,00");
            }
            else
            {
                listBoxFrutas.Items.Remove($"Banana - {numericBanana.Value + 1}");
                listBoxTotal.Items.Remove("Banana - R$1,00");
            }
        }

        private void numericMorango_ValueChanged(object sender, EventArgs e)
        {
            if (LimitarFrutas()) return;
            if (numericMorango.Value > 0)
            {
                listBoxFrutas.Items.Add($"Morango - {numericMorango.Value }");
                listBoxTotal.Items.Add("Morango - R$2,00");
            }
            else
            {
                listBoxFrutas.Items.Remove($"Morango - {numericMorango.Value + 1}");
                listBoxTotal.Items.Remove("Morango - R$2,00");
            }
        }

        private void numericManga_ValueChanged(object sender, EventArgs e)
        {
            if (LimitarFrutas()) return;
            if (numericManga.Value > 0)
            {
                listBoxFrutas.Items.Add($"Manga - {numericManga.Value}");
                listBoxTotal.Items.Add("Manga - R$0,50");
            }
            else
            {
                listBoxFrutas.Items.Remove($"Manga - {numericManga.Value + 1}");
                listBoxTotal.Items.Remove("Manga - R$0,50");
            }
        }

        private void numericUva_ValueChanged(object sender, EventArgs e)
        {
            if (LimitarFrutas()) return;
            if (numericUva.Value > 0)
            {
                listBoxFrutas.Items.Add($"Uva - {numericUva.Value}");
                listBoxTotal.Items.Add("Uva - R$1,70");
            }
            else
            {
                listBoxFrutas.Items.Remove($"Uva - {numericUva.Value + 1  }");
                 listBoxTotal.Items.Remove("Uva - R$1,70");
            }
        }
        #endregion

        #region Cobertura
        private void numericChocolate_ValueChanged(object sender, EventArgs e)
        {
            if (LimitarCobertura()) return;
            if (numericChocolate.Value > 0)
            {
                listBoxCobertura.Items.Add($"Chocolate - {numericChocolate.Value}");
                listBoxTotal.Items.Add("Calda de Chocolate - R$2,50");
            }
            else
            {
                listBoxCobertura.Items.Remove($"Chocolate - {numericChocolate.Value + 1}");
                listBoxTotal.Items.Add("Calda de Chocolate - R$2,50");
            }
        }

        private void numericCaramelo_ValueChanged(object sender, EventArgs e)
        {
            if (LimitarCobertura()) return;
            if (numericCaramelo.Value > 0)
            {
                listBoxCobertura.Items.Add($"Caramelo - {numericCaramelo.Value}");
                listBoxTotal.Items.Add("Cobertura de Caramelo - R$1,05");
            }
            else
            {
                listBoxCobertura.Items.Remove($"Caramelo - {numericCaramelo.Value + 1}");
                listBoxTotal.Items.Add("Cobertura de Caramelo - R$1,05");
            }
        }

        private void numericLeiteCondensado_ValueChanged(object sender, EventArgs e)
        {
            if (LimitarCobertura()) return;
            if (numericLeiteCondensado.Value > 0)
            {
                listBoxCobertura.Items.Add($"Leite Condensado - {numericLeiteCondensado.Value}");
                listBoxTotal.Items.Add("Leite Condensado - R$2,00");
            }
            else
            {
                listBoxCobertura.Items.Remove($"Leite Condensado - {numericLeiteCondensado.Value + 1}");
                listBoxTotal.Items.Remove("Leite Condensado - R$2,00");
            }
        }

        private void numericMorangoCobertura_ValueChanged(object sender, EventArgs e)
        {
            if (LimitarCobertura()) return;
            if (numericMorangoCobertura.Value > 0)
            {
                listBoxCobertura.Items.Add($"Morango - {numericMorangoCobertura.Value}");
                listBoxTotal.Items.Add("Leite Condensado - R$1,35");
            }
            else
            {
                listBoxCobertura.Items.Remove($"Morango - {numericMorangoCobertura.Value + 1}");
                listBoxTotal.Items.Remove("Leite Condensado - R$1,35");
            }
        }

        #endregion 
        #region Limitadores 
        private bool LimitarComplementos()
        {
            if (listBoxComplementos.Items.Count > 2)
            {
                MessageBox.Show($"Você já atingiu o máximo de 3 complentos");
                return true;
            }
            return false;
        }
        private bool LimitarFrutas()
        {
            if (listBoxFrutas.Items.Count > 2)
            {
                MessageBox.Show($"Você já atingiu o máximo de 3 Frutas");
                return true;
            }
            return false;
        }
        private bool LimitarCobertura()
        {
            if (listBoxCobertura.Items.Count > 1)
            {
                MessageBox.Show($"Você já atingiu o máximo de 2 Coberturas");
                return true;
            }
            return false;
        }
        #endregion

        #region Calcular o preço do pedido
        private void btnCalcularCusto_Click(object sender, EventArgs e)
        {
            decimal total = 0;

            // Percorre todos os itens da ListBox
            foreach (var item in listBoxTotal.Items)
            {
                string itemText = item.ToString();

                // Verifica se o item contém um valor monetário (R$)
                if (itemText.Contains("R$"))
                {
                    // Extrai o valor (ex.: "R$1,05" -> "1,05")
                    string valorStr = itemText.Split('$')[1].Replace(",", ".");

                    // Converte para decimal e soma ao total
                    total += decimal.Parse(valorStr, CultureInfo.InvariantCulture);
                }
            }

            // Exibe o total 
            lblValorFinal.Text = ($"Total do pedido: R${total.ToString("F2")}");
        }
        #endregion

        /// Erro aqui, pedir ajuda ao professor
            #region Botão de apagar do total
        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (listBoxTotal.SelectedItem != null)
            {
                listBoxTotal.Items.Remove(listBoxTotal.SelectedItem);
                textBox1.Text = "";
            }
            #endregion
            #region Botão de apagar da cobertura
            else if (listBoxCobertura.SelectedItem != null)
            {
                listBoxCobertura.Items.Remove(listBoxCobertura.SelectedItem);
                textBox1.Text = "";
                
            }
            #endregion
            #region Botão de apagar das frutas
            else if (listBoxFrutas.SelectedItem != null)
            {
                listBoxFrutas.Items.Remove(listBoxFrutas.SelectedItem);
                textBox1.Text = "";
            }
            #endregion
            #region Botão de apagar dos complementos
            else if (listBoxComplementos.SelectedItem != null)
            {
                listBoxComplementos.Items.Remove(listBoxComplementos.SelectedItem);
                textBox1.Text = "";
            }
            #endregion
            #region Botão de apagar tamanho açaí
            else if (listBoxTamanhoAcai.SelectedItem != null)
            {
                listBoxTamanhoAcai.Items.Remove(listBoxTamanhoAcai.SelectedItem);
                textBox1.Text = "";

            }
            else
            {
                MessageBox.Show("Selecione um item para remover.");
            }
            
        }
        #endregion
    }
}
