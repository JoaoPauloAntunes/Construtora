using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class CasaModel : PropriedadeModel
    {
        private ImovelModel casa;

        public CasaModel()
        {
            casa = new ImovelModel();
        }

        private Boolean isCaixaDagua;
        private string marcaCano;

        public bool IsCaixaDagua { get => isCaixaDagua; set => isCaixaDagua = value; }
        public string MarcaCano { get => marcaCano; set => marcaCano = value; }
    }
}
