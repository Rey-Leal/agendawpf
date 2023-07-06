using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace AgendaWpf
{
    public class ContatoDAO
    {
        public static String SalvaContato(ContatoBO contatoBO)
        {
            SqlConnection conexao1 = new SqlConnection();
            SqlConnection conexao2 = new SqlConnection();
            try
            {
                conexao1 = Controle.Conecta();
                conexao1.Open();
                string comando1 = "SELECT id FROM Contatos WHERE nome = '" + contatoBO.Nome + "'";
                SqlCommand cmd1 = new SqlCommand(comando1, conexao1);
                SqlDataReader dr1 = cmd1.ExecuteReader();
                if (dr1.Read())
                {
                    return "Nome já cadastrado!";
                }
                else
                {
                    conexao2 = Controle.Conecta();
                    conexao2.Open();
                    String comando2 = "INSERT INTO Contatos (tipo, nome, telefone, celular, email) VALUES (" + contatoBO.Tipo + ",'" + contatoBO.Nome + "','" + contatoBO.Telefone + "','" + contatoBO.Celular + "','" + contatoBO.Email + "')";
                    SqlCommand cmd2 = new SqlCommand(comando2, conexao2);
                    cmd2.ExecuteNonQuery();
                    return "Contato salvo com sucesso";
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conexao1.Close();
                conexao2.Close();
            }
        }
    }
}
