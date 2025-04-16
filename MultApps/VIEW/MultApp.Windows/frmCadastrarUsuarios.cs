using MultiApps.Models.Entities;
using MultiApps.Models.Entities.Abstract;
using MultiApps.Models.Enums;
using MultiApps.Models.Enums;
using MultiApps.Models.Enums;
using MultiApps.Models.Repositories1;
using System;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace MultApp.Windows
{
    public partial class frmCadastrarUsuarios : Form
    {
        public frmCadastrarUsuarios()
        {
            InitializeComponent();
            CarregarTodosUsuarios();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            var usuario = new Usuario();
            usuario.Nome = txtNome.Text;
            usuario.Status = (StatusEnum)cmbStatus.SelectedIndex;
            usuario.Cpf = maskedCpf.Text;
            usuario.Email = txtEmail.Text;
            usuario.Senha = txtSenha.Text;
            

            var usuarioRepository = new UsuariosRepository();


            if (string.IsNullOrEmpty(txtId.Text))
            {
                var resultado = usuarioRepository.CadastrarUsuarios(usuario);

                if (resultado)
                {
                    MessageBox.Show("Usuario cadastrado com sucesso");
                }
                else
                {
                    MessageBox.Show("Erro ao cadastrar usuario");
                }
            }
            else
            {
                usuario.Id = int.Parse(txtId.Text);
                var resultado = usuarioRepository.AtualizarUsuario(usuario);
                
                if (resultado)
                {
                    MessageBox.Show("Usuário atualizado com sucesso");
                }
                else
                {
                    MessageBox.Show("Erro ao atualizar o usuário");
                }
            }
            CarregarTodosUsuarios();
        }
        private void CarregarTodosUsuarios()
        {
            var usuariosRepository = new UsuariosRepository();
            var listarUsuarios = usuariosRepository.ListarTodosUsuario();

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
                HeaderText = "Nome do Usuário"
            }
            );
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Cpf",
                HeaderText = "CPF"
            }
            );
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Email",
                HeaderText = "E-mail"
            }
           );
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Senha",
                HeaderText = "Senha"
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
                DataPropertyName = "UltimoAcesso",
                HeaderText = "Último acesso"
            }
          );
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Status",
                HeaderText = "Status"
            }
          );
            dataGridView1.DataSource = listarUsuarios;
        }

        
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtId.Text = string.Empty;
            txtNome.Text = string.Empty;
            txtCadastro.Text = string.Empty;
            txtSenha.Text = string.Empty;
            cmbStatus.SelectedIndex = -1;
            maskedCpf.Text = string.Empty;
            txtEmail.Text = string.Empty;
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            var usuarioId = int.Parse(txtId.Text);

            var categoriaRepository = new CategoriaRepository();
            var sucesso = categoriaRepository.DeletarCategoria(usuarioId);

            if (sucesso)
            {
                MessageBox.Show("Usuário removido com sucesso");
                CarregarTodosUsuarios();
            }
            else
            {
                MessageBox.Show($"Não foi possível deletar o usuário:{txtNome.Text}");
            }
            btnDeletar.Enabled = false;
            btnLimpar_Click(sender, e);
        }
    }
}
