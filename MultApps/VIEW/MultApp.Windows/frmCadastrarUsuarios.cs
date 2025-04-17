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
            var status = new[] { "inativo", "ativo" };
            var filtro = new[] { "inativo", "ativo", "todos" };
            cmbStatus.Items.AddRange(status);
            cmbListarStatus.Items.AddRange(filtro);

            cmbStatus.SelectedIndex = 1;
        }
        private void btnSalvar_Click(object sender, EventArgs e)
            {
           
            try
            {
                if (TemCamposEmBranco())
                {
                    return;
                }
                var usuario = new Usuario();
                usuario.Nome = txtNome.Text;
                usuario.Status = (StatusEnum)cmbStatus.SelectedIndex;
                usuario.Cpf = maskedCpf.Text;
                usuario.Email = txtEmail.Text;
                usuario.Senha = txtSenha.Text;

                var usuarioRepository = new UsuariosRepository();

                var emailJaExiste = usuarioRepository.EmailExistente(usuario.Email);
                if (emailJaExiste)
                {
                    MessageBox.Show($"O e-mail {usuario.Email} já está cadastrado");
                    txtEmail.Focus();
                    return;
                }


                var sucesso = usuarioRepository.CadastrarUsuarios(usuario);

                if (string.IsNullOrEmpty(txtId.Text))
                {
                    if (sucesso)
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
                    var sucesso2 = usuarioRepository.AtualizarUsuario(usuario);

                    if (sucesso2)
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
            catch (Exception)
            {

                throw;
            }          
        }
        private bool TemCamposEmBranco()
        {
            if (string.IsNullOrEmpty (txtNome.Text))
            {
                MessageBox.Show("Campo nome obrigatório");
                txtNome.Focus();
                return true; 
            }

            if (string.IsNullOrEmpty(maskedCpf.Text))
            {
                MessageBox.Show("Campo CPF obrigatório");
                maskedCpf.Focus();
                return true;
            }

            if (string.IsNullOrEmpty(txtEmail.Text))
            {
                MessageBox.Show("Campo e-mail obrigatório");
                txtEmail.Focus();
                return true;
            }

            if (string.IsNullOrEmpty(txtSenha.Text))
            {
                MessageBox.Show("Campo senha obrigatório");
                txtSenha.Focus();
                return true;
            }

            if (cmbStatus.SelectedIndex == -1)
            {
                MessageBox.Show("Campo status obrigatório");
                cmbStatus.Focus();
                return true;
            }
            return false;
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
