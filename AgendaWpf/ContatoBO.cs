using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AgendaWpf
{
    public class ContatoBO
    {
        //construtores
        public ContatoBO(int tipo, String nome, String telefone, String celular, String email)
        {
            this.Tipo = tipo;
            this.Nome = nome;
            this.Telefone = telefone;
            this.Celular = celular;
            this.Email = email;
        }

        //atributos
        private int tipo;
        private String nome;
        private String telefone;
        private String celular;
        private String email;

        //propriedades
        public int Tipo
        {
            get { return tipo; }
            set
            {
                if (value > 5)
                {
                    value = 5;
                }
                else
                {
                    tipo = value;
                }
            }
        }

        public String Nome
        {
            get { return nome; }
            set
            {
                if (value.Length > 70)
                {
                    nome = value.Substring(0, 70);
                }
                else
                {
                    nome = value;
                }
            }
        }

        public String Telefone
        {
            get { return telefone; }
            set
            {
                if (value.Length > 50)
                {
                    telefone = value.Substring(0, 50);
                }
                else
                {
                    telefone = value;
                }
            }
        }

        public String Celular
        {
            get { return celular; }
            set
            {
                if (value.Length > 50)
                {
                    celular = value.Substring(0, 50);
                }
                else
                {
                    celular = value;
                }
            }
        }

        public String Email
        {
            get { return email; }
            set
            {
                if (value.Length > 50)
                {
                    email = value.Substring(0, 50);
                }
                else
                {
                    email = value;
                }
            }
        }
    }
}
