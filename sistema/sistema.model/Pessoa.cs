using System;
using System.Collections.Generic;
using System.Text;

namespace sistema.model
{
    public abstract class Pessoa
    {
        private String nome;
        private String cpf;
        private String cep;
        private int codigo;

        public String Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public String Cpf
        {
            get { return cpf; }
            set { cpf = value; }
        }

        private String Cep
        {
            get { return cep; }
            set { cep = value; }
        }
        private int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

    }
}
