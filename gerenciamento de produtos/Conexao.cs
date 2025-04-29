using MySql.Data.MySqlClient;

namespace SistemaProdutos
{
    public class Conexao
    {
        private static string conexaoString = "server=localhost;database=estoque₢₢;uid=root;pwd=;";
        public static MySqlConnection ObterConexao()
        {
            return new MySqlConnection(conexaoString);
        }
    }
}

