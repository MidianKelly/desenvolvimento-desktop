using MultApps.Models.Entities;
using MultApps.Models.Enums;
using MultApps.Models.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
        private void CarregarTodosOsProdutos()
        {
            var produtosRepository = new ProdutoRepository();
            var listaDeProdutos = produtosRepository.ListarTodosProdutos();

            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.Columns.Clear();

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Id",
                HeaderText = "Id",
                MinimumWidth = 100,
            });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Nome",
                HeaderText = "Nome do Produto",
                MinimumWidth = 300,
            });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Preco",
                HeaderText = "Preço",
                MinimumWidth = 150,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "C2" } // Formata como moeda
            });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "DataCadastro",
                HeaderText = "Data de Cadastro",
                DefaultCellStyle = new DataGridViewCellStyle { Format = "dd/MM/yyyy HH:mm" },
                MinimumWidth = 200
            });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "DataAlteracao",
                HeaderText = "Data de Alteração",
                DefaultCellStyle = new DataGridViewCellStyle { Format = "dd/MM/yyyy HH:mm" },
                MinimumWidth = 200
            });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Status",
                HeaderText = "Status",
            });

            dataGridView1.DataSource = listaDeProdutos;

            dataGridView1.CellFormatting += dataGridView1_CellFormatting_1;
        }
        private void dataGridView1_CellFormatting_1(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].DataPropertyName == "Status")
            {
                if (e.Value != null && e.Value is StatusEnum status)
                {
                    switch (status)
                    {
                        case StatusEnum.Inativo:
                            e.CellStyle.ForeColor = Color.Gray;
                            break;
                        case StatusEnum.Ativo:
                            e.CellStyle.ForeColor = Color.Blue;
                            break;
                        case StatusEnum.Excluido:
                            e.CellStyle.ForeColor = Color.Red;
                            break;
                    }
                }
            }
        }

        private void frmGestaoProdutos_Load(object sender, EventArgs e)
        {
            var produtos = new CategoriaRepository();
            var preencheCombox = produtos.ListarTodasCategorias();
                
            // Preenchendo o ComboBox com as categorias
            cmbCategoriaProduto.DisplayMember = "Nome";
            cmbCategoriaProduto.ValueMember = "Id";
            cmbCategoriaProduto.DataSource = preencheCombox;

            CarregarTodosOsProdutos();           
        }
       
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            var produto = new Produto();
            produto.Nome = txtNomeProduto.Text;
            if (radioBtnAtivo.Checked)
                produto.Status = StatusEnum.Ativo;
            else if (radioBtnInativo.Checked)
                produto.Status = StatusEnum.Inativo;
            

            var produtoRepository = new ProdutoRepository();

            if (string.IsNullOrEmpty(txtNomeProduto.Text))
            {
                var resultado = produtoRepository.CadastrarProduto(produto);
                if (resultado)
                {
                    MessageBox.Show("Produto cadastrado com sucesso");
                }
                else
                {
                    MessageBox.Show("Erro ao cadastrar produto");
                }
            }
            else
            {               
                var resultado = produtoRepository.AtualizarProduto(produto);

                if (resultado)
                {
                    MessageBox.Show("Produto atualizado com sucesso");
                }
                else
                {
                    MessageBox.Show("Erro ao atualizar o produto");
                }

            }
            CarregarTodosOsProdutos();
        }
       
    }
}
