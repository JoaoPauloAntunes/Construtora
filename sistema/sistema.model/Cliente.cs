using System;
using System.Collections.Generic;
using System.Text;

namespace sistema.model
{
    public class Cliente : Pessoa
    {
        private String telefone;
        private String estadoCivil;
        
        public String Telefone
        {
            get { return telefone; }
            set { telefone = value; }
        }

        public String EstadoCivil
        {
            get { return estadoCivil; }
            set { estadoCivil = value; }
        }
    }
}
