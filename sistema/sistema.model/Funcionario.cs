using System;
using System.Collections.Generic;
using System.Text;

namespace sistema.model
{
    public class Funcionario
    {
        private String funcao;
        private Double salario;

        public String Funcao
        {
            get { return funcao; }
            set { funcao = value; }
        }

        public Double Salario
        {
            get { return salario; }
            set { salario = value; }
        }
    }
}
