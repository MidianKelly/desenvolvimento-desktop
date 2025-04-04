using MultiApps.Models.Entities;
using MultiApps.Models.Enums;
using MultiApps.Models.Repositories1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultApp.Windows
{
    public partial class frmCategoria : Form
    {
        public frmCategoria()
        {
            InitializeComponent();
            CarregarTodasCategorias();
        }

        

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            var categoria = new Categoria();
            categoria.Nome = txtNome.Text;
            categoria.Status = (StatusEnum)cmbStatus.SelectedIndex; 

            var categoriaRepository = new CategoriaRepository();
            var resultado = categoriaRepository.CadastrarCategoria(categoria);

            if (resultado)
            {
                MessageBox.Show("Categoria cadastrada com sucesso");
            }
            else
            {
                MessageBox.Show("Erro ao cadastrar categoria");
            }
            CarregarTodasCategorias();

        }
        private void CarregarTodasCategorias()
        {
            var categoriaRepository = new CategoriaRepository();
            var listaDeCategorias = categoriaRepository.ListarTodasCategorias();

            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.Columns.Clear();

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Id",
                HeaderText = "id"
            }
            );

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Nome",
                HeaderText = "Nome Categoria"
            }
            );
           
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "DataCadastro",
                HeaderText = "Data de Cadastro"
            }
           );
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "DataAlteracao",
                HeaderText = "Data de Alteração"
            }
           );
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Status",
                HeaderText = "Status"
                
            }
         );
            dataGridView1.DataSource = listaDeCategorias;
        }
    }
}
