using Dapper;
using MultApps.Models.Entities;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultApps.Models.Repositories
{
    public class ProdutoRepository
    {
        public string ConnectionString = "Server=localhost;Database=multapps_dev; Uid=root;Pwd=root";

        public bool CadastrarProduto(Produto produto)
        {
            using (IDbConnection db = new MySqlConnection(ConnectionString))
            {
                var comandoSql = @"INSERT INTO produto (nome, preco, quantidade_estoque, status)
                                   VALUES(@Nome, @Preco, @QuantidadeEmEstoque, @Status )";

                var parametros = new DynamicParameters();
                parametros.Add("@Nome", produto.Nome);
                parametros.Add("@Preco", produto.Preco);
                parametros.Add("@QuantidadeEmEstoque", produto.QuantidadeEmEstoque);
                parametros.Add("@Status", produto.Status);

                var resultado = db.Execute(comandoSql, parametros);
                return resultado > 0;
            }
        }
        public bool AtualizarProduto(Produto produto)
        {
            using (IDbConnection db = new MySqlConnection(ConnectionString))
            {
                //Colocar o comando SQL que atualiza dados na tabela.
                var comandoSql = @"UPDATE produto
                                   SET status = @Status,
                                   WHERE nomd = @Nome";

                var parametros = new DynamicParameters();
                parametros.Add("@Id", produto.Id);
                parametros.Add("@Nome", produto.Nome);
                parametros.Add("@Status", produto.Status);

                var resposta = db.Execute(comandoSql, parametros);
                return resposta > 0;
            }
        }
        public List<Produto> ListarTodosProdutos()
        {
            using (IDbConnection db = new MySqlConnection(ConnectionString))
            {
                var comandoSql = @"SELECT id, 
                                 nome AS Nome, 
                                 preco AS Preco, 
                                 quantidade_estoque AS QuantidadeEmEstoque,
                                 data_criacao AS DataCadastro,
                                 data_alteracao AS DataAlteracao,
                                 status 
                                 FROM produto;";
                var resultado = db.Query<Produto>(comandoSql).ToList();
                return resultado;
            }
        }
        
    }
}
