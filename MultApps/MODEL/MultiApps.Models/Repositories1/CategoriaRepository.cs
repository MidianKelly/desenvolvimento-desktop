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
        public List<Categoria> ListarTodasCategorias()
        {
            using (IDbConnection db = new MySqlConnection(ConnectionString))
            {
                var comandoSql = @"SELECT * FROM categoria";
                var resultado = db.Query<Categoria>(comandoSql).ToList();
                return resultado;
            }

        }
    }
}
