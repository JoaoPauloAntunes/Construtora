using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteConstrutora
{
    public class Apartamento : IBuilder
    {
        private Imovel apartamento;

        public Apartamento()
        {
            apartamento = new Imovel();
        }
        public void ConstrucaoBanheiro()
        {
            apartamento.Add("banheiro sem azuleijos");
        }

        public void ConstrucaoEncanamento()
        {
            apartamento.Add("Canos simples");
        }

        public void FinalizacaoOperacoes()
        {
            apartamento.Add("Apartamento finalizado!");
        }

        public Imovel GetImovel()
        {
            return apartamento;
        }

        public void InicializacaoOperacoes()
        {
            
        }

        public void PintandoCasa()
        {
            apartamento.Add("Cor marrom");
        }

        public void QuantidadeComodos()
        {
            apartamento.Add("5 comodos");
        }

        public IBuilder ShallowCopy()
        {
            return (Apartamento)this.MemberwiseClone();
        }
    }
}
