using System;
using System.Collections.Generic;
using System.Text;
using Model;
namespace Controller
{
    public class ChefeObraController
    {
        IBuilder builder;
        public void Construct(IBuilder builder)
        {
            this.builder = builder;
            builder.InicializacaoOperacoes();
            builder.ConstrucaoComodos();
            builder.ConstrucaoBanheiros();
            builder.ConstrucaoEncanamento();
            builder.PintandoCasa();
            builder.FinalizacaoOperacoes();
        }
    }
}
