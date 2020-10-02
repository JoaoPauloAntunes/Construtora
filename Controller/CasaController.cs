using System;
using System.Collections.Generic;
using System.Text;
using Model;

namespace Controller
{
    public class CasaController : IBuilder
    {
        ImovelModel imovelPadrao = new ImovelModel();
        public void ConstrucaoBanheiros()
        {
            
        }

        public void ConstrucaoComodos()
        {
            
        }

        public void ConstrucaoEncanamento()
        {
            
        }

        public void FinalizacaoOperacoes()
        {
            
        }

        public ImovelModel GetImovel()
        {
            throw new NotImplementedException();
        }

        public void InicializacaoOperacoes()
        {
            
        }

        public void PintandoCasa()
        {
            
        }

        public IBuilder ShallowCopy()
        {
            throw new NotImplementedException();
        }
    }
}
