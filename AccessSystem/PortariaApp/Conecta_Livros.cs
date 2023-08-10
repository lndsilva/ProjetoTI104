using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace PortariaApp
{
    class Conexao_Livros
    {
        private static string conString = "server=localhost;Port=3306;Database=livros;Uid=root;Pwd=''";
        private static MySqlConnection conn = null;

        public static MySqlConnection obterConexao()
        {
            conn = new MySqlConnection(conString);
            try
            {
                conn.Open();
            }
            catch (MySqlException)
            {
                conn = null;
            }
            return conn;
        }
        public static void fecharConexao()
        {
            if (conn != null)
            {
                conn.Close();
            }
        }

    }
}
