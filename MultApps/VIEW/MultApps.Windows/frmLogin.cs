using MultApps.Models.Repositories;
using MultApps.Models.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultApps.Windows
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsuario.Text))
            {
                MessageBox.Show("O campo usuário é obrigatório");
                txtUsuario.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtSenha.Text))
            {
                MessageBox.Show("O campo senha é obrigatório");
                txtSenha.Focus();
                return;
            }

            var usuarioRepository = new UsuarioRepository();
            var usuario = usuarioRepository.ObterUsuarioPorEmail(txtUsuario.Text);

            if (usuario == null || usuario.Email != txtUsuario.Text)
            {
                MessageBox.Show("Usuário inválido");
                txtUsuario.Focus();
                return;
            }

            if (usuario.Status == Models.Enums.StatusEnum.Inativo) 
            {
                MessageBox.Show("O usuário está inativo");
                txtUsuario.Focus();
                return;
            }

            var senhaConfere = CriptografiaService.Verificar(txtSenha.Text, usuario.Senha);

            if (senhaConfere)
            {
                var formPrincipal = new Principal(usuario);
                formPrincipal.Show();
            }
            else
            {
                MessageBox.Show("Usuário ou senha inválidas");
            }
        }

        private void btnRecuperarSenha_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsuario.Text))
            {
                MessageBox.Show("Informe seu e-mail do seu usuário");
                txtUsuario.Focus();
                return;
            }
          
            var usuarioRepository = new UsuarioRepository();
            var novaSenha = CriptografiaService.Criptografar("123456");

            var senhaAtualizou = usuarioRepository.AtualizarSenha(novaSenha, txtUsuario.Text);

            if (senhaAtualizou) 
            {
                MessageBox.Show("Senha atualizou com sucesso. A nova senha é 123456");
            }
            else
            {
                MessageBox.Show("Erro ao atualizar senha");
            }

        }
    }
}
