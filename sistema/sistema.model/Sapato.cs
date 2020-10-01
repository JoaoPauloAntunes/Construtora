using System;
using System.Collections.Generic;
using System.Text;

namespace sistema.model
{
    public class Sapato : Produto
    {
        private int tamanho;
        private String marca;

        public String Marca
        {
            get { return marca; }
            set { marca = value; }
        }
        public int Tamanho
        {
            get { return tamanho; }
            set { tamanho = value; }
        }
        
    }
}
