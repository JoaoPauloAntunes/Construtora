using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteConstrutora
{
    public interface IBuilder
    {
        void InicializacaoOperacoes();
        void QuantidadeComodos();
        void ConstrucaoBanheiro();
        void ConstrucaoEncanamento();
        void PintandoCasa();
        void FinalizacaoOperacoes();
        IBuilder ShallowCopy();
        
        Imovel GetImovel();

    }
}
