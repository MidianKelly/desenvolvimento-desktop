using Dapper;
using MultiApps.Models.Entities;
using MultiApps.Models.Entities.Abstract;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiApps.Models.Repositories1
{
    public class UsuariosRepository
    {
        public string ConnectionString = "Server=localhost; Database=multapps_dev; Uid=root; Pwd=root";

        public bool CadastrarUsuarios(Usuario usuario)
        {
            using (IDbConnection db = new MySqlConnection(ConnectionString))
            {
                var comandoSql = @"INSERT INTO usuario(nome, cpf, email, senha, status)
                                  VALUES (@Nome,@Cpf,@Email,@Senha, @Status)";

                var parametro = new DynamicParameters();
                parametro.Add("@Nome", usuario.Nome);
                parametro.Add("@Status", usuario.Status.ToString().ToLower());
                parametro.Add("@Senha", usuario.Email);
                parametro.Add("@Email", usuario.Senha);
                parametro.Add("@Cpf", usuario.Cpf);

                var resultado = db.Execute(comandoSql, parametro);
                return resultado > 0;
            }
        }
        public bool AtualizarCategoria(Usuario usuario)
        {
            using (IDbConnection db = new MySqlConnection(ConnectionString))
            {
                var comandoSql = @"UPDATE usuario 
                                   SET nome = @Nome, status = @Status, email = @Email,
                                   senha = @Senha, cpf = @Cpf
                                   WHERE id = @Id";
                var parametro = new DynamicParameters();
                parametro.Add("@Id", usuario.Id);
                parametro.Add("@Nome", usuario.Nome);
                parametro.Add("@Status", usuario.Status.ToString().ToLower());
                parametro.Add("@Email", usuario.Email);
                parametro.Add("@Senha", usuario.Senha);
                parametro.Add("@Cpf", usuario.Cpf);

                var resposta = db.Execute(comandoSql, parametro);
                return resposta > 0;
            }

        }
    }
}
