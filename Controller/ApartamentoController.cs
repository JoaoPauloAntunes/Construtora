using System;
using System.Collections.Generic;
using System.Text;
using Model;

namespace Controller
{
    class ApartamentoController : IBuilder
    {
        ImovelModel imovelPadrao = new ImovelModel();
        public void ConstrucaoBanheiros()
        {
            imovelPadrao.Add("banheiro sem azuleijos");
        }

        public void ConstrucaoComodos()
        {
        }

        public void ConstrucaoEncanamento()
        {
            imovelPadrao.Add("Canos simples");
        }

        public void FinalizacaoOperacoes()
        {
            imovelPadrao.Add("Apartamento finalizado!");
        }

        public ImovelModel GetImovel()
        {
            return imovelPadrao;
        }

        public void InicializacaoOperacoes()
        {
        }

        public void PintandoCasa()
        {
            imovelPadrao.Add("Cor marrom");
        }

        public IBuilder ShallowCopy()
        {
            return (ApartamentoController)this.MemberwiseClone();
        }
    }
}
