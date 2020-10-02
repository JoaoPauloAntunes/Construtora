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
            imovelPadrao.Add("Banheiro a prova de bala.");
        }

        public void ConstrucaoComodos()
        {
            
        }

        public void ConstrucaoEncanamento()
        {
            imovelPadrao.Add("canos de titanio");
        }

        public void FinalizacaoOperacoes()
        {
            imovelPadrao.Add("imovelPadrao finalizada");
        }

        public ImovelModel GetImovel()
        {
            return imovelPadrao;
        }

        public void InicializacaoOperacoes()
        {
            imovelPadrao.Add("Ajustando o terreno e construindo muros ");
        }

        public void PintandoCasa()
        {
            imovelPadrao.Add("Pintura cor de rosa");
        }

        public IBuilder ShallowCopy()
        {
            return (CasaController)this.MemberwiseClone();
        }
    }
}
