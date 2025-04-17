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
        public bool EmailExistente (string email)
        {
            using (IDbConnection db = new MySqlConnection(ConnectionString))
            {
                var comandoSql = @"SELECT COUNT (*) FROM usuario WHERE email = @Email";

                var parametro = new DynamicParameters();
                parametro.Add("@Email = email");
                var resultado = db.ExecuteScalar<int>(comandoSql, parametro);
                return resultado > 0;
            }
        }
        public bool AtualizarUsuario(Usuario usuario)

        {
            using (IDbConnection db = new MySqlConnection(ConnectionString))
            {
                var comandoSql = @"UPDATE usuario 
                                   SET nome = @Nome, status = @Status, cpf = @Cpf, 
                                   email = @Email,senha = @Senha
                                   WHERE id = @Id";
                var parametro = new DynamicParameters();
                parametro.Add("@Id", usuario.Id);
                parametro.Add("@Nome", usuario.Nome);
                parametro.Add("@Status", usuario.Status.ToString().ToLower());
                parametro.Add("@Email", usuario.Email.ToLower());
                parametro.Add("@Senha", usuario.Senha);


                var resposta = db.Execute(comandoSql, parametro);
                return resposta > 0;
            }

        }
        public bool DeletarUsuario(int id)
        {
            using (IDbConnection db = new MySqlConnection(ConnectionString))
            {
                var comandoSql = @"DELETE FROM usuario WHERE id = @Id";

                var parametro = new DynamicParameters();
                parametro.Add("@Id", id);

                var resultado = db.Execute(comandoSql, parametro);
                return resultado > 0;

            }
        }
        public List<Usuario> ListarTodosUsuario()
        {
            using (IDbConnection db = new MySqlConnection(ConnectionString))
            {
                var comandoSql = @"SELECT id, nome, data_cadastro AS DataCadastro, ultimo_acesso AS UltimoAcesso, senha, 
                           cpf, email 
                           FROM usuario";  // Assuming the table name is 'usuario'
                var resultado = db.Query<Usuario>(comandoSql).ToList();  // Mapping the result to Usuario instead of Categoria
                return resultado;
            }
        }
        public Categoria MostrarUsuariosPorId(int id)
        {
            using (IDbConnection db = new MySqlConnection(ConnectionString))
            {
                var comandoSql = @"SELECT id, nome, cpf, email, senha, data_cadastro AS DataCadastro, ultimo_acesso AS UltimoAcesso, status 
                                  FROM usurio
                                  WHERE id = @id";

                var parametros = new DynamicParameters();
                parametros.Add("@Id", id);
                var resultado = db.Query<Categoria>(comandoSql, parametros).FirstOrDefault();

                return resultado;
            }

        }
       
    
    }
}
