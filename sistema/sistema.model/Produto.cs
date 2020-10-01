using System;
using System.Collections.Generic;
using System.Text;

namespace sistema.model
{
    public abstract class Produto
    {
        private int codigo;
        private Double valor;
        private String descricao;
        private int quantidade;

        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        public Double Valor
        {
            get { return valor; }
            set { valor = value; }
        }

        public String Descricao
        {
            get { return descricao; }
            set { descricao = value; }
        }

        public int Quantidade
        {
            get { return quantidade; }
            set { quantidade = value; }
        }

    }
}
