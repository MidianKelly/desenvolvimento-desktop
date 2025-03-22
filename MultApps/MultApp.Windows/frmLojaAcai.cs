using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
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
        }

        private void btnAcaiMedio_Click(object sender, EventArgs e)
        {
            listBoxTamanhoAcai.Items.Add("Açaí 500ml");
            listBoxTotal.Items.Add("R$20,00");
        }

        private void btnAcaiGrande_Click(object sender, EventArgs e)
        {
            listBoxTamanhoAcai.Items.Add("Açaí 700ml");
            listBoxTotal.Items.Add("R$25,00");
        }

        private void btnAcaiFamilia_Click(object sender, EventArgs e)
        {
            listBoxTamanhoAcai.Items.Add("Açaí 1,5l");
            listBoxTotal.Items.Add("R$35,00");
        }

        #endregion
        #region Complementos
        private void NumericGranola_ValueChanged(object sender, EventArgs e)
        {
            if (NumericGranola.Value > 0  && NumericGranola.Value <3)
            {
                listBoxComplementos.Items.Add($"Granola - {NumericGranola.Value}");
                listBoxTotal.Items.Add("Granola R$3,00");
            }
            else
            {
                listBoxComplementos.Items.Remove($"Granola - {NumericGranola.Value + 1}");
                listBoxTotal.Items.Remove("Granola R$3,00");
            }
        }

        private void numericLeiteEmPo_ValueChanged(object sender, EventArgs e)
        {
            if (numericLeiteEmPo.Value > 0)
            {
                listBoxComplementos.Items.Add($"Leite em Pó - {numericLeiteEmPo.Value}");
                listBoxTotal.Items.Add("Leite em Pó R$4,00");
            }
            else
            {
                listBoxComplementos.Items.Remove($"Leite em Pó - {numericLeiteEmPo.Value + 1}");
                listBoxTotal.Items.Add("Leite em Pó R$4,00");
            }
        }

        private void numericChocobol_ValueChanged(object sender, EventArgs e)
        {
            if (numericChocobol.Value > 0 )
            {
                listBoxComplementos.Items.Add($"Chocobol - {numericChocobol.Value}");
                listBoxTotal.Items.Add("Chocobol R$3,00");
            }
            else
            {
                listBoxComplementos.Items.Remove($"Chocobol - {numericChocobol.Value + 1}");
                listBoxTotal.Items.Remove("Chocobol R$3,00");
                
            }
        }
        
        private void numericGotasChocolate_ValueChanged(object sender, EventArgs e)
        {
            if (numericGotasChocolate.Value > 0)
            {
                listBoxComplementos.Items.Add($"Gotas de Chocolate - {numericGotasChocolate.Value}");
                listBoxTotal.Items.Add("Gotas de Chocolate R$5,00");
            }
            else
            {
                listBoxComplementos.Items.Remove($"Gotas de Chocolate - {numericGotasChocolate.Value + 1}");
                listBoxTotal.Items.Add("Chocobol R$5,00");
            }
        }
        #endregion
        #region Frutas
        private void numericBanana_ValueChanged(object sender, EventArgs e)
        {
            if (numericBanana.Value > 0)
            {
                listBoxFrutas.Items.Add($"Banana - {numericBanana.Value}");
                listBoxTotal.Items.Add("Banana R$1,00");
            }
            else
            {
                listBoxFrutas.Items.Remove($"Banana - {numericBanana.Value + 1}");
                listBoxTotal.Items.Remove("Banana R$1,00");
            }
        }
        
        private void numericMorango_ValueChanged(object sender, EventArgs e)
        {
            if (numericMorango.Value > 0)
            {
                listBoxFrutas.Items.Add($"Morango - {numericMorango.Value }");
                listBoxTotal.Items.Add("Morango R$1,50");
            }
            else
            {
                listBoxFrutas.Items.Remove($"Morango - {numericMorango.Value + 1}");
                listBoxTotal.Items.Remove ("Morango R$1,50");
            }
        }

        private void numericManga_ValueChanged(object sender, EventArgs e)
        {
            if (numericManga.Value > 0)
            {
                listBoxFrutas.Items.Add($"Manga - {numericManga.Value}");
                listBoxTotal.Items.Add("Manga R$0,50");
            }
            else
            {
                listBoxFrutas.Items.Remove($"Manga - {numericManga.Value + 1}");
                listBoxTotal.Items.Remove("Manga R$0,50");
            }
        }

        private void numericUva_ValueChanged(object sender, EventArgs e)
        {
            if (numericUva.Value > 0)
            {
                listBoxFrutas.Items.Add($"Uva - {numericUva.Value}");
                listBoxTotal.Items.Add("Uva - R$1,50");
            }
            else
            {
                listBoxFrutas.Items.Remove($"Uva - {numericUva.Value + 1  }");
                listBoxTotal.Items.Remove("Uva - R$1,50");
            }
        }
        #endregion
        #region Cobertura
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
            if (numericCaramelo.Value > 0 && numericCaramelo.Value < 3)
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
        #endregion

        private bool LimitarItens()
        {
            if (listBoxComplementos.Items.Count > 3)
            {
                MessageBox.Show("Limite de itens atingidos");
                return true;
            }
            return false;
        }
        private bool LimitarItens2()
        {
            if (listBoxFrutas.Items.Count > 2)
            {
                MessageBox.Show("Limite de itens atingidos");
                return true;
            }
            return false;
        }
        private bool LimitarItens3()
        {
            if (listBoxCobertura.Items.Count > 2)
            {
                listBoxCobertura.Items.Add("Limite de itens atingidos");
                return true;
            }
            return false;
        }

    
        private void btnSomar_Click(object sender, EventArgs e)
        {

        }
    }
}
