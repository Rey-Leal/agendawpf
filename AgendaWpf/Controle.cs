using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace AgendaWpf
{
    class Controle
    {
        public static SqlConnection Conecta()
        {
            try
            {
                return Conexao.Conecta();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static String NomeAplicacao()
        {
            return "Agenda WPF";
        }

        public static int EnumDoTipo(String tipoStr)
        {
            switch (tipoStr)
            {
                case "Pessoal": return 1;
                case "Profissional": return 2;
                case "Relacionamentos": return 3;
                case "Comercial": return 4;
                case "Outros": return 5;
                default: return 1;
            }
            //if (tipoStr.Equals(Enumeracoes.TipoContato.Pessoal.ToString()))
            //{
            //}
            //else if (tipoStr.Equals(Enumeracoes.TipoContato.Profissional.ToString()))
            //{
            //}
            //else if (tipoStr.Equals(Enumeracoes.TipoContato.Relacionamentos.ToString()))
            //{
            //}
            //else if (tipoStr.Equals(Enumeracoes.TipoContato.Comercial.ToString()))
            //{
            //}
            //else if (tipoStr.Equals(Enumeracoes.TipoContato.Outros.ToString()))
            //{
            //}
        }

        public static String SalvaContato(ContatoBO contatoBO)
        {
            try
            {
                return ContatoDAO.SalvaContato(contatoBO);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
