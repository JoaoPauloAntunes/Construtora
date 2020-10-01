using System;
using System.Collections.Generic;
using System.Text;

namespace sistema.model
{
    public class Camisa : Produto
    {
        private String tamanho;
        private String marca;
        
        public String Tamanho
        {
            get { return tamanho; }
            set { tamanho = value; }
        }

        public String Marca
        {
            get { return marca; }
            set { marca = value; }
        }
    }
}
