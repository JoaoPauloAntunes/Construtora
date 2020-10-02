using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteConstrutora
{
    public class CrefeObra
    {
        IBuilder builder;

        //constroi passo a passo

        public void Construct(IBuilder builder)
        {
            this.builder = builder;
            builder.InicializacaoOperacoes();
            builder.QuantidadeComodos();
            builder.ConstrucaoEncanamento();
            builder.ConstrucaoBanheiro();
            builder.PintandoCasa();
            builder.FinalizacaoOperacoes();


        }
    }
}
