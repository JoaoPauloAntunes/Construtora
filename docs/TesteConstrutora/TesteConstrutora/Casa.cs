using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteConstrutora
{
    public class Casa : IBuilder
    {
        private Imovel casa;

        public Casa()
        {
            casa = new Imovel();
        }
        public void ConstrucaoBanheiro()
        {
            casa.Add("Banheiro a prova de bala.");
        }

        public void ConstrucaoEncanamento()
        {
            casa.Add("canos de titanio");
        }

        public void FinalizacaoOperacoes()
        {
            casa.Add("casa finalizada");
        }

        public Imovel GetImovel()
        {
            return casa;
        }

        public void InicializacaoOperacoes()
        {
            casa.Add("Ajustando o terreno e construindo muros ");
        }

        public void PintandoCasa()
        {
            casa.Add("Pintura cor de rosa");
        }

        public void QuantidadeComodos()
        {
            casa.Add("4");
        }

        public IBuilder ShallowCopy()
        {
            return (Casa)this.MemberwiseClone();
        }
    }
}
