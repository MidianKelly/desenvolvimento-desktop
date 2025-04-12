using Dapper;
using MultiApps.Models.Entities;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MultiApps.Models.Repositories1
{
    public class CategoriaRepository
    {
        public string ConnectionString = "Server=localhost; Database=multapps_dev; Uid=root; Pwd=root";

        public bool CadastrarCategoria(Categoria categoria)
        {
            using (IDbConnection db = new MySqlConnection(ConnectionString))
            {
                var comandoSql = @"INSERT INTO Categoria(nome, status)
                                  VALUES (@Nome, @Status)";

                var parametro = new DynamicParameters();
                parametro.Add("@Nome", categoria.Nome);
                parametro.Add("@Status", categoria.Status.ToString());

       
                var resultado = db.Execute(comandoSql, parametro);
                return resultado > 0;

            }
        }

        public bool AtualizarCategoria (Categoria categoria)


        {
            using (IDbConnection db = new MySqlConnection(ConnectionString))
            {
                var comandoSql = @"UPDATE categoria 
                                   SET nome = @Nome, status = @Status
                                   WHERE id = @Id";
                var parametro = new DynamicParameters();
                parametro.Add("@Id", categoria.Id);
                parametro.Add("@Nome", categoria.Nome);
                parametro.Add("@Status", categoria.Status);

            
               var resposta = db.Execute(comandoSql, parametro);
                return resposta > 0;            
            }

        }
        
        public bool DeletarCategoria (int id)
        {
            using (IDbConnection db = new MySqlConnection(ConnectionString))
            {
                var comandoSql = @"DELETE FROM categoria WHERE id = @Id";
                
                var parametro = new DynamicParameters();
                parametro.Add("@Id", id);

                var resultado = db.Execute(comandoSql, parametro);
                return resultado > 0;
               
            }
        }
        public List<Categoria> ListarTodasCategorias()
        {
            using (IDbConnection db = new MySqlConnection(ConnectionString))
            {
                var comandoSql = @"SELECT Id AS id, nome AS Nome, data_criacao AS DataCriacao, data_alteracao AS DataAlteracao, status
                                  FROM categoria";
                var resultado = db.Query<Categoria>(comandoSql).ToList();
                return resultado;
            }

        }
        public Categoria MostrarCategoriaPorID(int id)
        {
            using (IDbConnection db = new MySqlConnection(ConnectionString))
            {
                var comandoSql = @"SELECT id, nome, data_criacao AS DataCriacao, data_alteracao AS DataAlteracao, status 
                                  FROM categoria
                                  WHERE id = @id";
                
                var parametros = new DynamicParameters();
                parametros.Add("@Id", id);
                var resultado = db.Query<Categoria>(comandoSql, parametros).FirstOrDefault();

                return resultado;
            }

        }
    }
}
