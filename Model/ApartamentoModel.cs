using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class ApartamentoModel : PropriedadeModel
    {
        private ImovelModel apartamento;

        public ApartamentoModel()
        {
            apartamento = new ImovelModel();
        }
        private string tipoApartamentol;
        private Double valorCondominio;

        public string TipoApartamentol { get => tipoApartamentol; set => tipoApartamentol = value; }
        public double ValorCondominio { get => valorCondominio; set => valorCondominio = value; }
    }
}
