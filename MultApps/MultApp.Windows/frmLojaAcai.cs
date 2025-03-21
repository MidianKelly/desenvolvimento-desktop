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
            listBoxCobertura.Items.Add("R$15,00");
        }

        private void btnAcaiMedio_Click(object sender, EventArgs e)
        {
            listBoxTamanhoAcai.Items.Add("Açaí 500ml");
            listBoxCobertura.Items.Add("R$20,00");
        }

        private void btnAcaiGrande_Click(object sender, EventArgs e)
        {
            listBoxTamanhoAcai.Items.Add("Açaí 700ml");
            listBoxCobertura.Items.Add("R$25,00");
        }

        private void btnAcaiFamilia_Click(object sender, EventArgs e)
        {
            listBoxTamanhoAcai.Items.Add("Açaí 1,5l");
            listBoxCobertura.Items.Add("R$35,00");
        }

        #endregion

        private void NumericGranola_ValueChanged(object sender, EventArgs e)
        {
            if (NumericGranola.Value > 0  && NumericGranola.Value <3)
            {
                listBoxComplementos.Items.Add($"Granola - {NumericGranola.Value}");
            }
            else
            {
                listBoxComplementos.Items.Remove($"Granola - {NumericGranola.Value + 1}");
            }
        }

        private void numericLeiteEmPo_ValueChanged(object sender, EventArgs e)
        {
            if (numericLeiteEmPo.Value > 0)
            {
                listBoxComplementos.Items.Add($"Leite em Pó - {numericLeiteEmPo.Value}");
            }
            else
            {
                listBoxComplementos.Items.Remove($"Leite em Pó - {numericLeiteEmPo.Value + 1}");
            }
        }

        private void numericChocobol_ValueChanged(object sender, EventArgs e)
        {
            if (numericChocobol.Value > 0 )
            {
                listBoxComplementos.Items.Add($"Chocobol - {numericChocobol.Value}");
            }
            else
            {
                listBoxComplementos.Items.Remove($"Chocobol - {numericChocobol.Value + 1}");
            }
        }

        private void numericGotasChocolate_ValueChanged(object sender, EventArgs e)
        {
            if (numericGotasChocolate.Value > 0)
            {
                listBoxComplementos.Items.Add($"Gotas de Chocolate - {numericGotasChocolate.Value}");
            }
            else
            {
                listBoxComplementos.Items.Remove($"Gotas de Chocolate - {numericGotasChocolate.Value + 1}");
            }
        }

        private void numericBanana_ValueChanged(object sender, EventArgs e)
        {
            if (numericBanana.Value > 0)
            {
                listBoxComplementos.Items.Add($"Banana - {numericBanana.Value}");
            }
            else
            {
                listBoxComplementos.Items.Remove($"Banana - {numericBanana.Value + 1}");
            }
        }

        private void numericMorango_ValueChanged(object sender, EventArgs e)
        {
            if (numericMorango.Value > 0)
            {
                listBoxComplementos.Items.Add($"Morango - {numericMorango.Value }");
            }
            else
            {
                listBoxComplementos.Items.Remove($"Morango - {numericMorango.Value + 1}");
            }
        }

        private void numericManga_ValueChanged(object sender, EventArgs e)
        {
            if (numericManga.Value > 0)
            {
                listBoxComplementos.Items.Add($"Manga - {numericManga.Value}");
            }
            else
            {
                listBoxComplementos.Items.Remove($"Manga - {numericManga.Value + 1}");
            }
        }

        private void numericUva_ValueChanged(object sender, EventArgs e)
        {
            if (numericUva.Value > 0)
            {
                listBoxComplementos.Items.Add($"Uva - {numericUva.Value}");
            }
            else
            {
                listBoxComplementos.Items.Remove($"Uva - {numericUva.Value + 1  }");
            }
        }

        private void numericChocolate_ValueChanged(object sender, EventArgs e)
        {
            if (numericChocolate.Value > 0)
            {
                listBoxCobertura.Items.Add($"Chocolate - {numericChocolate.Value}");
            }
            else
            {
                listBoxCobertura.Items.Remove($"Chocolate - {numericChocolate.Value + 1}");
            }
        }

        private void numericCaramelo_ValueChanged(object sender, EventArgs e)
        {
            if (numericCaramelo.Value > 0)
            {
                listBoxCobertura.Items.Add($"Caramelo - {numericCaramelo.Value}");
            }
            else
            {
                listBoxCobertura.Items.Remove($"Caramelo - {numericCaramelo.Value + 1}");
            }
        }

        private void numericLeiteCondensado_ValueChanged(object sender, EventArgs e)
        {
            if (numericLeiteCondensado.Value > 0)
            {
                listBoxCobertura.Items.Add($"Leite Condensado - {numericLeiteCondensado.Value}");
            }
            else
            {
                listBoxCobertura.Items.Remove($"Leite Condensado - {numericLeiteCondensado.Value + 1}");
            }
        }

        private void numericMorangoCobertura_ValueChanged(object sender, EventArgs e)
        {
            if (numericMorangoCobertura.Value > 0)
            {
                listBoxCobertura.Items.Add($"Morango - {numericMorangoCobertura.Value}");
            }
            else
            {
                listBoxCobertura.Items.Remove($"Morango - {numericMorangoCobertura.Value + 1}");
            }
        }
    }
}
