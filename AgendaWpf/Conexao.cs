using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace AgendaWpf
{
    class Conexao
    {
        public static SqlConnection Conecta()
        {
            try
            {
                String caminho = @"Data Source=REINALDO-PC;Initial Catalog=AgendaWpf;Integrated Security=True";
                SqlConnection conexao = new SqlConnection(caminho);
                return conexao;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

    }
}
