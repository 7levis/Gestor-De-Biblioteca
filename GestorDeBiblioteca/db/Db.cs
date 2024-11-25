using MySql.Data.MySqlClient;
using Org.BouncyCastle.Cms;

namespace GestorDeBiblioteca.db
{
    public class Db
    {
        private readonly String _connectionString;

        public Db (string server, string username, string password)
        {
            _connectionString = $"Server={server};Port=3306;User Id={username};Password={password}";
        }

        public void CriandoDB(String databaseName)
        {
            try
            {
                using (var conexao = new MySqlConnection(_connectionString))
                {
                    conexao.Open();
                    Console.WriteLine("Conexão com o servidor MySQL concluida com sucesso!");

                    string criandoDbQuery = $"CREATE DATABASE IF NOT EXISTS {databaseName};";
                    using (var cmd = new MySqlCommand(criandoDbQuery, conexao))
                    {
                        cmd.ExecuteNonQuery();
                        Console.WriteLine($"Banco de dados {databaseName} criado ou já existe.");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao criar o banco de dados: {ex.Message}");
            }
        }

        public void CriandoTabela(String databaseName, String tableName)
        {
            try
            {
                using (var conexao = new MySqlConnection(_connectionString))
                {
                    conexao.Open();
                    conexao.ChangeDatabase(databaseName);

                    string createTableQuery = $@"
                        CREATE TABLE IF NOT EXISTS {tableName} (
                            id INT AUTO_INCREMENT PRIMARY KEY,
                            titulo VARCHAR(100) NOT NULL,
                            autor VARCHAR(100) NOT NULL
                        );";
                    using (var cmd = new MySqlCommand(createTableQuery, conexao))
                    {
                        cmd.ExecuteNonQuery();
                        Console.WriteLine($"Tabela '{tableName}' criada com sucesso!");
                    }

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao criar a tabela: {ex.Message}");
            }
        }
    }
}