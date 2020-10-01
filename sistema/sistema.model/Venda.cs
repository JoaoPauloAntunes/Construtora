using System;
using System.Collections.Generic;
using System.Text;

namespace sistema.model
{
    public class Venda
    {
        private Double valor;
        private int codigoVenda;
        private int codigoCliente;
        private int codigoFuncionario;
        private String formaPagamento;
        private int codigoProduto;

        public Double Valor
        {
            get { return valor; }
            set { valor = value; }
        }

        public int CodigoVenda
        {
            get { return codigoVenda; }
            set { codigoVenda = value; }
        }
        
        public int CodigoCliente
        {
            get { return codigoCliente; }
            set { codigoCliente = value; }
        }

        public int CodigoFuncionario
        {
            get { return codigoFuncionario; }
            set { codigoFuncionario = value; }
        }

        public String FormaPagamento
        {
            get { return formaPagamento; }
            set { formaPagamento = value; }
        }

        public int CodigoProduto
        {
            get { return CodigoProduto; }
            set { codigoProduto = value; }
        }

    }
}
