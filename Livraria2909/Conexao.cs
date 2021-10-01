using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Livraria2909
{
    public class Conexao
    {
        // representa a conexão com o banco
        public SqlConnection conn; 

        // método que permite obter a conexão
        private string connString = @"server = .\SQLEXPRESS; 
        Database = LivrariaProj2909;integrated security = true;User Id=Ricardo;Password=";

        //criando o comando que recebe a consulta
        public SqlCommand comando;

        public SqlDataReader reader;

        public Conexao()
        {
            conn = new SqlConnection(connString);
        }
        
    }
}

